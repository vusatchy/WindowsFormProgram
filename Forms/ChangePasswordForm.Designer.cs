namespace DAL.Forms
{
    partial class ChangePasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.oldPasswordBox = new System.Windows.Forms.TextBox();
            this.newPasswordBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(133, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(134, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Old password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(134, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "New password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.White;
            this.changeButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.changeButton.Location = new System.Drawing.Point(197, 257);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(111, 37);
            this.changeButton.TabIndex = 3;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // oldPasswordBox
            // 
            this.oldPasswordBox.Location = new System.Drawing.Point(139, 147);
            this.oldPasswordBox.Name = "oldPasswordBox";
            this.oldPasswordBox.PasswordChar = '*';
            this.oldPasswordBox.Size = new System.Drawing.Size(267, 20);
            this.oldPasswordBox.TabIndex = 4;
            // 
            // newPasswordBox
            // 
            this.newPasswordBox.Location = new System.Drawing.Point(139, 201);
            this.newPasswordBox.Name = "newPasswordBox";
            this.newPasswordBox.PasswordChar = '*';
            this.newPasswordBox.Size = new System.Drawing.Size(267, 20);
            this.newPasswordBox.TabIndex = 5;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.closeButton.Location = new System.Drawing.Point(522, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(22, 30);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.infoLabel.Location = new System.Drawing.Point(167, 224);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 19);
            this.infoLabel.TabIndex = 7;
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 335);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.newPasswordBox);
            this.Controls.Add(this.oldPasswordBox);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox oldPasswordBox;
        private System.Windows.Forms.TextBox newPasswordBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label infoLabel;
    }
}