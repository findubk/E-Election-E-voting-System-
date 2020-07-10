using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Election_Project
{
    public partial class AdminMainPagecs : Form
    {
        Form_main obj = Application.OpenForms["Form_main"] as Form_main;
        public AdminMainPagecs()
        {
            InitializeComponent();
        }
        
        private void button_admin_Addcandidate_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CandidateRegistration());
        }

        private void button_adminRomoveVoter_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new RemoveVoter());
        }

        private void button_adminLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            obj.Show();
            obj.ShowInstruc();
            obj.penalLock();
        }
        public Form activeForm = null;
        public void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Container_Admin.Controls.Add(childForm);
            panel_Container_Admin.Tag = childForm;
            childForm.Show();
        }

        private void AdminMainPagecs_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button_adminVoterLists_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new VoterList());
        }

        private void button_adminCandidateLists_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CandidateList());
        }

        private void button_adminRemoveCandidate_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new RemoveCandidate()); 
        }

        private void button_AdminRegisterVoter_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new AdminVoterRegistration());
        }
    }
}
