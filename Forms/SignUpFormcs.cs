using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisenessLayer;
using Entities;
namespace DAL.Forms
{
    public partial class SignUpFormcs : Form
    {
        RegistrationController controller = new RegistrationController();

        public SignUpFormcs()
        {
            InitializeComponent();
            radioButtonMale.Checked = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private static String mailOrLoginAlreadyExistError = "Your mail or login already exist!";
        private static String passwordsDoesntMatchError = "Passwords doesn't match!";
        private static String invalidMailError = "Invalid e-mail!";
        private static String invalidPasswordError = "Invalid password!";
        private static String somethingWasntInputError = "Something wasn't input!";


        private void signUpButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            String mail = textBoxMail.Text;
            String login = textBoxLogin.Text;
            String password = textBoxPassword.Text;
            String repeatPassword = textBoxRepeatPassword.Text;
            Sex sex;

            if (String.IsNullOrEmpty(login)||String.IsNullOrEmpty(mail)||String.IsNullOrEmpty(password)||String.IsNullOrEmpty(repeatPassword))
            {
                errorLabel.Text = somethingWasntInputError;
                return;
            }
            if (radioButtonMale.Checked)
            {
                sex = Sex.MALE;
            }
            else
            {
                sex = Sex.FEMALE;
            }

            if(controller.isAlreadyExistEmail(mail)||controller.isAlreadyExistLogin(login))
            {
                   errorLabel.Text=mailOrLoginAlreadyExistError;
                   return;
            }
            if (!password.Equals(repeatPassword))
            {
                    errorLabel.Text = passwordsDoesntMatchError;
                    return;
            }
            if (!controller.isValidPassword(password))
            {
                     errorLabel.Text = invalidPasswordError; 
                     return;
            }
            if (controller.isValidEmail(mail))
            {
                     errorLabel.Text = invalidMailError;
                     return;
            }
           
            user.login = login;
            user.email = mail;
            user.password = password;
            user.sex = sex;
            user.registrationTime = DateTime.Now;

            controller.registerUser(user);
            this.Close();
            
        }

     
    }
}
