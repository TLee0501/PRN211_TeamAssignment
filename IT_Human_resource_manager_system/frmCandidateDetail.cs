using BusinessObjects;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Human_resource_manager_system
{
    public partial class frmCandidateDetail : Form
    {
        public ICandidatesRepo candidatesRepo { get; set; }
        public bool InsertOrUpdate { get; set; } //False : Create, True : Update
        public Candidate Candidate { get; set; }
        public frmCandidateDetail()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var candidate = new Candidate()
                {
                    Id = int.Parse(txtID.Text),
                    Name = txtName.Text,
                    Description = txtDescription.Text
                };
                if (InsertOrUpdate == false)
                {  // tạo mới
                    candidatesRepo.Create(candidate);
                    Close();
                }
                else
                {
                    candidatesRepo.Update(candidate);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new project" : "Update a project");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCandidateDetail_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true) //Update mode
            {
                txtID.Enabled = false;
                txtID.Text = Candidate.Id.ToString();
                txtName.Text = Candidate.Name;
                txtDescription.Text = Candidate.Description;
            }
            else
            {
                txtID.Enabled = false;
                Guid id = Guid.NewGuid();
                txtID.Text = id.ToString();
            }
        }
    }
}
