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
    public partial class RemoveVoter : Form
    {
        public string key;
        public RemoveVoter()
        {
            InitializeComponent();
        }

        private void RemoveVoter_Load(object sender, EventArgs e)
        {

        }
        private bool IsValid()
        {
            string CNIC = "[0-9]{13}";
            //CNIC
            if (textBox_CNIC_VOTER_REMOVE.Text == string.Empty)
            {
                errorProvider_Voter_Remove.SetError(textBox_CNIC_VOTER_REMOVE, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_CNIC_VOTER_REMOVE.Text, CNIC) == false)
            {
                errorProvider_Voter_Remove.SetError(textBox_CNIC_VOTER_REMOVE, "Numerics are Allowed only");
                return false;
            }
            errorProvider_Voter_Remove.SetError(textBox_CNIC_VOTER_REMOVE, "");
            return true;
        }

        private void button_All_LIst_VOTER_REMOVE_Click(object sender, EventArgs e)
        {
            List<Voter> voter;
            voter = DBhandler.GetVoterList();
            if (voter.Count != 0)
            {
                label_Voter_Remove_No_Record.Visible = false;
                dataGridView_Voter_Romove.DataSource = voter;
            }
            else
            {
                dataGridView_Voter_Romove.DataSource = voter;
                label_Voter_Remove_No_Record.Visible = true;
            }
        }

        private void button_Eligible_List_VOTER_REMOVE_Click(object sender, EventArgs e)
        {
            List<Voter> voter;
            voter = DBhandler.GetVoterEligible();
            if (voter.Count != 0)
            {
                label_Voter_Remove_No_Record.Visible = false;
                dataGridView_Voter_Romove.DataSource = voter;
            }
            else
            {
                dataGridView_Voter_Romove.DataSource = voter;
                label_Voter_Remove_No_Record.Visible = true;
            }
        }

        private void button_inEligible_List_VOTER_REMOVE_Click(object sender, EventArgs e)
        {
            List<Voter> voter;
            voter = DBhandler.GetVoterIneligible();
            if (voter.Count != 0)
            {
                label_Voter_Remove_No_Record.Visible = false;
                dataGridView_Voter_Romove.DataSource = voter;
            }
            else
            {
                dataGridView_Voter_Romove.DataSource = voter;
                label_Voter_Remove_No_Record.Visible = true;
            }
        }

        private void button_Pending_Eligible_List_VOTER_REMOVE_Click(object sender, EventArgs e)
        {
            List<Voter> voter;
            voter = DBhandler.GetVoterPendingEligibilty();
            if (voter.Count != 0)
            {
                label_Voter_Remove_No_Record.Visible = false;
                dataGridView_Voter_Romove.DataSource = voter;
            }
            else
            {
                dataGridView_Voter_Romove.DataSource = voter;
                label_Voter_Remove_No_Record.Visible = true;
            }
        }

        private void button_Search_voter_remove_Click(object sender, EventArgs e)
        {
            if (IsValid() == true)
            {
                List<Voter> voter;
                voter = DBhandler.GetVoterwithCNIC(textBox_CNIC_VOTER_REMOVE.Text);
                if (voter.Count != 0)
                {
                    label_Voter_Remove_No_Record.Visible = false;
                    dataGridView_Voter_Romove.DataSource = voter;
                }
                else
                {
                    dataGridView_Voter_Romove.DataSource = voter;
                    label_Voter_Remove_No_Record.Visible = true;
                }
            }
        }

        private void button_Delete_Row_VOTER_REMOVE_Click(object sender, EventArgs e)
        {
            bool result;
            result = DBhandler.DeleteVoter(key);
            if (result == true)
            {
                MessageBox.Show(key);
                button_Delete_Row_VOTER_REMOVE.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

      

        private void dataGridView_Voter_Romove_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            button_Delete_Row_VOTER_REMOVE.Enabled = true;
            key = dataGridView_Voter_Romove.SelectedRows[0].Cells[2].Value.ToString();

        }
    }
}
