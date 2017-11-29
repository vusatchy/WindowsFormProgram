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
    public partial class MainMenu : Form
    {

        NotRegisteredUserController controller = new NotRegisteredUserController();
        List<Product> products;
        Product currentProduct;
        int pointer = 0;

        public MainMenu()
        {
            InitializeComponent();
        }





        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
        }

        private void signUpButton_MouseEnter(object sender, EventArgs e)
        {
            signUpButton.BackColor = Color.LightGreen;
        }

        private void signUpButton_MouseLeave(object sender, EventArgs e)
        {
            signUpButton.BackColor = Color.WhiteSmoke;
        }

        private void SignInButton_MouseEnter(object sender, EventArgs e)
        {
            SignInButton.BackColor = Color.LightGreen;
        }

        private void forgetPassword_MouseLeave(object sender, EventArgs e)
        {

            forgetPassword.BackColor = Color.WhiteSmoke;
        }

        private void forgetPassword_MouseEnter(object sender, EventArgs e)
        {
            forgetPassword.BackColor = Color.LightGreen;
        }


        private void SignInButton_MouseLeave(object sender, EventArgs e)
        {
            SignInButton.BackColor = Color.WhiteSmoke;
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            products = controller.getAllProducts();
            currentProduct = products[pointer];
            setDataToLabels(currentProduct);
            nextButt.Visible = true;
            prevoiusButt.Visible = true;
            //scroller.Visible = true;
            
        }

        private void setDataToLabels(Product product)
        {
            removePreviousLabels();
            nameLabel.Text = product.name;
            priceLabel.Text = product.price+"$";
            if (product.isAvaliable)
            {
                avliableLabel.Text = "avaliable";
            }
            else
            {
                avliableLabel.Text = "unavaliable";
            }
            setFeedback(controller.getAllFeedbacksWithProudct(product.id));
           
        }

        private void removePreviousLabels()
        {
            if (labels != null) { 
            foreach (Label label in labels)
            {
                label.Enabled=false;
                label.Hide(); 

            }
            }
        }

        List<Label> labels;
        private void setFeedback(List<Feedback> feedbacks)
        {
            labels=new List<Label>(); 
            int Lindex = 0;
            foreach (Feedback feedback in feedbacks)
            {
               
                Label label = new Label();
                label.Width = dialogPanel.Width-20;
                label.Height = 50;
                label.Text = feedback.user.login+"\r\n"+
                             feedback.comment + "\r\n"+
                             feedback.date;
                label.Location = new Point(0,label.Height*Lindex);
                label.BorderStyle = BorderStyle.FixedSingle;
                Font font = new Font("Century Gothic", 8, FontStyle.Italic);
                label.Font=font;
                label.ForeColor = Color.SteelBlue;
                Lindex++;
                dialogPanel.Controls.Add(label);
                labels.Add(label);
            }
        }


        private void productsButton_MouseEnter(object sender, EventArgs e)
        {
            productsButton.BackColor = Color.LightGreen;
        }

        private void productsButton_MouseLeave(object sender, EventArgs e)
        {
            productsButton.BackColor = Color.WhiteSmoke;
        }

        private void nextButt_Click(object sender, EventArgs e)
        {
            pointer++;
            if (pointer > products.Count-1)
            {
                pointer = 0;
            }
            currentProduct = products[pointer];
            setDataToLabels(currentProduct);

        }

        private void prevoiusButt_Click(object sender, EventArgs e)
        {
            pointer--;
            if (pointer < 0)
            {
                pointer = products.Count - 1;
            }
            currentProduct = products[pointer];
            setDataToLabels(currentProduct);
        }

     

        private void signUpButton_Click_1(object sender, EventArgs e)
        {
            
            SignUpFormcs signUp = new SignUpFormcs();
            signUp.Show();
        }

        private void forgetPassword_Click(object sender, EventArgs e)
        {
            ResetPassword reset = new ResetPassword();
            reset.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


   


   
    }
}
