namespace IT_Human_resource_manager_system
{
    partial class HR_Manager
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
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage3 = new System.Windows.Forms.TabPage();
            label18 = new System.Windows.Forms.Label();
            txtOverTimeID = new System.Windows.Forms.TextBox();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            txtTime_1 = new System.Windows.Forms.TextBox();
            txtDate_1 = new System.Windows.Forms.TextBox();
            txtName_1 = new System.Windows.Forms.TextBox();
            txtEmployeeID_1 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            lbDescription = new System.Windows.Forms.Label();
            lbTimeOut = new System.Windows.Forms.Label();
            tabPage4 = new System.Windows.Forms.TabPage();
            txtTakeLeaveID = new System.Windows.Forms.TextBox();
            label19 = new System.Windows.Forms.Label();
            button10 = new System.Windows.Forms.Button();
            button11 = new System.Windows.Forms.Button();
            button12 = new System.Windows.Forms.Button();
            txtName_2 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            dgvTakeLeave = new System.Windows.Forms.DataGridView();
            rtxtReason = new System.Windows.Forms.RichTextBox();
            dtpToDate = new System.Windows.Forms.DateTimePicker();
            dtpFromDate = new System.Windows.Forms.DateTimePicker();
            lbReason = new System.Windows.Forms.Label();
            lbToDate = new System.Windows.Forms.Label();
            lbFromDate = new System.Windows.Forms.Label();
            tabPage5 = new System.Windows.Forms.TabPage();
            label1 = new System.Windows.Forms.Label();
            txtYear = new System.Windows.Forms.TextBox();
            btnDalete_3 = new System.Windows.Forms.Button();
            btnUpdate_3 = new System.Windows.Forms.Button();
            btnAdd_3 = new System.Windows.Forms.Button();
            dgvPayslip = new System.Windows.Forms.DataGridView();
            txtMonth = new System.Windows.Forms.TextBox();
            txtNetSalary = new System.Windows.Forms.TextBox();
            txtBonusOT = new System.Windows.Forms.TextBox();
            txtBasicSalary = new System.Windows.Forms.TextBox();
            txtAllowances = new System.Windows.Forms.TextBox();
            txtName_3 = new System.Windows.Forms.TextBox();
            lbNetSalary = new System.Windows.Forms.Label();
            lbBasicSalary = new System.Windows.Forms.Label();
            lbAllowances = new System.Windows.Forms.Label();
            lxDeductions = new System.Windows.Forms.Label();
            lbPayPeriod = new System.Windows.Forms.Label();
            lbEName = new System.Windows.Forms.Label();
            tabPage7 = new System.Windows.Forms.TabPage();
            txtEmployeeID = new System.Windows.Forms.TextBox();
            label20 = new System.Windows.Forms.Label();
            cboStatus = new System.Windows.Forms.ComboBox();
            cboRole = new System.Windows.Forms.ComboBox();
            label12 = new System.Windows.Forms.Label();
            button16 = new System.Windows.Forms.Button();
            button17 = new System.Windows.Forms.Button();
            button18 = new System.Windows.Forms.Button();
            dgvManageUserRole = new System.Windows.Forms.DataGridView();
            txtName_4 = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            lbTimeIn = new System.Windows.Forms.Label();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTakeLeave).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayslip).BeginInit();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManageUserRole).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Location = new System.Drawing.Point(15, 132);
            tabControl1.Margin = new System.Windows.Forms.Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1342, 518);
            tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(txtOverTimeID);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Controls.Add(txtTime_1);
            tabPage3.Controls.Add(txtDate_1);
            tabPage3.Controls.Add(txtName_1);
            tabPage3.Controls.Add(txtEmployeeID_1);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(lbDescription);
            tabPage3.Controls.Add(lbTimeOut);
            tabPage3.Controls.Add(lbTimeIn);
            tabPage3.Location = new System.Drawing.Point(4, 34);
            tabPage3.Margin = new System.Windows.Forms.Padding(4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(4);
            tabPage3.Size = new System.Drawing.Size(1334, 480);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Manage Log OT";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(45, 11);
            label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(30, 25);
            label18.TabIndex = 43;
            label18.Text = "ID";
            // 
            // txtOverTimeID
            // 
            txtOverTimeID.Location = new System.Drawing.Point(41, 40);
            txtOverTimeID.Margin = new System.Windows.Forms.Padding(4);
            txtOverTimeID.Name = "txtOverTimeID";
            txtOverTimeID.Size = new System.Drawing.Size(215, 31);
            txtOverTimeID.TabIndex = 42;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(1025, 416);
            button4.Margin = new System.Windows.Forms.Padding(4);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(118, 36);
            button4.TabIndex = 39;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(745, 416);
            button5.Margin = new System.Windows.Forms.Padding(4);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(118, 36);
            button5.TabIndex = 38;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(461, 416);
            button6.Margin = new System.Windows.Forms.Padding(4);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(118, 36);
            button6.TabIndex = 37;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new System.Drawing.Point(308, 35);
            dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new System.Drawing.Size(986, 360);
            dataGridView2.TabIndex = 36;
            // 
            // txtTime_1
            // 
            txtTime_1.Location = new System.Drawing.Point(41, 301);
            txtTime_1.Margin = new System.Windows.Forms.Padding(4);
            txtTime_1.Name = "txtTime_1";
            txtTime_1.Size = new System.Drawing.Size(215, 31);
            txtTime_1.TabIndex = 35;
            // 
            // txtDate_1
            // 
            txtDate_1.Location = new System.Drawing.Point(41, 235);
            txtDate_1.Margin = new System.Windows.Forms.Padding(4);
            txtDate_1.Name = "txtDate_1";
            txtDate_1.Size = new System.Drawing.Size(215, 31);
            txtDate_1.TabIndex = 34;
            // 
            // txtName_1
            // 
            txtName_1.Location = new System.Drawing.Point(41, 169);
            txtName_1.Margin = new System.Windows.Forms.Padding(4);
            txtName_1.Name = "txtName_1";
            txtName_1.Size = new System.Drawing.Size(215, 31);
            txtName_1.TabIndex = 33;
            // 
            // txtEmployeeID_1
            // 
            txtEmployeeID_1.Location = new System.Drawing.Point(41, 102);
            txtEmployeeID_1.Margin = new System.Windows.Forms.Padding(4);
            txtEmployeeID_1.Name = "txtEmployeeID_1";
            txtEmployeeID_1.Size = new System.Drawing.Size(215, 31);
            txtEmployeeID_1.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(45, 75);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(108, 25);
            label3.TabIndex = 31;
            label3.Text = "EmployeeID";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new System.Drawing.Point(45, 137);
            lbDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new System.Drawing.Size(59, 25);
            lbDescription.TabIndex = 30;
            lbDescription.Text = "Name";
            // 
            // lbTimeOut
            // 
            lbTimeOut.AutoSize = true;
            lbTimeOut.Location = new System.Drawing.Point(45, 204);
            lbTimeOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbTimeOut.Name = "lbTimeOut";
            lbTimeOut.Size = new System.Drawing.Size(49, 25);
            lbTimeOut.TabIndex = 29;
            lbTimeOut.Text = "Date";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(txtTakeLeaveID);
            tabPage4.Controls.Add(label19);
            tabPage4.Controls.Add(button10);
            tabPage4.Controls.Add(button11);
            tabPage4.Controls.Add(button12);
            tabPage4.Controls.Add(txtName_2);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(dgvTakeLeave);
            tabPage4.Controls.Add(rtxtReason);
            tabPage4.Controls.Add(dtpToDate);
            tabPage4.Controls.Add(dtpFromDate);
            tabPage4.Controls.Add(lbReason);
            tabPage4.Controls.Add(lbToDate);
            tabPage4.Controls.Add(lbFromDate);
            tabPage4.Location = new System.Drawing.Point(4, 34);
            tabPage4.Margin = new System.Windows.Forms.Padding(4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(4);
            tabPage4.Size = new System.Drawing.Size(1334, 480);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Take Leave";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtTakeLeaveID
            // 
            txtTakeLeaveID.Location = new System.Drawing.Point(141, 25);
            txtTakeLeaveID.Margin = new System.Windows.Forms.Padding(4);
            txtTakeLeaveID.Name = "txtTakeLeaveID";
            txtTakeLeaveID.Size = new System.Drawing.Size(312, 31);
            txtTakeLeaveID.TabIndex = 48;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(28, 28);
            label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(30, 25);
            label19.TabIndex = 47;
            label19.Text = "ID";
            // 
            // button10
            // 
            button10.Location = new System.Drawing.Point(1128, 400);
            button10.Margin = new System.Windows.Forms.Padding(4);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(118, 36);
            button10.TabIndex = 46;
            button10.Text = "Delete";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new System.Drawing.Point(848, 400);
            button11.Margin = new System.Windows.Forms.Padding(4);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(118, 36);
            button11.TabIndex = 45;
            button11.Text = "Update";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new System.Drawing.Point(564, 400);
            button12.Margin = new System.Windows.Forms.Padding(4);
            button12.Name = "button12";
            button12.Size = new System.Drawing.Size(118, 36);
            button12.TabIndex = 44;
            button12.Text = "Add";
            button12.UseVisualStyleBackColor = true;
            // 
            // txtName_2
            // 
            txtName_2.Location = new System.Drawing.Point(141, 66);
            txtName_2.Margin = new System.Windows.Forms.Padding(4);
            txtName_2.Name = "txtName_2";
            txtName_2.Size = new System.Drawing.Size(312, 31);
            txtName_2.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(28, 74);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(59, 25);
            label5.TabIndex = 38;
            label5.Text = "Name";
            // 
            // dgvTakeLeave
            // 
            dgvTakeLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTakeLeave.Location = new System.Drawing.Point(494, 34);
            dgvTakeLeave.Margin = new System.Windows.Forms.Padding(4);
            dgvTakeLeave.Name = "dgvTakeLeave";
            dgvTakeLeave.RowHeadersWidth = 51;
            dgvTakeLeave.RowTemplate.Height = 29;
            dgvTakeLeave.Size = new System.Drawing.Size(820, 338);
            dgvTakeLeave.TabIndex = 37;
            // 
            // rtxtReason
            // 
            rtxtReason.Location = new System.Drawing.Point(141, 235);
            rtxtReason.Margin = new System.Windows.Forms.Padding(4);
            rtxtReason.Name = "rtxtReason";
            rtxtReason.Size = new System.Drawing.Size(312, 149);
            rtxtReason.TabIndex = 17;
            rtxtReason.Text = "";
            // 
            // dtpToDate
            // 
            dtpToDate.Location = new System.Drawing.Point(141, 170);
            dtpToDate.Margin = new System.Windows.Forms.Padding(4);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new System.Drawing.Size(312, 31);
            dtpToDate.TabIndex = 16;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new System.Drawing.Point(141, 116);
            dtpFromDate.Margin = new System.Windows.Forms.Padding(4);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new System.Drawing.Size(312, 31);
            dtpFromDate.TabIndex = 15;
            // 
            // lbReason
            // 
            lbReason.AutoSize = true;
            lbReason.Location = new System.Drawing.Point(28, 242);
            lbReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbReason.Name = "lbReason";
            lbReason.Size = new System.Drawing.Size(69, 25);
            lbReason.TabIndex = 14;
            lbReason.Text = "Reason";
            // 
            // lbToDate
            // 
            lbToDate.AutoSize = true;
            lbToDate.Location = new System.Drawing.Point(28, 182);
            lbToDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbToDate.Name = "lbToDate";
            lbToDate.Size = new System.Drawing.Size(67, 25);
            lbToDate.TabIndex = 13;
            lbToDate.Text = "ToDate";
            // 
            // lbFromDate
            // 
            lbFromDate.AutoSize = true;
            lbFromDate.Location = new System.Drawing.Point(28, 126);
            lbFromDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbFromDate.Name = "lbFromDate";
            lbFromDate.Size = new System.Drawing.Size(91, 25);
            lbFromDate.TabIndex = 12;
            lbFromDate.Text = "FromDate";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label1);
            tabPage5.Controls.Add(txtYear);
            tabPage5.Controls.Add(btnDalete_3);
            tabPage5.Controls.Add(btnUpdate_3);
            tabPage5.Controls.Add(btnAdd_3);
            tabPage5.Controls.Add(dgvPayslip);
            tabPage5.Controls.Add(txtMonth);
            tabPage5.Controls.Add(txtNetSalary);
            tabPage5.Controls.Add(txtBonusOT);
            tabPage5.Controls.Add(txtBasicSalary);
            tabPage5.Controls.Add(txtAllowances);
            tabPage5.Controls.Add(txtName_3);
            tabPage5.Controls.Add(lbNetSalary);
            tabPage5.Controls.Add(lbBasicSalary);
            tabPage5.Controls.Add(lbAllowances);
            tabPage5.Controls.Add(lxDeductions);
            tabPage5.Controls.Add(lbPayPeriod);
            tabPage5.Controls.Add(lbEName);
            tabPage5.Location = new System.Drawing.Point(4, 34);
            tabPage5.Margin = new System.Windows.Forms.Padding(4);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new System.Windows.Forms.Padding(4);
            tabPage5.Size = new System.Drawing.Size(1334, 480);
            tabPage5.TabIndex = 5;
            tabPage5.Text = "Payslip/Payroll";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(30, 398);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 25);
            label1.TabIndex = 63;
            label1.Text = "Year";
            // 
            // txtYear
            // 
            txtYear.Location = new System.Drawing.Point(30, 427);
            txtYear.Margin = new System.Windows.Forms.Padding(4);
            txtYear.Name = "txtYear";
            txtYear.Size = new System.Drawing.Size(263, 31);
            txtYear.TabIndex = 62;
            // 
            // btnDalete_3
            // 
            btnDalete_3.Location = new System.Drawing.Point(1039, 406);
            btnDalete_3.Margin = new System.Windows.Forms.Padding(4);
            btnDalete_3.Name = "btnDalete_3";
            btnDalete_3.Size = new System.Drawing.Size(118, 36);
            btnDalete_3.TabIndex = 61;
            btnDalete_3.Text = "Delete";
            btnDalete_3.UseVisualStyleBackColor = true;
            // 
            // btnUpdate_3
            // 
            btnUpdate_3.Location = new System.Drawing.Point(759, 406);
            btnUpdate_3.Margin = new System.Windows.Forms.Padding(4);
            btnUpdate_3.Name = "btnUpdate_3";
            btnUpdate_3.Size = new System.Drawing.Size(118, 36);
            btnUpdate_3.TabIndex = 60;
            btnUpdate_3.Text = "Update";
            btnUpdate_3.UseVisualStyleBackColor = true;
            // 
            // btnAdd_3
            // 
            btnAdd_3.Location = new System.Drawing.Point(475, 406);
            btnAdd_3.Margin = new System.Windows.Forms.Padding(4);
            btnAdd_3.Name = "btnAdd_3";
            btnAdd_3.Size = new System.Drawing.Size(118, 36);
            btnAdd_3.TabIndex = 59;
            btnAdd_3.Text = "Add";
            btnAdd_3.UseVisualStyleBackColor = true;
            // 
            // dgvPayslip
            // 
            dgvPayslip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayslip.Location = new System.Drawing.Point(321, 25);
            dgvPayslip.Margin = new System.Windows.Forms.Padding(4);
            dgvPayslip.Name = "dgvPayslip";
            dgvPayslip.RowHeadersWidth = 51;
            dgvPayslip.RowTemplate.Height = 29;
            dgvPayslip.Size = new System.Drawing.Size(986, 360);
            dgvPayslip.TabIndex = 58;
            // 
            // txtMonth
            // 
            txtMonth.Location = new System.Drawing.Point(27, 365);
            txtMonth.Margin = new System.Windows.Forms.Padding(4);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new System.Drawing.Size(263, 31);
            txtMonth.TabIndex = 57;
            // 
            // txtNetSalary
            // 
            txtNetSalary.Location = new System.Drawing.Point(26, 301);
            txtNetSalary.Margin = new System.Windows.Forms.Padding(4);
            txtNetSalary.Name = "txtNetSalary";
            txtNetSalary.Size = new System.Drawing.Size(263, 31);
            txtNetSalary.TabIndex = 55;
            // 
            // txtBonusOT
            // 
            txtBonusOT.Location = new System.Drawing.Point(26, 235);
            txtBonusOT.Margin = new System.Windows.Forms.Padding(4);
            txtBonusOT.Name = "txtBonusOT";
            txtBonusOT.Size = new System.Drawing.Size(264, 31);
            txtBonusOT.TabIndex = 54;
            // 
            // txtBasicSalary
            // 
            txtBasicSalary.Location = new System.Drawing.Point(26, 169);
            txtBasicSalary.Margin = new System.Windows.Forms.Padding(4);
            txtBasicSalary.Name = "txtBasicSalary";
            txtBasicSalary.Size = new System.Drawing.Size(264, 31);
            txtBasicSalary.TabIndex = 53;
            // 
            // txtAllowances
            // 
            txtAllowances.Location = new System.Drawing.Point(26, 102);
            txtAllowances.Margin = new System.Windows.Forms.Padding(4);
            txtAllowances.Name = "txtAllowances";
            txtAllowances.Size = new System.Drawing.Size(264, 31);
            txtAllowances.TabIndex = 52;
            // 
            // txtName_3
            // 
            txtName_3.Location = new System.Drawing.Point(26, 36);
            txtName_3.Margin = new System.Windows.Forms.Padding(4);
            txtName_3.Name = "txtName_3";
            txtName_3.Size = new System.Drawing.Size(263, 31);
            txtName_3.TabIndex = 51;
            // 
            // lbNetSalary
            // 
            lbNetSalary.AutoSize = true;
            lbNetSalary.Location = new System.Drawing.Point(30, 270);
            lbNetSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbNetSalary.Name = "lbNetSalary";
            lbNetSalary.Size = new System.Drawing.Size(92, 25);
            lbNetSalary.TabIndex = 49;
            lbNetSalary.Text = "Net Salary";
            // 
            // lbBasicSalary
            // 
            lbBasicSalary.AutoSize = true;
            lbBasicSalary.Location = new System.Drawing.Point(30, 140);
            lbBasicSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbBasicSalary.Name = "lbBasicSalary";
            lbBasicSalary.Size = new System.Drawing.Size(103, 25);
            lbBasicSalary.TabIndex = 48;
            lbBasicSalary.Text = "Basic Salary";
            // 
            // lbAllowances
            // 
            lbAllowances.AutoSize = true;
            lbAllowances.Location = new System.Drawing.Point(26, 71);
            lbAllowances.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbAllowances.Name = "lbAllowances";
            lbAllowances.Size = new System.Drawing.Size(100, 25);
            lbAllowances.TabIndex = 47;
            lbAllowances.Text = "Allowances";
            // 
            // lxDeductions
            // 
            lxDeductions.AutoSize = true;
            lxDeductions.Location = new System.Drawing.Point(30, 336);
            lxDeductions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lxDeductions.Name = "lxDeductions";
            lxDeductions.Size = new System.Drawing.Size(65, 25);
            lxDeductions.TabIndex = 46;
            lxDeductions.Text = "Month";
            // 
            // lbPayPeriod
            // 
            lbPayPeriod.AutoSize = true;
            lbPayPeriod.Location = new System.Drawing.Point(30, 206);
            lbPayPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbPayPeriod.Name = "lbPayPeriod";
            lbPayPeriod.Size = new System.Drawing.Size(88, 25);
            lbPayPeriod.TabIndex = 45;
            lbPayPeriod.Text = "Bonus OT";
            // 
            // lbEName
            // 
            lbEName.AutoSize = true;
            lbEName.Location = new System.Drawing.Point(30, 11);
            lbEName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbEName.Name = "lbEName";
            lbEName.Size = new System.Drawing.Size(59, 25);
            lbEName.TabIndex = 44;
            lbEName.Text = "Name";
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(txtEmployeeID);
            tabPage7.Controls.Add(label20);
            tabPage7.Controls.Add(cboStatus);
            tabPage7.Controls.Add(cboRole);
            tabPage7.Controls.Add(label12);
            tabPage7.Controls.Add(button16);
            tabPage7.Controls.Add(button17);
            tabPage7.Controls.Add(button18);
            tabPage7.Controls.Add(dgvManageUserRole);
            tabPage7.Controls.Add(txtName_4);
            tabPage7.Controls.Add(label10);
            tabPage7.Controls.Add(label11);
            tabPage7.Location = new System.Drawing.Point(4, 34);
            tabPage7.Margin = new System.Windows.Forms.Padding(4);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new System.Windows.Forms.Padding(4);
            tabPage7.Size = new System.Drawing.Size(1334, 480);
            tabPage7.TabIndex = 7;
            tabPage7.Text = "Manage User/Role";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new System.Drawing.Point(34, 48);
            txtEmployeeID.Margin = new System.Windows.Forms.Padding(4);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new System.Drawing.Size(256, 31);
            txtEmployeeID.TabIndex = 20;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(38, 22);
            label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(30, 25);
            label20.TabIndex = 19;
            label20.Text = "ID";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new System.Drawing.Point(34, 188);
            cboStatus.Margin = new System.Windows.Forms.Padding(4);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new System.Drawing.Size(253, 33);
            cboStatus.TabIndex = 18;
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Location = new System.Drawing.Point(34, 269);
            cboRole.Margin = new System.Windows.Forms.Padding(4);
            cboRole.Name = "cboRole";
            cboRole.Size = new System.Drawing.Size(253, 33);
            cboRole.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(34, 240);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(46, 25);
            label12.TabIndex = 16;
            label12.Text = "Role";
            // 
            // button16
            // 
            button16.Location = new System.Drawing.Point(1038, 414);
            button16.Margin = new System.Windows.Forms.Padding(4);
            button16.Name = "button16";
            button16.Size = new System.Drawing.Size(118, 36);
            button16.TabIndex = 15;
            button16.Text = "Delete";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Location = new System.Drawing.Point(758, 414);
            button17.Margin = new System.Windows.Forms.Padding(4);
            button17.Name = "button17";
            button17.Size = new System.Drawing.Size(118, 36);
            button17.TabIndex = 14;
            button17.Text = "Update";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new System.Drawing.Point(474, 414);
            button18.Margin = new System.Windows.Forms.Padding(4);
            button18.Name = "button18";
            button18.Size = new System.Drawing.Size(118, 36);
            button18.TabIndex = 13;
            button18.Text = "Add";
            button18.UseVisualStyleBackColor = true;
            // 
            // dgvManageUserRole
            // 
            dgvManageUserRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManageUserRole.Location = new System.Drawing.Point(320, 32);
            dgvManageUserRole.Margin = new System.Windows.Forms.Padding(4);
            dgvManageUserRole.Name = "dgvManageUserRole";
            dgvManageUserRole.RowHeadersWidth = 51;
            dgvManageUserRole.RowTemplate.Height = 29;
            dgvManageUserRole.Size = new System.Drawing.Size(986, 360);
            dgvManageUserRole.TabIndex = 12;
            // 
            // txtName_4
            // 
            txtName_4.Location = new System.Drawing.Point(34, 110);
            txtName_4.Margin = new System.Windows.Forms.Padding(4);
            txtName_4.Name = "txtName_4";
            txtName_4.Size = new System.Drawing.Size(256, 31);
            txtName_4.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(34, 159);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(60, 25);
            label10.TabIndex = 9;
            label10.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(38, 85);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(59, 25);
            label11.TabIndex = 8;
            label11.Text = "Name";
            // 
            // lbTimeIn
            // 
            lbTimeIn.AutoSize = true;
            lbTimeIn.Location = new System.Drawing.Point(45, 272);
            lbTimeIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbTimeIn.Name = "lbTimeIn";
            lbTimeIn.Size = new System.Drawing.Size(50, 25);
            lbTimeIn.TabIndex = 28;
            lbTimeIn.Text = "Time";
            // 
            // HR_Manager
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1372, 665);
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "HR_Manager";
            Text = "HR_Manager";
            Load += HR_Manager_Load;
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTakeLeave).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayslip).EndInit();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManageUserRole).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtOverTimeID;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtTime_1;
        private System.Windows.Forms.TextBox txtDate_1;
        private System.Windows.Forms.TextBox txtName_1;
        private System.Windows.Forms.TextBox txtEmployeeID_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbTimeOut;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtTakeLeaveID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox txtName_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTakeLeave;
        private System.Windows.Forms.RichTextBox rtxtReason;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lbReason;
        private System.Windows.Forms.Label lbToDate;
        private System.Windows.Forms.Label lbFromDate;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnDalete_3;
        private System.Windows.Forms.Button btnUpdate_3;
        private System.Windows.Forms.Button btnAdd_3;
        private System.Windows.Forms.DataGridView dgvPayslip;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtNetSalary;
        private System.Windows.Forms.TextBox txtBonusOT;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.TextBox txtAllowances;
        private System.Windows.Forms.TextBox txtName_3;
        private System.Windows.Forms.Label lbNetSalary;
        private System.Windows.Forms.Label lbBasicSalary;
        private System.Windows.Forms.Label lbAllowances;
        private System.Windows.Forms.Label lxDeductions;
        private System.Windows.Forms.Label lbPayPeriod;
        private System.Windows.Forms.Label lbEName;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.DataGridView dgvManageUserRole;
        private System.Windows.Forms.TextBox txtName_4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lbTimeIn;
    }
}