﻿namespace IT_Human_resource_manager_system
{
    partial class frmStaff
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
            CheckAttendance = new System.Windows.Forms.TabPage();
            btnCheckAttendance = new System.Windows.Forms.Button();
            Reports = new System.Windows.Forms.TabPage();
            btnCreateR = new System.Windows.Forms.Button();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            comboBox1 = new System.Windows.Forms.ComboBox();
            lbDescribe = new System.Windows.Forms.Label();
            lbEndDate = new System.Windows.Forms.Label();
            lbStartDate = new System.Windows.Forms.Label();
            lbReportType = new System.Windows.Forms.Label();
            Payslip_Payroll = new System.Windows.Forms.TabPage();
            textBox8 = new System.Windows.Forms.TextBox();
            textBox7 = new System.Windows.Forms.TextBox();
            textBox6 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            lbTax = new System.Windows.Forms.Label();
            lbNetSalary = new System.Windows.Forms.Label();
            lbBasicSalary = new System.Windows.Forms.Label();
            lbAllowances = new System.Windows.Forms.Label();
            lxDeductions = new System.Windows.Forms.Label();
            lbPayPeriod = new System.Windows.Forms.Label();
            lbEName = new System.Windows.Forms.Label();
            Take_Leave = new System.Windows.Forms.TabPage();
            rtbReasonTL = new System.Windows.Forms.RichTextBox();
            btnResetL = new System.Windows.Forms.Button();
            btnSubmitTakeLeave = new System.Windows.Forms.Button();
            dtpTLToDate = new System.Windows.Forms.DateTimePicker();
            dtpTLFromDate = new System.Windows.Forms.DateTimePicker();
            lbReason = new System.Windows.Forms.Label();
            lbToDate = new System.Windows.Forms.Label();
            lbFromDate = new System.Windows.Forms.Label();
            Manage_LogOT = new System.Windows.Forms.TabPage();
            txtTimeOT = new System.Windows.Forms.TextBox();
            btnReset = new System.Windows.Forms.Button();
            btnSubmit = new System.Windows.Forms.Button();
            dtpOT = new System.Windows.Forms.DateTimePicker();
            lbTimeIn = new System.Windows.Forms.Label();
            lbDate = new System.Windows.Forms.Label();
            Person_info = new System.Windows.Forms.TabPage();
            btnChangePass = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            txtPhonenumber = new System.Windows.Forms.TextBox();
            TxtEmail = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            lbPhonenumber = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            lbName = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            label1 = new System.Windows.Forms.Label();
            btnLogout = new System.Windows.Forms.Button();
            CheckAttendance.SuspendLayout();
            Reports.SuspendLayout();
            Payslip_Payroll.SuspendLayout();
            Take_Leave.SuspendLayout();
            Manage_LogOT.SuspendLayout();
            Person_info.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // CheckAttendance
            // 
            CheckAttendance.Controls.Add(btnCheckAttendance);
            CheckAttendance.Location = new System.Drawing.Point(4, 29);
            CheckAttendance.Name = "CheckAttendance";
            CheckAttendance.Padding = new System.Windows.Forms.Padding(3);
            CheckAttendance.Size = new System.Drawing.Size(898, 355);
            CheckAttendance.TabIndex = 5;
            CheckAttendance.Text = "CheckAttendance";
            CheckAttendance.UseVisualStyleBackColor = true;
            // 
            // btnCheckAttendance
            // 
            btnCheckAttendance.BackColor = System.Drawing.Color.Cyan;
            btnCheckAttendance.Location = new System.Drawing.Point(284, 91);
            btnCheckAttendance.Name = "btnCheckAttendance";
            btnCheckAttendance.Size = new System.Drawing.Size(296, 118);
            btnCheckAttendance.TabIndex = 0;
            btnCheckAttendance.Text = "Check Attendance";
            btnCheckAttendance.UseVisualStyleBackColor = false;
            btnCheckAttendance.Click += btnCheckAttendance_Click;
            // 
            // Reports
            // 
            Reports.Controls.Add(btnCreateR);
            Reports.Controls.Add(richTextBox1);
            Reports.Controls.Add(dateTimePicker5);
            Reports.Controls.Add(dateTimePicker4);
            Reports.Controls.Add(comboBox1);
            Reports.Controls.Add(lbDescribe);
            Reports.Controls.Add(lbEndDate);
            Reports.Controls.Add(lbStartDate);
            Reports.Controls.Add(lbReportType);
            Reports.Location = new System.Drawing.Point(4, 29);
            Reports.Name = "Reports";
            Reports.Padding = new System.Windows.Forms.Padding(3);
            Reports.Size = new System.Drawing.Size(898, 355);
            Reports.TabIndex = 4;
            Reports.Text = "Reports";
            Reports.UseVisualStyleBackColor = true;
            // 
            // btnCreateR
            // 
            btnCreateR.Location = new System.Drawing.Point(488, 304);
            btnCreateR.Name = "btnCreateR";
            btnCreateR.Size = new System.Drawing.Size(139, 29);
            btnCreateR.TabIndex = 8;
            btnCreateR.Text = "Create Report";
            btnCreateR.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(173, 187);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(250, 120);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Location = new System.Drawing.Point(173, 139);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new System.Drawing.Size(250, 27);
            dateTimePicker5.TabIndex = 6;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new System.Drawing.Point(173, 88);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new System.Drawing.Size(250, 27);
            dateTimePicker4.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(173, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(250, 28);
            comboBox1.TabIndex = 4;
            // 
            // lbDescribe
            // 
            lbDescribe.AutoSize = true;
            lbDescribe.Location = new System.Drawing.Point(33, 187);
            lbDescribe.Name = "lbDescribe";
            lbDescribe.Size = new System.Drawing.Size(67, 20);
            lbDescribe.TabIndex = 3;
            lbDescribe.Text = "Describe";
            // 
            // lbEndDate
            // 
            lbEndDate.AutoSize = true;
            lbEndDate.Location = new System.Drawing.Point(33, 139);
            lbEndDate.Name = "lbEndDate";
            lbEndDate.Size = new System.Drawing.Size(66, 20);
            lbEndDate.TabIndex = 2;
            lbEndDate.Text = "EndDate";
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new System.Drawing.Point(33, 88);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new System.Drawing.Size(72, 20);
            lbStartDate.TabIndex = 1;
            lbStartDate.Text = "StartDate";
            // 
            // lbReportType
            // 
            lbReportType.AutoSize = true;
            lbReportType.Location = new System.Drawing.Point(33, 31);
            lbReportType.Name = "lbReportType";
            lbReportType.Size = new System.Drawing.Size(89, 20);
            lbReportType.TabIndex = 0;
            lbReportType.Text = "Report Type";
            // 
            // Payslip_Payroll
            // 
            Payslip_Payroll.Controls.Add(textBox8);
            Payslip_Payroll.Controls.Add(textBox7);
            Payslip_Payroll.Controls.Add(textBox6);
            Payslip_Payroll.Controls.Add(textBox5);
            Payslip_Payroll.Controls.Add(textBox4);
            Payslip_Payroll.Controls.Add(textBox3);
            Payslip_Payroll.Controls.Add(textBox2);
            Payslip_Payroll.Controls.Add(button1);
            Payslip_Payroll.Controls.Add(lbTax);
            Payslip_Payroll.Controls.Add(lbNetSalary);
            Payslip_Payroll.Controls.Add(lbBasicSalary);
            Payslip_Payroll.Controls.Add(lbAllowances);
            Payslip_Payroll.Controls.Add(lxDeductions);
            Payslip_Payroll.Controls.Add(lbPayPeriod);
            Payslip_Payroll.Controls.Add(lbEName);
            Payslip_Payroll.Location = new System.Drawing.Point(4, 29);
            Payslip_Payroll.Name = "Payslip_Payroll";
            Payslip_Payroll.Padding = new System.Windows.Forms.Padding(3);
            Payslip_Payroll.Size = new System.Drawing.Size(898, 355);
            Payslip_Payroll.TabIndex = 3;
            Payslip_Payroll.Text = "Payslip/Payroll";
            Payslip_Payroll.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new System.Drawing.Point(213, 277);
            textBox8.Name = "textBox8";
            textBox8.Size = new System.Drawing.Size(211, 27);
            textBox8.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.Location = new System.Drawing.Point(212, 241);
            textBox7.Name = "textBox7";
            textBox7.Size = new System.Drawing.Size(212, 27);
            textBox7.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(213, 200);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(211, 27);
            textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(212, 160);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(212, 27);
            textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(212, 121);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(212, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(212, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(212, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(213, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(211, 27);
            textBox2.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(656, 310);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = true;
            // 
            // lbTax
            // 
            lbTax.AutoSize = true;
            lbTax.Location = new System.Drawing.Point(41, 241);
            lbTax.Name = "lbTax";
            lbTax.Size = new System.Drawing.Size(34, 20);
            lbTax.TabIndex = 6;
            lbTax.Text = " Tax";
            // 
            // lbNetSalary
            // 
            lbNetSalary.AutoSize = true;
            lbNetSalary.Location = new System.Drawing.Point(41, 277);
            lbNetSalary.Name = "lbNetSalary";
            lbNetSalary.Size = new System.Drawing.Size(77, 20);
            lbNetSalary.TabIndex = 5;
            lbNetSalary.Text = "Net Salary";
            // 
            // lbBasicSalary
            // 
            lbBasicSalary.AutoSize = true;
            lbBasicSalary.Location = new System.Drawing.Point(41, 124);
            lbBasicSalary.Name = "lbBasicSalary";
            lbBasicSalary.Size = new System.Drawing.Size(87, 20);
            lbBasicSalary.TabIndex = 4;
            lbBasicSalary.Text = "Basic Salary";
            // 
            // lbAllowances
            // 
            lbAllowances.AutoSize = true;
            lbAllowances.Location = new System.Drawing.Point(41, 167);
            lbAllowances.Name = "lbAllowances";
            lbAllowances.Size = new System.Drawing.Size(84, 20);
            lbAllowances.TabIndex = 3;
            lbAllowances.Text = "Allowances";
            // 
            // lxDeductions
            // 
            lxDeductions.AutoSize = true;
            lxDeductions.Location = new System.Drawing.Point(41, 200);
            lxDeductions.Name = "lxDeductions";
            lxDeductions.Size = new System.Drawing.Size(84, 20);
            lxDeductions.TabIndex = 2;
            lxDeductions.Text = "Deductions";
            // 
            // lbPayPeriod
            // 
            lbPayPeriod.AutoSize = true;
            lbPayPeriod.Location = new System.Drawing.Point(41, 85);
            lbPayPeriod.Name = "lbPayPeriod";
            lbPayPeriod.Size = new System.Drawing.Size(77, 20);
            lbPayPeriod.TabIndex = 1;
            lbPayPeriod.Text = "Pay Period";
            // 
            // lbEName
            // 
            lbEName.AutoSize = true;
            lbEName.Location = new System.Drawing.Point(41, 43);
            lbEName.Name = "lbEName";
            lbEName.Size = new System.Drawing.Size(123, 20);
            lbEName.TabIndex = 0;
            lbEName.Text = " Employee Name";
            // 
            // Take_Leave
            // 
            Take_Leave.Controls.Add(rtbReasonTL);
            Take_Leave.Controls.Add(btnResetL);
            Take_Leave.Controls.Add(btnSubmitTakeLeave);
            Take_Leave.Controls.Add(dtpTLToDate);
            Take_Leave.Controls.Add(dtpTLFromDate);
            Take_Leave.Controls.Add(lbReason);
            Take_Leave.Controls.Add(lbToDate);
            Take_Leave.Controls.Add(lbFromDate);
            Take_Leave.Location = new System.Drawing.Point(4, 29);
            Take_Leave.Name = "Take_Leave";
            Take_Leave.Padding = new System.Windows.Forms.Padding(3);
            Take_Leave.Size = new System.Drawing.Size(898, 355);
            Take_Leave.TabIndex = 2;
            Take_Leave.Text = "Take Leave";
            Take_Leave.UseVisualStyleBackColor = true;
            // 
            // rtbReasonTL
            // 
            rtbReasonTL.Location = new System.Drawing.Point(125, 149);
            rtbReasonTL.Name = "rtbReasonTL";
            rtbReasonTL.Size = new System.Drawing.Size(250, 120);
            rtbReasonTL.TabIndex = 11;
            rtbReasonTL.Text = "";
            // 
            // btnResetL
            // 
            btnResetL.Location = new System.Drawing.Point(504, 299);
            btnResetL.Name = "btnResetL";
            btnResetL.Size = new System.Drawing.Size(94, 29);
            btnResetL.TabIndex = 10;
            btnResetL.Text = "Reset";
            btnResetL.UseVisualStyleBackColor = true;
            btnResetL.Click += btnResetL_Click;
            // 
            // btnSubmitTakeLeave
            // 
            btnSubmitTakeLeave.Location = new System.Drawing.Point(380, 299);
            btnSubmitTakeLeave.Name = "btnSubmitTakeLeave";
            btnSubmitTakeLeave.Size = new System.Drawing.Size(94, 29);
            btnSubmitTakeLeave.TabIndex = 9;
            btnSubmitTakeLeave.Text = "Submit";
            btnSubmitTakeLeave.UseVisualStyleBackColor = true;
            btnSubmitTakeLeave.Click += btnSubmitTakeLeave_Click;
            // 
            // dtpTLToDate
            // 
            dtpTLToDate.Location = new System.Drawing.Point(125, 97);
            dtpTLToDate.Name = "dtpTLToDate";
            dtpTLToDate.Size = new System.Drawing.Size(250, 27);
            dtpTLToDate.TabIndex = 5;
            // 
            // dtpTLFromDate
            // 
            dtpTLFromDate.Location = new System.Drawing.Point(125, 54);
            dtpTLFromDate.Name = "dtpTLFromDate";
            dtpTLFromDate.Size = new System.Drawing.Size(250, 27);
            dtpTLFromDate.TabIndex = 4;
            // 
            // lbReason
            // 
            lbReason.AutoSize = true;
            lbReason.Location = new System.Drawing.Point(31, 152);
            lbReason.Name = "lbReason";
            lbReason.Size = new System.Drawing.Size(57, 20);
            lbReason.TabIndex = 2;
            lbReason.Text = "Reason";
            // 
            // lbToDate
            // 
            lbToDate.AutoSize = true;
            lbToDate.Location = new System.Drawing.Point(31, 104);
            lbToDate.Name = "lbToDate";
            lbToDate.Size = new System.Drawing.Size(57, 20);
            lbToDate.TabIndex = 1;
            lbToDate.Text = "ToDate";
            // 
            // lbFromDate
            // 
            lbFromDate.AutoSize = true;
            lbFromDate.Location = new System.Drawing.Point(31, 59);
            lbFromDate.Name = "lbFromDate";
            lbFromDate.Size = new System.Drawing.Size(75, 20);
            lbFromDate.TabIndex = 0;
            lbFromDate.Text = "FromDate";
            // 
            // Manage_LogOT
            // 
            Manage_LogOT.Controls.Add(txtTimeOT);
            Manage_LogOT.Controls.Add(btnReset);
            Manage_LogOT.Controls.Add(btnSubmit);
            Manage_LogOT.Controls.Add(dtpOT);
            Manage_LogOT.Controls.Add(lbTimeIn);
            Manage_LogOT.Controls.Add(lbDate);
            Manage_LogOT.Location = new System.Drawing.Point(4, 29);
            Manage_LogOT.Name = "Manage_LogOT";
            Manage_LogOT.Padding = new System.Windows.Forms.Padding(3);
            Manage_LogOT.Size = new System.Drawing.Size(898, 355);
            Manage_LogOT.TabIndex = 1;
            Manage_LogOT.Text = "Manage Log OT";
            Manage_LogOT.UseVisualStyleBackColor = true;
            // 
            // txtTimeOT
            // 
            txtTimeOT.Location = new System.Drawing.Point(134, 94);
            txtTimeOT.Name = "txtTimeOT";
            txtTimeOT.Size = new System.Drawing.Size(254, 27);
            txtTimeOT.TabIndex = 6;
            // 
            // btnReset
            // 
            btnReset.Location = new System.Drawing.Point(508, 177);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(94, 29);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new System.Drawing.Point(374, 177);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(94, 29);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dtpOT
            // 
            dtpOT.Location = new System.Drawing.Point(134, 43);
            dtpOT.Name = "dtpOT";
            dtpOT.Size = new System.Drawing.Size(254, 27);
            dtpOT.TabIndex = 4;
            // 
            // lbTimeIn
            // 
            lbTimeIn.AutoSize = true;
            lbTimeIn.Location = new System.Drawing.Point(33, 97);
            lbTimeIn.Name = "lbTimeIn";
            lbTimeIn.Size = new System.Drawing.Size(42, 20);
            lbTimeIn.TabIndex = 1;
            lbTimeIn.Text = "Time";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Location = new System.Drawing.Point(33, 50);
            lbDate.Name = "lbDate";
            lbDate.Size = new System.Drawing.Size(41, 20);
            lbDate.TabIndex = 0;
            lbDate.Text = "Date";
            // 
            // Person_info
            // 
            Person_info.Controls.Add(btnChangePass);
            Person_info.Controls.Add(btnUpdate);
            Person_info.Controls.Add(txtPhonenumber);
            Person_info.Controls.Add(TxtEmail);
            Person_info.Controls.Add(txtName);
            Person_info.Controls.Add(lbPhonenumber);
            Person_info.Controls.Add(lbEmail);
            Person_info.Controls.Add(lbName);
            Person_info.Location = new System.Drawing.Point(4, 29);
            Person_info.Name = "Person_info";
            Person_info.Padding = new System.Windows.Forms.Padding(3);
            Person_info.Size = new System.Drawing.Size(898, 355);
            Person_info.TabIndex = 0;
            Person_info.Text = "Information";
            Person_info.UseVisualStyleBackColor = true;
            // 
            // btnChangePass
            // 
            btnChangePass.Location = new System.Drawing.Point(600, 261);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new System.Drawing.Size(128, 51);
            btnChangePass.TabIndex = 9;
            btnChangePass.Text = "Change PassWord";
            btnChangePass.UseVisualStyleBackColor = true;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(734, 261);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(129, 51);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update Information";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPhonenumber
            // 
            txtPhonenumber.Location = new System.Drawing.Point(234, 144);
            txtPhonenumber.Name = "txtPhonenumber";
            txtPhonenumber.Size = new System.Drawing.Size(566, 27);
            txtPhonenumber.TabIndex = 6;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new System.Drawing.Point(234, 97);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new System.Drawing.Size(566, 27);
            TxtEmail.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(234, 45);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(566, 27);
            txtName.TabIndex = 4;
            // 
            // lbPhonenumber
            // 
            lbPhonenumber.AutoSize = true;
            lbPhonenumber.Location = new System.Drawing.Point(39, 151);
            lbPhonenumber.Name = "lbPhonenumber";
            lbPhonenumber.Size = new System.Drawing.Size(104, 20);
            lbPhonenumber.TabIndex = 2;
            lbPhonenumber.Text = "PhoneNumber";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(39, 97);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new System.Drawing.Point(39, 45);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(49, 20);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(CheckAttendance);
            tabControl1.Controls.Add(Person_info);
            tabControl1.Controls.Add(Manage_LogOT);
            tabControl1.Controls.Add(Take_Leave);
            tabControl1.Controls.Add(Payslip_Payroll);
            tabControl1.Controls.Add(Reports);
            tabControl1.Location = new System.Drawing.Point(8, 128);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(906, 388);
            tabControl1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(341, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(172, 81);
            label1.TabIndex = 10;
            label1.Text = "Staff";
            // 
            // btnLogout
            // 
            btnLogout.Location = new System.Drawing.Point(781, 68);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(94, 29);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmStaff
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(924, 528);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "frmStaff";
            Text = "Staff";
            Load += frmStaff_Load;
            CheckAttendance.ResumeLayout(false);
            Reports.ResumeLayout(false);
            Reports.PerformLayout();
            Payslip_Payroll.ResumeLayout(false);
            Payslip_Payroll.PerformLayout();
            Take_Leave.ResumeLayout(false);
            Take_Leave.PerformLayout();
            Manage_LogOT.ResumeLayout(false);
            Manage_LogOT.PerformLayout();
            Person_info.ResumeLayout(false);
            Person_info.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabPage CheckAttendance;
        private System.Windows.Forms.TabPage Reports;
        private System.Windows.Forms.Button btnCreateR;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbDescribe;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label lbReportType;
        private System.Windows.Forms.TabPage Payslip_Payroll;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTax;
        private System.Windows.Forms.Label lbNetSalary;
        private System.Windows.Forms.Label lbBasicSalary;
        private System.Windows.Forms.Label lbAllowances;
        private System.Windows.Forms.Label lxDeductions;
        private System.Windows.Forms.Label lbPayPeriod;
        private System.Windows.Forms.Label lbEName;
        private System.Windows.Forms.TabPage Take_Leave;
        private System.Windows.Forms.RichTextBox rtbReasonTL;
        private System.Windows.Forms.Button btnResetL;
        private System.Windows.Forms.Button btnSubmitTakeLeave;
        private System.Windows.Forms.DateTimePicker dtpTLToDate;
        private System.Windows.Forms.DateTimePicker dtpTLFromDate;
        private System.Windows.Forms.Label lbReason;
        private System.Windows.Forms.Label lbToDate;
        private System.Windows.Forms.Label lbFromDate;
        private System.Windows.Forms.TabPage Manage_LogOT;
        private System.Windows.Forms.TextBox txtTimeOT;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dtpOT;
        private System.Windows.Forms.Label lbTimeIn;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TabPage Person_info;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbPhonenumber;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnCheckAttendance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
    }
}