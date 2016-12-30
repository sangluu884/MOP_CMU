namespace WindowsFormsApplication
{
    partial class GUI_LoginFrm
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassoword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblAUsername = new System.Windows.Forms.Label();
            this.lblAPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(85, 56);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(201, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // txtPassoword
            // 
            this.txtPassoword.Location = new System.Drawing.Point(85, 97);
            this.txtPassoword.Name = "txtPassoword";
            this.txtPassoword.PasswordChar = '*';
            this.txtPassoword.Size = new System.Drawing.Size(201, 20);
            this.txtPassoword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(211, 167);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnLogin_KeyUp);
            // 
            // lblAUsername
            // 
            this.lblAUsername.AutoSize = true;
            this.lblAUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblAUsername.Location = new System.Drawing.Point(72, 134);
            this.lblAUsername.Name = "lblAUsername";
            this.lblAUsername.Size = new System.Drawing.Size(35, 13);
            this.lblAUsername.TabIndex = 6;
            this.lblAUsername.Text = "label4";
            // 
            // lblAPassword
            // 
            this.lblAPassword.AutoSize = true;
            this.lblAPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblAPassword.Location = new System.Drawing.Point(72, 147);
            this.lblAPassword.Name = "lblAPassword";
            this.lblAPassword.Size = new System.Drawing.Size(35, 13);
            this.lblAPassword.TabIndex = 7;
            this.lblAPassword.Text = "label4";
            // 
            // GUI_LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication.Properties.Resources._8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(307, 202);
            this.Controls.Add(this.lblAPassword);
            this.Controls.Add(this.lblAUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassoword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI_LoginFrm";
            this.Text = "GUI_LoginFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassoword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblAUsername;
        private System.Windows.Forms.Label lblAPassword;
    }
}