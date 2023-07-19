using BusinessObjects;
using BusinessObjects.ViewModel;
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
using System.Xml.Linq;

namespace IT_Human_resource_manager_system
{
    public partial class frmHR_Staff : Form
    {
        public Employee user;
        ICandidatesRepo candidatesRepo = new CandidatesRepo();
        IOvertimeRepo logOTRepo = new OvertimeRepo();
        ITakeleaveRepo takeleaveRepo = new TakeLeaveRepo();
        ISalarysRepo salarysRepo = new SalarysRepo();
        IEmployeeRepo employeeRepo = new EmployeeRepo();
        Overtime Overtime;
        BindingSource source;
        Candidate Candidate;
        TakeLeave TakeLeave;
        public frmHR_Staff()
        {
            InitializeComponent();
            loadCandidates();
            loadLogOTs();
            loadTakeLeaves();
            loadEmployeeName();
        }

        private void ClearTextCandidate()
        {
            txtCandidatesID.Text = string.Empty;
            txtCandidatesName.Text = string.Empty;
            txtCandidatesDescription.Text = string.Empty;
        }

        public void loadCandidates()
        {
            var candidates = candidatesRepo.GetCandidates();
            try
            {
                source = new BindingSource();
                source.DataSource = candidates;

                txtCandidatesID.DataBindings.Clear();
                txtCandidatesName.DataBindings.Clear();
                txtCandidatesDescription.DataBindings.Clear();

                txtCandidatesID.DataBindings.Add("Text", source, "ID");
                txtCandidatesName.DataBindings.Add("Text", source, "Name");
                txtCandidatesDescription.DataBindings.Add("Text", source, "Description");

                dgvCandidates.DataSource = null;
                dgvCandidates.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Candidates list");
            }
        }

        private Candidate GetCandidateObject()
        {
            Candidate candidate = null;
            try
            {
                candidate = new Candidate
                {
                    Id = int.Parse(txtCandidatesID.Text),
                    Name = txtCandidatesName.Text,
                    Description = txtCandidatesDescription.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Candidates");
            }
            return candidate;
        }


        /*======================================================================================================================*/

        private void btnCandidatesAdd_Click(object sender, EventArgs e)
        {
            ClearTextCandidate();
            frmCandidateDetail frmCandidateDetail = new frmCandidateDetail()
            {
                Text = "Add Candidtae",
                InsertOrUpdate = false,
                candidatesRepo = candidatesRepo
            };
            if (frmCandidateDetail.ShowDialog() == DialogResult.OK)
            {
                loadCandidates();
                //Set focus car inserted 
                source.Position = source.Count - 1;
            }
            loadCandidates();
        }

        private void dgvCandidates_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCandidateDetail frmCandidateDetail = new frmCandidateDetail()
            {
                Text = "Update Candidtae",
                InsertOrUpdate = true, // Update
                Candidate = GetCandidateObject(),
                candidatesRepo = candidatesRepo
            };
            if (frmCandidateDetail.ShowDialog() == DialogResult.OK)
            {
                loadCandidates();
                //Set focus project updated 
                source.Position = source.Count - 1;
            }
            loadCandidates();
        }

