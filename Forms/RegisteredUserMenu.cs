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
    public partial class RegisteredUserMenu : Form
    {

        private List<Product> products;
        private Product currentProduct;
        private int pointer = 0;
        private Session controller;
        private User user;



        public RegisteredUserMenu(User user)
        {
            InitializeComponent();
            this.user = user;
            this.controller = new Session(user);
        }


        private void productsButton_Click(object sender, EventArgs e)
        {
            products = controller.getAllProducts();
            currentProduct = products[pointer];
            setDataToLabels(currentProduct);
            nextButt.Visible = true;
            prevoiusButt.Visible = true;
            commentBox.Visible = true;
            commentButton.Visible = true;
            //scroller.Visible = true;

        }

        private void setDataToLabels(Product product)
        {
            removePreviousLabels();
            nameLabel.Text = product.name;
            priceLabel.Text = product.price + "$";
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
            if (labels != null)
            {
                foreach (Label label in labels)
                {
                    label.Enabled = false;
                    label.Hide();

                }
            }
        }

        List<Label> labels;
        private void setFeedback(List<Feedback> feedbacks)
        {
            labels = new List<Label>();
            int Lindex = 0;
            foreach (Feedback feedback in feedbacks)
            {

                Label label = new Label();
                label.Width = dialogPanel.Width - 20;
                label.Height = 50;
                label.Text = feedback.user.login + "\r\n" +
                             feedback.comment + "\r\n" +
                             feedback.date;
                label.Location = new Point(0, label.Height * Lindex);
                label.BorderStyle = BorderStyle.FixedSingle;
                Font font = new Font("Century Gothic", 8, FontStyle.Italic);
                label.Font = font;
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
            if (pointer > products.Count - 1)
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

        private void logoutButon_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Close();
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            String feedback = commentBox.Text;
            if (!String.IsNullOrEmpty(feedback))
            {
                controller.leaveFeedback(currentProduct.id, feedback);
                commentBox.Text = String.Empty;
                setDataToLabels(currentProduct);
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm(controller);
            form.Show();
        }

    }
}
