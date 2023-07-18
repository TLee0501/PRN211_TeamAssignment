namespace IT_Human_resource_manager_system
{
    partial class frmLogin
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
            lbEmail = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            lbLogin = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(29, 65);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(60, 15);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(29, 111);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(57, 15);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(116, 63);
            txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(199, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(116, 109);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(199, 23);
            txtPassword.TabIndex = 3;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbLogin.Location = new System.Drawing.Point(187, 18);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new System.Drawing.Size(51, 21);
            lbLogin.TabIndex = 4;
            lbLogin.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(297, 148);
            btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(82, 22);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(420, 198);
            Controls.Add(btnLogin);
            Controls.Add(lbLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Button btnLogin;
    }
}