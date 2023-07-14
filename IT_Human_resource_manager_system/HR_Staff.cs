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
    public partial class HR_Staff : Form
    {
        ICandidatesRepo candidatesRepo = new CandidatesRepo();
        ILogOTRepo logOTRepo = new LogOTRepo();
        ITakeleaveRepo takeleaveRepo = new TakeLeaveRepo();
        Overtime Overtime;
        BindingSource source;
        Candidate Candidate;
        TakeLeave TakeLeave;
        public HR_Staff()
        {
            InitializeComponent();
            loadCandidates();
            loadLogOTs();
            loadTakeLeaves();
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
                    Id = Guid.Parse(txtCandidatesID.Text),
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
                //InsertOrUpdate = false,
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
                Text = "Update project",
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
                var temp = new Guid();
                using (var context = new PRN211_IT_HR_Management_SystemContext())
                {
                    var ot = context.Overtimes.SingleOrDefault(a => a.Id == Guid.Parse(txtOTID.Text));
                    temp = (Guid)ot.EmployeeId;
                }
                overtime = new Overtime
                {
                    Id = Guid.Parse(txtOTID.Text),
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

        private void btnOTAdd_Click(object sender, EventArgs e)
        {
            /*ClearTextLogOT();
            frmCandidateDetail frmCandidateDetail = new frmCandidateDetail()
            {
                Text = "Add Candidtae",
                //InsertOrUpdate = false,
                candidatesRepo = candidatesRepo
            };
            if (frmCandidateDetail.ShowDialog() == DialogResult.OK)
            {
                loadLogOTs();
                //Set focus car inserted 
                source.Position = source.Count - 1;
            }
            loadLogOTs();*/
        }

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

                txtTakeLeaveID.DataBindings.Add("Text", source, "Id");
                txtTakeLeaveEmployeeID.DataBindings.Add("Text", source, "EmployeeID");
                txtTakeLeaveName.DataBindings.Add("Text", source, "EmployeeName");
                txtTakeLeaveDescription.DataBindings.Add("Text", source, "Description");
                dtpTakeLeaveFrom.DataBindings.Add("Text", source, "StartDate");
                dtpTakeLeaveTo.DataBindings.Add("Text", source, "EndDate");

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
                    Id = Guid.Parse(txtTakeLeaveID.Text),
                    StartDate = DateTime.Parse(dtpTakeLeaveFrom.Text),
                    EndDate = DateTime.Parse(dtpTakeLeaveTo.Text),
                    Description = txtTakeLeaveDescription.Text,
                    EmployeeName = txtTakeLeaveName.Text,
                    EmployeeId = Guid.Parse(txtTakeLeaveEmployeeID.Text)
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
        private void button10_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var takeLeave = GetTakeLeaveObject();
                    takeleaveRepo.Delete(takeLeave);
                    loadTakeLeaves();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete an TakeLeave");
                }
            }
        }
    }
}
