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
    public partial class frmStaff : Form
    {
        public Employee user;
        IEmployeeRepo employeeRepo = new EmployeeRepo();
        IOvertimeRepo overtime = new OvertimeRepo();
        ITakeleaveRepo takeLeaveRepo = new TakeLeaveRepo();
        IAttendanceRepo attendanceRepo = new AttendanceRepo();
        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            LoadPerInfo();
        }

        public void LoadPerInfo()
        {
            try
            {
                var Employee = employeeRepo.GetEmployeeById(user.Id);
                txtName.Text = Employee.Name;
                txtPhonenumber.Text = Employee.PhoneNumber.ToString();
                TxtEmail.Text = Employee.Email;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePass frmChangePass = new frmChangePass();
            frmChangePass.user = user;
            frmChangePass.ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtTimeOT.Text == "")
            {
                MessageBox.Show("Enter all box before submit");
            }
            else
            {
                DateTime DateOT = dtpOT.Value;

                if (int.TryParse(txtTimeOT.Text, out int time))
                {
                    using (var context = new PRN211_IT_HR_Management_SystemContext())
                    {

                        bool overtimeExists = context.Overtimes.Any(o => o.EmployeeId == user.Id && o.Date == DateOT);

                        if (overtimeExists)
                        {
                            MessageBox.Show("You already submit your Overtime");
                        }
                        else
                        {
                            var o = new Overtime
                            {
                                Date = DateOT,
                                Time = time,
                                EmployeeId = user.Id
                            };
                            overtime.addOverTime(o);
                            MessageBox.Show("Submit OT success");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input for Time. Please enter a valid number.");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTimeOT.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPhonenumber.Text, out int phonenumber))
            {
                var info = new Employee
                {
                    Id = user.Id,
                    Username = user.Username,
                    Password = user.Password,
                    Name = txtName.Text,
                    RoleName = user.RoleName,
                    Status = user.Status,
                    Email = TxtEmail.Text,
                    PhoneNumber = phonenumber,
                };
                employeeRepo.UpdateEmployee(info);
                MessageBox.Show("Update Personal Information success");
            }

        }

        private void btnSubmitTakeLeave_Click(object sender, EventArgs e)
        {
            DateTime fromdate = dtpTLFromDate.Value;
            DateTime todate = dtpTLToDate.Value;
            var tl = new TakeLeave
            {
                EmployeeId = user.Id,
                StartDate = fromdate,
                EndDate = todate,
                IsAccept = false,
                Description = rtbReasonTL.Text,
            };
            takeLeaveRepo.AddTakeLeave(tl);
            MessageBox.Show("Submit takeleave form success");
        }

        private void btnCheckAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateTime = DateTime.Now;
                int currentHour = dateTime.Hour;
                Boolean isMorning = currentHour >= 7 && currentHour <= 8;
                Boolean checkAtten = attendanceRepo.CheckAttendanceToDay(user.Id);
                if (checkAtten)
                {
                    MessageBox.Show("Already Check Attendance for today");
                }
                else
                {


                    var Atten = new Attendance
                    {
                        EmployeeId = user.Id,
                        IsAttend = isMorning,
                        Date = DateTime.Now,
                    };
                    attendanceRepo.addAttendance(Atten);
                    MessageBox.Show("Check Attendance success");

                    if (!isMorning)
                    {
                        MessageBox.Show("You are late attendance change to false");
                    }
                    else
                    {
                        MessageBox.Show("You go to work on time");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                if (ex.InnerException != null)
                {
                    MessageBox.Show("Inner Exception: " + ex.InnerException.Message);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetL_Click(object sender, EventArgs e)
        {
            rtbReasonTL.Clear();
        }
    }
}
