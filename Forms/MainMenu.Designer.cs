namespace DAL.Forms
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.productsButton = new System.Windows.Forms.Button();
            this.forgetPassword = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dialogPanel = new System.Windows.Forms.Panel();
            this.prevoiusButt = new System.Windows.Forms.Button();
            this.nextButt = new System.Windows.Forms.Button();
            this.avliableLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonExit = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.leftPanel.Controls.Add(this.mainPanel);
            this.leftPanel.Controls.Add(this.productsButton);
            this.leftPanel.Controls.Add(this.forgetPassword);
            this.leftPanel.Controls.Add(this.signUpButton);
            this.leftPanel.Controls.Add(this.SignInButton);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(223, 468);
            this.leftPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(229, 42);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(525, 432);
            this.mainPanel.TabIndex = 1;
            // 
            // productsButton
            // 
            this.productsButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productsButton.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productsButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.productsButton.Location = new System.Drawing.Point(0, 272);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(223, 61);
            this.productsButton.TabIndex = 3;
            this.productsButton.Text = "Products";
            this.productsButton.UseMnemonic = false;
            this.productsButton.UseVisualStyleBackColor = false;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            this.productsButton.MouseEnter += new System.EventHandler(this.productsButton_MouseEnter);
            this.productsButton.MouseLeave += new System.EventHandler(this.productsButton_MouseLeave);
            // 
            // forgetPassword
            // 
            this.forgetPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.forgetPassword.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forgetPassword.ForeColor = System.Drawing.Color.SteelBlue;
            this.forgetPassword.Location = new System.Drawing.Point(0, 205);
            this.forgetPassword.Name = "forgetPassword";
            this.forgetPassword.Size = new System.Drawing.Size(223, 61);
            this.forgetPassword.TabIndex = 2;
            this.forgetPassword.Text = "Forget Password";
            this.forgetPassword.UseMnemonic = false;
            this.forgetPassword.UseVisualStyleBackColor = false;
            this.forgetPassword.Click += new System.EventHandler(this.forgetPassword_Click);
            this.forgetPassword.MouseEnter += new System.EventHandler(this.forgetPassword_MouseEnter);
            this.forgetPassword.MouseLeave += new System.EventHandler(this.forgetPassword_MouseLeave);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.signUpButton.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.signUpButton.Location = new System.Drawing.Point(0, 138);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(223, 61);
            this.signUpButton.TabIndex = 1;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseMnemonic = false;
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click_1);
            this.signUpButton.MouseEnter += new System.EventHandler(this.signUpButton_MouseEnter);
            this.signUpButton.MouseHover += new System.EventHandler(this.signUpButton_MouseLeave);
            // 
            // SignInButton
            // 
            this.SignInButton.AutoEllipsis = true;
            this.SignInButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SignInButton.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.SignInButton.Location = new System.Drawing.Point(0, 74);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(223, 61);
            this.SignInButton.TabIndex = 0;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseMnemonic = false;
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            this.SignInButton.MouseEnter += new System.EventHandler(this.SignInButton_MouseEnter);
            this.SignInButton.MouseLeave += new System.EventHandler(this.SignInButton_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dialogPanel);
            this.panel1.Controls.Add(this.prevoiusButt);
            this.panel1.Controls.Add(this.nextButt);
            this.panel1.Controls.Add(this.avliableLabel);
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(228, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 425);
            this.panel1.TabIndex = 1;
            // 
            // dialogPanel
            // 
            this.dialogPanel.AutoScroll = true;
            this.dialogPanel.BackColor = System.Drawing.Color.White;
            this.dialogPanel.Location = new System.Drawing.Point(0, 239);
            this.dialogPanel.Name = "dialogPanel";
            this.dialogPanel.Size = new System.Drawing.Size(608, 186);
            this.dialogPanel.TabIndex = 6;
            // 
            // prevoiusButt
            // 
            this.prevoiusButt.BackColor = System.Drawing.Color.White;
            this.prevoiusButt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prevoiusButt.ForeColor = System.Drawing.Color.SteelBlue;
            this.prevoiusButt.Location = new System.Drawing.Point(4, 3);
            this.prevoiusButt.Name = "prevoiusButt";
            this.prevoiusButt.Size = new System.Drawing.Size(75, 36);
            this.prevoiusButt.TabIndex = 5;
            this.prevoiusButt.Text = "Prev";
            this.prevoiusButt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.prevoiusButt.UseVisualStyleBackColor = false;
            this.prevoiusButt.Visible = false;
            this.prevoiusButt.Click += new System.EventHandler(this.prevoiusButt_Click);
            // 
            // nextButt
            // 
            this.nextButt.BackColor = System.Drawing.Color.White;
            this.nextButt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButt.ForeColor = System.Drawing.Color.SteelBlue;
            this.nextButt.Location = new System.Drawing.Point(518, 3);
            this.nextButt.Name = "nextButt";
            this.nextButt.Size = new System.Drawing.Size(77, 36);
            this.nextButt.TabIndex = 4;
            this.nextButt.Text = "Next";
            this.nextButt.UseVisualStyleBackColor = false;
            this.nextButt.Visible = false;
            this.nextButt.Click += new System.EventHandler(this.nextButt_Click);
            // 
            // avliableLabel
            // 
            this.avliableLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avliableLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.avliableLabel.Location = new System.Drawing.Point(345, 197);
            this.avliableLabel.Name = "avliableLabel";
            this.avliableLabel.Size = new System.Drawing.Size(240, 36);
            this.avliableLabel.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.priceLabel.Location = new System.Drawing.Point(345, 130);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(240, 36);
            this.priceLabel.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.nameLabel.Location = new System.Drawing.Point(342, 45);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(253, 60);
            this.nameLabel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 190);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonExit.Location = new System.Drawing.Point(797, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(26, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 468);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Button forgetPassword;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label avliableLabel;
        private System.Windows.Forms.Button prevoiusButt;
        private System.Windows.Forms.Button nextButt;
        private System.Windows.Forms.Panel dialogPanel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttonExit;
    }
}