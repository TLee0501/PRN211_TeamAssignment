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
    public partial class frmHR_Staff : Form
    {
        public Employee user;
        public frmHR_Staff()
        {
            InitializeComponent();
        }

        /*======================================================================================================================*/

        private void btnCandidatesAdd_Click(object sender, EventArgs e)
        {

        }

        private void dgvCandidates_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCandidatesDelete_Click(object sender, EventArgs e)
        {

        }

        /*======================================================================================================================*/
        /*======================================================================================================================*/


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

        }

        /*======================================================================================================================*/
        /*======================================================================================================================*/




        /*======================================================================================================================*/
        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
