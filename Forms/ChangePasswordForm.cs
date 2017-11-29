using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BuisenessLayer;

namespace DAL.Forms
{
    public partial class ChangePasswordForm : Form
    {
        Session session;
        private static String errorMessageNotInput = "Please input two passwords";
        private static String errorOldPasswordDoesntMatch = "Please input correct current password";
        private static String infoOK="Current password changed"
;
        public ChangePasswordForm(Session session)
        {
            InitializeComponent();
            this.session = session;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            String oldPassword = oldPasswordBox.Text;
            String newPassword = newPasswordBox.Text;
            if (!String.IsNullOrEmpty(oldPassword) && !String.IsNullOrEmpty(newPassword))
            {
                if (session.checkPassword(oldPassword))
                {
                   session.changePassword(newPassword);
                   infoLabel.ForeColor = Color.Green;
                   infoLabel.Text = infoOK;
                }
                else
                {
                    infoLabel.ForeColor = Color.Red;
                    infoLabel.Text =errorOldPasswordDoesntMatch;
                }
            }
            else
            {
                infoLabel.ForeColor = Color.Red;
                infoLabel.Text = errorMessageNotInput;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   


    }
}
