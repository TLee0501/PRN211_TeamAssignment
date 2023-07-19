using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Human_resource_manager_system
{
    public partial class frmEmployeeDetails : Form
    {
        IEmployeeRepository employee = new EmployeeRepository();
        public frmEmployeeDetails()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtUserName.Text == "" || txtPassword.Text == ""
                || cboRole.Text == "" || txtPhoneNumber.Text == ""
                || txtEmail.Text == "" || txtBasicSalary.Text == "")
            {
                MessageBox.Show("All fields are required!", "Product Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var emp = new Employee
                {
                    Name = txtName.Text,
                    Username = txtUserName.Text,
                    Password = txtPassword.Text,
                    RoleName = cboRole.SelectedItem.ToString(),
                    Status = "Active",
                    PhoneNumber = int.Parse(txtPhoneNumber.Text),
                    Email = txtEmail.Text,
                };
                employee.AddEmployee(emp);
                var s = new Salary
                {
                    Id = emp.Id,
                    Amount = int.Parse(txtBasicSalary.Text),
                    EmployeeId = emp.Id,
                };
                employee.AddSalary(s);
                Close();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            if (txtName.Text != null || txtUserName.Text != null || txtPassword.Text != null
                || cboRole.Text != null || txtPhoneNumber.Text != null
                || txtEmail.Text != null || txtBasicSalary.Text != null)
            {
                DialogResult d;
                d = MessageBox.Show("Data on the fields!", "HR Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (d == DialogResult.OK)
                {
                    Close();
                }
            }
            else Close();
        }
    }
}
