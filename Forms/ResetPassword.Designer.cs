namespace DAL.Forms
{
    partial class ResetPassword
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
            this.mailBox = new System.Windows.Forms.TextBox();
            this.confirmResetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(66, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reset Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(69, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input your e-mail";
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(73, 100);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(263, 20);
            this.mailBox.TabIndex = 2;
            // 
            // confirmResetButton
            // 
            this.confirmResetButton.BackColor = System.Drawing.Color.White;
            this.confirmResetButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmResetButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.confirmResetButton.Location = new System.Drawing.Point(140, 168);
            this.confirmResetButton.Name = "confirmResetButton";
            this.confirmResetButton.Size = new System.Drawing.Size(112, 31);
            this.confirmResetButton.TabIndex = 3;
            this.confirmResetButton.Text = "Reset";
            this.confirmResetButton.UseVisualStyleBackColor = false;
            this.confirmResetButton.Click += new System.EventHandler(this.confirmResetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.exitButton.Location = new System.Drawing.Point(371, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(69, 138);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 19);
            this.resultLabel.TabIndex = 7;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 228);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.confirmResetButton);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.Button confirmResetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label resultLabel;
    }
}