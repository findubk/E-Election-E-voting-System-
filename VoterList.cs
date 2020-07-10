using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace E_Election_Project
{
    public partial class VoterList : Form
    {
        public VoterList()
        {
            InitializeComponent();
        }

        private bool IsValid()
        {
            string CNIC = "[0-9]{13}";
            //CNIC
            if (textBox_CNIC_VOTER_List.Text == string.Empty)
            {
                errorProvider_Voter_List.SetError(textBox_CNIC_VOTER_List, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_CNIC_VOTER_List.Text, CNIC) == false)
            {
                errorProvider_Voter_List.SetError(textBox_CNIC_VOTER_List, "Numerics are Allowed only");
                return false;
            }
            errorProvider_Voter_List.SetError(textBox_CNIC_VOTER_List, "");
            return true;
        }
        

        private void button_Pending_List_Click(object sender, EventArgs e)
        {
            List<Voter> voter;
            voter = DBhandler.GetVoterPendingEligibilty();
            if (voter.Count != 0)
            {
                label_Voter_list_No_Record.Visible = false;
                dataGridView_Voter_List.DataSource = voter;
            }
            else
            {
                dataGridView_Voter_List.DataSource = voter;
                label_Voter_list_No_Record.Visible = true;
            }
        }

        private void button_InELigible_List_Click(object sender, EventArgs e)
        {
            List<Voter> voter;
            voter = DBhandler.GetVoterIneligible();
            if (voter.Count != 0)
            {
                label_Voter_list_No_Record.Visible = false;
                dataGridView_Voter_List.DataSource = voter;
            }
            else
            {
                dataGridView_Voter_List.DataSource = voter;
                label_Voter_list_No_Record.Visible = true;
            }

        }

        private void button_ELigible_List_Click(object sender, EventArgs e)
        {
            List<Voter> voter;
            voter = DBhandler.GetVoterEligible();
            if (voter.Count != 0)
            {
                label_Voter_list_No_Record.Visible = false;
                dataGridView_Voter_List.DataSource = voter;
            }
            else
            {
                dataGridView_Voter_List.DataSource = voter;
                label_Voter_list_No_Record.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Voter> voter;
            voter = DBhandler.GetVoterList();
            if (voter.Count != 0)
            {
                label_Voter_list_No_Record.Visible = false;
                dataGridView_Voter_List.DataSource = voter;
            }
            else
            {
                dataGridView_Voter_List.DataSource = voter;
                label_Voter_list_No_Record.Visible = true;
            }
        }

        private void VoterList_Load(object sender, EventArgs e)
        {

        }

        private void button_Search_voter_List_Click(object sender, EventArgs e)
        {
            if (IsValid() == true)
            {
                List<Voter> voter;
                voter = DBhandler.GetVoterwithCNIC(textBox_CNIC_VOTER_List.Text);
                if (voter.Count != 0)
                {
                    label_Voter_list_No_Record.Visible = false;
                    dataGridView_Voter_List.DataSource = voter;
                }
                else
                {
                    dataGridView_Voter_List.DataSource =voter;
                    label_Voter_list_No_Record.Visible = true;
                }
            }
        }
    }
}
