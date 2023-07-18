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
    public partial class frmChangePass : Form
    {
        public Employee user;
        IEmployeeRepo employeeRepo = new EmployeeRepo();
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConfirmNewPass.Text != txtNewPass.Text)
                {
                    MessageBox.Show("Password not match! Please try again");
                }
                else if (txtOldPass.Text != user.Password)
                {
                    MessageBox.Show("OldPassword not correct");
                }
                else if (string.IsNullOrWhiteSpace(txtOldPass.Text) || string.IsNullOrWhiteSpace(txtNewPass.Text) || string.IsNullOrWhiteSpace(txtConfirmNewPass.Text))
                {
                    MessageBox.Show("Please Enter All empty Boxes");
                }
                else
                {
                    employeeRepo.UpdatePass(user.Id, txtNewPass.Text);
                    MessageBox.Show("Update Password successfully");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
