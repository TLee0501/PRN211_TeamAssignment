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
            if (txtID.Text == "" || txtID.Name == "" || txtUserName.Text == "" || txtPassword.Text == ""
                || txtRole.Text == "" || txtStatus.Text == "" || txtPhoneNumber.Text == "" 
                || txtEmail.Text == "" || txtBasicSalary.Text == "")
            {
                MessageBox.Show("All fields are required!", "Product Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var emp = new Employee
                {
                    Id = int.Parse(txtID.Text),
                    Name = txtName.Text,
                    Username = txtUserName.Text,
                    Password = txtPassword.Text,
                    RoleName = txtRole.Text,
                    Status = txtStatus.Text,
                    PhoneNumber = int.Parse(txtPhoneNumber.Text),
                    Email = txtEmail.Text,
                };
                var s = new Salary
                { 
                    Id = int.Parse(txtID.Text) + 1,
                    Amount = int.Parse(txtID.Text),
                    EmployeeId = int.Parse(txtID.Text),
                };
                employee.AddEmployee(emp);
                employee.AddSalary(s);
                Close();
            }
        }
    }
}
