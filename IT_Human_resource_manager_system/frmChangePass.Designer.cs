namespace IT_Human_resource_manager_system
{
    partial class frmChangePass
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtOldPass = new System.Windows.Forms.TextBox();
            txtNewPass = new System.Windows.Forms.TextBox();
            txtConfirmNewPass = new System.Windows.Forms.TextBox();
            btnUpdatePass = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(42, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Old Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(42, 81);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "New Pasword";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(42, 124);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(160, 20);
            label3.TabIndex = 2;
            label3.Text = "Confirm new password";
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new System.Drawing.Point(223, 41);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.PasswordChar = '*';
            txtOldPass.Size = new System.Drawing.Size(193, 27);
            txtOldPass.TabIndex = 3;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new System.Drawing.Point(223, 81);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '*';
            txtNewPass.Size = new System.Drawing.Size(193, 27);
            txtNewPass.TabIndex = 4;
            // 
            // txtConfirmNewPass
            // 
            txtConfirmNewPass.Location = new System.Drawing.Point(223, 121);
            txtConfirmNewPass.Name = "txtConfirmNewPass";
            txtConfirmNewPass.PasswordChar = '*';
            txtConfirmNewPass.Size = new System.Drawing.Size(193, 27);
            txtConfirmNewPass.TabIndex = 5;
            // 
            // btnUpdatePass
            // 
            btnUpdatePass.Location = new System.Drawing.Point(367, 166);
            btnUpdatePass.Name = "btnUpdatePass";
            btnUpdatePass.Size = new System.Drawing.Size(141, 29);
            btnUpdatePass.TabIndex = 6;
            btnUpdatePass.Text = "Update Password";
            btnUpdatePass.UseVisualStyleBackColor = true;
            btnUpdatePass.Click += btnUpdatePass_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(256, 166);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmChangePass
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(520, 207);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdatePass);
            Controls.Add(txtConfirmNewPass);
            Controls.Add(txtNewPass);
            Controls.Add(txtOldPass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmChangePass";
            Text = "frmChangePass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtConfirmNewPass;
        private System.Windows.Forms.Button btnUpdatePass;
        private System.Windows.Forms.Button btnCancel;
    }
}