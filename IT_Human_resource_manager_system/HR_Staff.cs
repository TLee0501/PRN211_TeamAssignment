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
using System.Xml.Linq;

namespace IT_Human_resource_manager_system
{
    public partial class HR_Staff : Form
    {
        ICandidatesRepo candidatesRepo = new CandidatesRepo();
        BindingSource source;
        Candidate Candidate;
        public HR_Staff()
        {
            InitializeComponent();
            loadCandidates();
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

        private Overtime GetLogOTObject()
        {
            Overtime overtime = null;
            try
            {
                overtime = new Overtime
                {
                    Id = Guid.Parse(txtOTID.Text),
                    Date = DateTime.Parse(txtOTDate.Text),
                    Time = int.Parse(txtOT.Text),
                    //Employee = Guid.Parse(txt.Text),
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

        }
    }
}