        private void btnCandidatesDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var candidate = GetCandidateObject();
                    candidatesRepo.Delete(candidate);
                    loadCandidates();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete an Candidate");
                }
            }
        }

        /*======================================================================================================================*/
        /*======================================================================================================================*/
        public void loadLogOTs()
        {
            var logOTs = logOTRepo.GetOvertimes();
            var logOTsViewModel = new List<OvertimesViewModel>();
            foreach (var item in logOTs)
            {
                var temp = new OvertimesViewModel();
                temp.Id = item.Id;
                temp.Time = item.Time;
                temp.Date = item.Date;
                using (var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    var ot = context.Employees.Find(item.EmployeeId);

                    temp.EmployeeName = ot.Name;

                }
                logOTsViewModel.Add(temp);
            }
            try
            {
                source = new BindingSource();
                source.DataSource = logOTsViewModel;

                txtOTID.DataBindings.Clear();
                txtOTName.DataBindings.Clear();
                txtOT.DataBindings.Clear();
                txtOTDate.DataBindings.Clear();

                txtOTID.DataBindings.Add("Text", source, "Id");
                txtOTName.DataBindings.Add("Text", source, "EmployeeName");
                txtOT.DataBindings.Add("Text", source, "Time");
                txtOTDate.DataBindings.Add("Text", source, "Date");

                dgvLogOT.DataSource = null;
                dgvLogOT.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load LogOT list");
            }
        }

        private Overtime GetLogOTObject()
        {
            Overtime overtime = null;
            try
            {
                var temp = new int();
                using (var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    var ot = context.Overtimes.Find(int.Parse(txtOTID.Text));
                    temp = (int)ot.EmployeeId;
                }
                overtime = new Overtime
                {
                    Id = int.Parse(txtOTID.Text),
                    Date = DateTime.Parse(txtOTDate.Text),
                    Time = int.Parse(txtOT.Text),
                    EmployeeId = temp
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Candidates");
            }
            return overtime;
        }

        private void ClearTextLogOT()
        {
            txtOTID.Text = string.Empty;
            txtOTName.Text = string.Empty;
            txtOT.Text = string.Empty;
            txtOTDate.Text = string.Empty;
        }

        /*======================================================================================================================*/

        private void btnOTDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var logOT = GetLogOTObject();
                    logOTRepo.Delete(logOT);
                    loadLogOTs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete an LogOT");
                }
            }
        }

        /*======================================================================================================================*/
        /*======================================================================================================================*/

        public void loadTakeLeaves()
        {
            var takeLeaves = takeleaveRepo.GetTakeLeaves();
            try
            {
                source = new BindingSource();
                source.DataSource = takeLeaves;

                txtTakeLeaveID.DataBindings.Clear();
                txtTakeLeaveEmployeeID.DataBindings.Clear();
                txtTakeLeaveName.DataBindings.Clear();
                txtTakeLeaveDescription.DataBindings.Clear();
                dtpTakeLeaveFrom.DataBindings.Clear();
                dtpTakeLeaveTo.DataBindings.Clear();
                txtTakeLeaveAccept.DataBindings.Clear();

                txtTakeLeaveID.DataBindings.Add("Text", source, "Id");
                txtTakeLeaveEmployeeID.DataBindings.Add("Text", source, "EmployeeID");
                txtTakeLeaveName.DataBindings.Add("Text", source, "EmployeeName");
                txtTakeLeaveDescription.DataBindings.Add("Text", source, "Description");
                dtpTakeLeaveFrom.DataBindings.Add("Text", source, "StartDate");
                dtpTakeLeaveTo.DataBindings.Add("Text", source, "EndDate");
                txtTakeLeaveAccept.DataBindings.Add("Text", source, "IsAccept");

                dgvTakeLeave.DataSource = null;
                dgvTakeLeave.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load TakeLeave list");
            }
        }


        private TakeLeaveViewModel GetTakeLeaveObject()
        {
            TakeLeaveViewModel takeLeave = null;
            try
            {
                takeLeave = new TakeLeaveViewModel
                {
                    Id = int.Parse(txtTakeLeaveID.Text),
                    StartDate = DateTime.Parse(dtpTakeLeaveFrom.Text),
                    EndDate = DateTime.Parse(dtpTakeLeaveTo.Text),
                    Description = txtTakeLeaveDescription.Text,
                    EmployeeName = txtTakeLeaveName.Text,
                    EmployeeId = int.Parse(txtTakeLeaveEmployeeID.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Take Leaves");
            }
            return takeLeave;
        }


        private void ClearTextTakeLeave()
        {
            txtTakeLeaveID.Text = string.Empty;
            txtTakeLeaveName.Text = string.Empty;
            txtTakeLeaveDescription.Text = string.Empty;
            dtpTakeLeaveFrom.Text = string.Empty;
            dtpTakeLeaveTo.Text = string.Empty;
        }

        /*======================================================================================================================*/
        /*======================================================================================================================*/
        public void loadEmployeeName()
        {

            var employees = employeeRepo.GetEmployees();
            var listName = new List<ListNameViewModel>();
            foreach (var employee in employees)
            {
                var temp = new ListNameViewModel();
                temp.Name = employee.Name;
                temp.Id = employee.Id;
                listName.Add(temp);
            }
            try
            {
                source = new BindingSource();
                source.DataSource = listName;

                txtCSEmployeeID.DataBindings.Clear();

                txtCSEmployeeID.DataBindings.Add("Text", source, "ID");
                cbCSEmployeeName.DataBindings.Add("Text", source, "Name");

                dgvCalculate.DataSource = null;
                dgvCalculate.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Calculate list");
            }

        }
        private void ClearTextSalary()
        {
            txtCSBasicSalary.Text = string.Empty;
            txtCSSalaryID.Text = string.Empty;
            txtCSBonus.Text = string.Empty;
            txtCSAllowance.Text = string.Empty;
            txtCSOvertimes.Text = string.Empty;
            txtCSTakeLeave.Text = string.Empty;
            txtCSNetSalary.Text = string.Empty;
        }

        /*======================================================================================================================*/
        private void btnCSConfirmTime_Click(object sender, EventArgs e)
        {
            if (cbCSMonth == null && mtxtCSYear == null)
            {
                MessageBox.Show("Please input time!");
            }
            ClearTextSalary();
            try
            {
                var month = int.Parse(cbCSMonth.Text);
                var year = int.Parse(mtxtCSYear.Text);
                var eID = int.Parse(txtCSEmployeeID.Text);
                //CalculateSalaryViewModel calculateSalary = null;
                var calculateSalary = salarysRepo.ConfirmTime(month, year, eID);
                txtCSAllowance.Text = "0";
                txtCSSalaryID.Text = "0";
                if (calculateSalary != null)
                {
                    txtCSSalaryID.Text = calculateSalary.Id.ToString();
                    txtCSBasicSalary.Text = calculateSalary.BasicSalary.ToString();
                    txtCSOvertimes.Text = calculateSalary.OT.ToString();
                    txtCSTakeLeave.Text = calculateSalary.LayDays.ToString();
                    txtCSBonus.Text = calculateSalary.Bonus.ToString();
                    txtCSNetSalary.Text = calculateSalary.NetSalary.ToString();
                    txtCSAllowance.Text = calculateSalary.Allowance.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calculate");
            }
        }

        private void btnCSCalculate_Click(object sender, EventArgs e)
        {
            if (txtCSBasicSalary.Text.Length == 0)
            {
                MessageBox.Show("Please check data again");
            }
            else
            {
                var basicS = int.Parse(txtCSBasicSalary.Text);
                var bonus = int.Parse(txtCSBonus.Text);
                var allowance = int.Parse(txtCSAllowance.Text);

                var netS = basicS + bonus - allowance;
                txtCSNetSalary.Text = netS.ToString();
            }

        }

        private void btnCSSave_Click(object sender, EventArgs e)
        {
            if (txtCSNetSalary.Text.Length == 0)
            {
                MessageBox.Show("Please Calculate before save");
            }
            else
            {
                var basicS = int.Parse(txtCSBasicSalary.Text);
                var bonus = int.Parse(txtCSBonus.Text);
                var allowance = int.Parse(txtCSAllowance.Text);

                var netS = basicS + bonus - allowance;

                if (txtCSSalaryID.Text.Equals("0"))
                {
                    var request = new Payslip()
                    {
                        BasicSalary = int.Parse(txtCSBasicSalary.Text),
                        Allowance = int.Parse(txtCSAllowance.Text),
                        BonusOt = int.Parse(txtCSBonus.Text),
                        NetSalary = int.Parse(netS.ToString()),
                        EmployeeId = int.Parse(txtCSEmployeeID.Text),
                        Month = int.Parse(cbCSMonth.Text),
                        Year = int.Parse(mtxtCSYear.Text)
                    };
                    salarysRepo.SaveSalary(request);
                    MessageBox.Show("Success!");
                }
                else
                {
                    var request = new Payslip()
                    {
                        Id = int.Parse(txtCSSalaryID.Text),
                        BasicSalary = int.Parse(txtCSBasicSalary.Text),
                        Allowance = int.Parse(txtCSAllowance.Text),
                        BonusOt = int.Parse(txtCSBonus.Text),
                        NetSalary = int.Parse(netS.ToString()),
                        EmployeeId = int.Parse(txtCSEmployeeID.Text),
                        Month = int.Parse(cbCSMonth.Text),
                        Year = int.Parse(mtxtCSYear.Text)
                    };
                    salarysRepo.UpdateSalary(request);
                    MessageBox.Show("Success!");
                }
            }

        }
        /*======================================================================================================================*/
        /*======================================================================================================================*/

        private void btnPayrollLoad_Click(object sender, EventArgs e)
        {
            var payrolls = salarysRepo.GetPayslips();
            try
            {
                source = new BindingSource();
                source.DataSource = payrolls;

                txtPayslipEmployeeID.DataBindings.Clear();
                txtPayslipEmployeeName.DataBindings.Clear();
                txtPayslipBasicSalary.DataBindings.Clear();
                txtPayslipNetSalary.DataBindings.Clear();
                txtPayslipMonth.DataBindings.Clear();
                txtPayslipYear.DataBindings.Clear();

                txtPayslipEmployeeID.DataBindings.Add("Text", source, "Id");
                txtPayslipEmployeeName.DataBindings.Add("Text", source, "Name");
                txtPayslipBasicSalary.DataBindings.Add("Text", source, "BasicSalary");
                txtPayslipNetSalary.DataBindings.Add("Text", source, "NetSalary");
                txtPayslipMonth.DataBindings.Add("Text", source, "Month");
                txtPayslipYear.DataBindings.Add("Text", source, "Year");

                dgvPayrolls.DataSource = null;
                dgvPayrolls.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Calculate list");
            }
        }

        private void btnTakeLeaveAccept_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(txtTakeLeaveAccept.Text) == true)
            {
                MessageBox.Show("Already Accepted");
            }
            else
            {
                takeleaveRepo.Accept(int.Parse(txtTakeLeaveID.Text));
            }
            loadTakeLeaves();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(txtTakeLeaveAccept.Text) == false)
            {
                MessageBox.Show("Already Rejected");
            }
            else
            {
                takeleaveRepo.Reject(int.Parse(txtTakeLeaveID.Text));
            }
            loadTakeLeaves();

        }
    }
}