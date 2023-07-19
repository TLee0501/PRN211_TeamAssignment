using BusinessObjects;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IT_Human_resource_manager_system
{
    public partial class frmHR_Manager : Form
    {
        public Employee user;
        IEmployeeRepository employee = new EmployeeRepository();
        IPayslipRepository payslip = new PayslipRepository();
        ITakeLeaveRepository TakeLeave = new TakeLeaveRepository();
        IOverTimeRepository overTime = new OverTimeRepository();
        public frmHR_Manager()
        {
            InitializeComponent();
        }
        public void LoadOverTimeList()
        {
            var list = overTime.GetOverTimes();
            BindingSource source = new BindingSource();
            source.DataSource = list;

            txtOverTimeID.DataBindings.Clear();
            txtEmployeeID_1.DataBindings.Clear();
            txtName_1.DataBindings.Clear();
            txtDate_1.DataBindings.Clear();
            txtTime_1.DataBindings.Clear();

            txtOverTimeID.DataBindings.Add("Text", source, "ID");
            txtEmployeeID_1.DataBindings.Add("Text", source, "EmployeeID");
            txtName_1.DataBindings.Add("Text", source, "Name");
            txtDate_1.DataBindings.Add("Text", source, "Date");
            txtTime_1.DataBindings.Add("Text", source, "Time");

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = list;
        }
        public void LoadPayslipList()
        {
            try
            {
                var list = payslip.GetPayslips();
                BindingSource source = new BindingSource();
                source.DataSource = list;

                txtName_3.DataBindings.Clear();
                txtAllowances.DataBindings.Clear();
                txtBasicSalary.DataBindings.Clear();
                txtBonusOT.DataBindings.Clear();
                txtNetSalary.DataBindings.Clear();
                txtMonth.DataBindings.Clear();
                txtYear.DataBindings.Clear();

                txtName_3.DataBindings.Add("Text", source, "Employee.Name");
                txtAllowances.DataBindings.Add("Text", source, "Allowance");
                txtBasicSalary.DataBindings.Add("Text", source, "BasicSalary");
                txtBonusOT.DataBindings.Add("Text", source, "BonusOT");
                txtNetSalary.DataBindings.Add("Text", source, "NetSalary");
                txtMonth.DataBindings.Add("Text", source, "Month");
                txtYear.DataBindings.Add("Text", source, "Year");

                dgvPayslip.DataSource = null;
                dgvPayslip.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Payslip list");
            }
        }
        public void LoadTakeLeaveList()
        {
            try
            {
                var list = TakeLeave.GetTakeLeaves();
                BindingSource source = new BindingSource();
                source.DataSource = list;

                txtTakeLeaveID.DataBindings.Clear();
                txtName_2.DataBindings.Clear();
                rtxtReason.DataBindings.Clear();

                txtTakeLeaveID.DataBindings.Add("Text", source, "Id");
                txtName_2.DataBindings.Add("Text", source, "Employee.Name");
                dtpFromDate.DataBindings.Add("Text", source, "StartDate");
                dtpToDate.DataBindings.Add("Text", source, "EndDate");
                rtxtReason.DataBindings.Add("Text", source, "Description");

                dgvTakeLeave.DataSource = null;
                dgvTakeLeave.DataSource = list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error loading Take Leave List!");
            }
        }
        public void LoadManageUserRoleList()
        {
            try
            {
                var list = employee.GetEmployees();
                BindingSource source = new BindingSource();
                source.DataSource = list;

                txtEmployeeID.DataBindings.Clear();
                txtName_4.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                cboRole.DataBindings.Clear();
                txtSalary.DataBindings.Clear();

                txtEmployeeID.DataBindings.Add("Text", source, "Id");
                txtName_4.DataBindings.Add("Text", source, "Name");
                txtStatus.DataBindings.Add("Text", source, "Status");
                cboRole.DataBindings.Add("Text", source, "RoleName");
                txtSalary.DataBindings.Add("Text", source, "Amount");

                dgvManageUserRole.DataSource = null;
                dgvManageUserRole.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loaing Personcal Contract list");
            }
        }
        private void HR_Manager_Load(object sender, EventArgs e)
        {
            LoadPayslipList();
            LoadManageUserRoleList();
            LoadTakeLeaveList();
            LoadOverTimeList();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmEmployeeDetails frmEmployeeDetails = new frmEmployeeDetails();
            frmEmployeeDetails.ShowDialog();
            LoadManageUserRoleList();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Confirm to change Status ?", "HR Management",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (d == DialogResult.OK)
            {
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (cboRole.Text == "" || txtSalary.Text == "")
            {
                MessageBox.Show("All fields are required!", "Product Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                employee.setRole(cboRole.SelectedItem.ToString(), int.Parse(txtEmployeeID.Text));
                employee.setSalary(int.Parse(txtSalary.Text), int.Parse(txtEmployeeID.Text));
                LoadManageUserRoleList();
            }
            
        }
    }
}
