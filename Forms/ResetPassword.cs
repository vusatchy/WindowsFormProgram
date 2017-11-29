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

namespace DAL.Forms
{
    public partial class ResetPassword : Form
    {


        public ResetPassword()
        {
            InitializeComponent();
        }

        PasswordReset reset = new PasswordReset();

        private void confirmResetButton_Click(object sender, EventArgs e)
        {
            String mail = mailBox.Text;
            if (!String.IsNullOrEmpty(mail))
            {
                if (reset.resetPasswordViaEmail(mail))
                {
                    resultLabel.ForeColor=Color.Green;
                    resultLabel.Text = "New password was sent on your e-mail";
                }
                else
                {
                    resultLabel.ForeColor = Color.Red;
                    resultLabel.Text = "Invalid e-mail";
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
