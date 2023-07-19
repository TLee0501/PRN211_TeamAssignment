namespace IT_Human_resource_manager_system
{
    partial class frmEmployeeDetails
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
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            txtUserName = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtPhoneNumber = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtBasicSalary = new System.Windows.Forms.TextBox();
            btnConfirm = new System.Windows.Forms.Button();
            btnCancle = new System.Windows.Forms.Button();
            cboRole = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(213, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(355, 45);
            label1.TabIndex = 0;
            label1.Text = "Employee Information";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(52, 90);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(68, 25);
            label3.TabIndex = 2;
            label3.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(52, 138);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(100, 25);
            label4.TabIndex = 3;
            label4.Text = "Username :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(434, 141);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(96, 25);
            label5.TabIndex = 4;
            label5.Text = "Password :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(52, 188);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(55, 25);
            label6.TabIndex = 5;
            label6.Text = "Role :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(52, 238);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(141, 25);
            label8.TabIndex = 7;
            label8.Text = "Phone Number :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(52, 283);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(63, 25);
            label9.TabIndex = 8;
            label9.Text = "Email :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(52, 331);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(112, 25);
            label10.TabIndex = 9;
            label10.Text = "Basic Salary :";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(202, 90);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(226, 31);
            txtName.TabIndex = 11;
            // 
            // txtUserName
            // 
            txtUserName.Location = new System.Drawing.Point(202, 138);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(226, 31);
            txtUserName.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(536, 135);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(226, 31);
            txtPassword.TabIndex = 13;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new System.Drawing.Point(202, 238);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new System.Drawing.Size(226, 31);
            txtPhoneNumber.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(202, 283);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(331, 31);
            txtEmail.TabIndex = 17;
            // 
            // txtBasicSalary
            // 
            txtBasicSalary.Location = new System.Drawing.Point(202, 328);
            txtBasicSalary.Name = "txtBasicSalary";
            txtBasicSalary.Size = new System.Drawing.Size(226, 31);
            txtBasicSalary.TabIndex = 18;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new System.Drawing.Point(202, 390);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(112, 34);
            btnConfirm.TabIndex = 19;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancle
            // 
            btnCancle.Location = new System.Drawing.Point(434, 390);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new System.Drawing.Size(112, 34);
            btnCancle.TabIndex = 20;
            btnCancle.Text = "Cancle";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Items.AddRange(new object[] { "Staff", "HR_Staff", "HR_Manager" });
            cboRole.Location = new System.Drawing.Point(202, 188);
            cboRole.Name = "cboRole";
            cboRole.Size = new System.Drawing.Size(226, 33);
            cboRole.TabIndex = 21;
            // 
            // frmEmployeeDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(783, 450);
            Controls.Add(cboRole);
            Controls.Add(btnCancle);
            Controls.Add(btnConfirm);
            Controls.Add(txtBasicSalary);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtName);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmEmployeeDetails";
            Text = "frmEmployeeDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.ComboBox cboRole;
    }
}