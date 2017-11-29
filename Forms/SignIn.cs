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
    public partial class SignIn : Form
    {
       
        public SignIn()
        {
            InitializeComponent();
          
        }

        SignInController controller = new SignInController();

        private void confirmButton_Click(object sender, EventArgs e)
        {
            String loging = loginBox.Text;
            String password = passwordBox.Text;
            if (!String.IsNullOrEmpty(loging) || !String.IsNullOrEmpty(password))
            {
                User user = controller.signIn(loging, password);
                if (user != null)
                {
                    Console.WriteLine(user.email);
                    RegisteredUserMenu userMenu = new RegisteredUserMenu(user); ;
                    userMenu.Show();
                    this.Close();
                }
                else
                {
                    errorLabel.ForeColor = Color.Red;
                    errorLabel.Text = "Invalid login or password";
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
