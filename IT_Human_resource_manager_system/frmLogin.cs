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
    public partial class frmLogin : Form
    {
        IEmployeeRepo employeeRepo = new EmployeeRepo();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Employee employee = employeeRepo.Login(txtUsername.Text, txtPassword.Text);
            if(employee == null)
            {
                MessageBox.Show("Wrong Account!");
            }
            else
            {
                if (employee.RoleName.Equals("Staff"))
                {
                    frmStaff frmStaff = new frmStaff();
                    frmStaff.user = employee;
                    frmStaff.ShowDialog();
                }else if (employee.RoleName.Equals("HRStaff"))
                {
                    frmHR_Staff frmHR_Staff = new frmHR_Staff();
                    frmHR_Staff.user = employee;
                    frmHR_Staff.ShowDialog();
                }
                else
                {
                    frmHR_Manager frmHR_Manager = new frmHR_Manager();
                    frmHR_Manager.user = employee;
                    frmHR_Manager.ShowDialog();
                }
            }

        }
    }
}
