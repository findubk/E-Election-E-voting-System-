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
    public partial class AdminVoterRegistration : Form
    {
        String key;
        public AdminVoterRegistration()
        {
            InitializeComponent();
        }

        private void AdminVoterRegistration_Load(object sender, EventArgs e)
        {

        }

        private bool IsValid()
        {
            string CNIC = "[0-9]{13}";
            //CNIC
            if (textBox_CNIC__Ad_vtr_reg.Text == string.Empty)
            {
                errorProvider_Ad_vtr_reg.SetError(textBox_CNIC__Ad_vtr_reg, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_CNIC__Ad_vtr_reg.Text, CNIC) == false)
            {
                errorProvider_Ad_vtr_reg.SetError(textBox_CNIC__Ad_vtr_reg, "Numerics are Allowed only");
                return false;
            }
            errorProvider_Ad_vtr_reg.SetError(textBox_CNIC__Ad_vtr_reg, "");
            return true;
        }

        private void button_Ad_vtr_reg_AllVoterList_Click(object sender, EventArgs e)
        {
            List<Voter> voter;
            voter = DBhandler.GetVoterList();
            if (voter.Count != 0)
            {
                label_Voter_RegAdmin_No_Record.Visible = false;
                dataGridView__Ad_vtr_reg_.DataSource = voter;
            }
            else
            {
                dataGridView__Ad_vtr_reg_.DataSource = voter;
                label_Voter_RegAdmin_No_Record.Visible = true;
            }
        }

        private void button_Ad_vtr_reg_Pending_Click(object sender, EventArgs e)
        {
            List<Voter> voter;
            voter = DBhandler.GetVoterPendingEligibilty();
            if (voter.Count != 0)
            {
                label_Voter_RegAdmin_No_Record.Visible = false;
                dataGridView__Ad_vtr_reg_.DataSource = voter;
            }
            else
            {
                dataGridView__Ad_vtr_reg_.DataSource = voter;
                label_Voter_RegAdmin_No_Record.Visible = true;
            }
        }

        private void button__Ad_vtr_reg_ELigible_List_Click(object sender, EventArgs e)
        {
            List<Voter> voter;
            voter = DBhandler.GetVoterEligible();
            if (voter.Count != 0)
            {
                label_Voter_RegAdmin_No_Record.Visible = false;
                dataGridView__Ad_vtr_reg_.DataSource = voter;

            }
            else
            {
                dataGridView__Ad_vtr_reg_.DataSource = voter;
                label_Voter_RegAdmin_No_Record.Visible = true;
            }
        }

        private void button_Ad_vtr_reg_InELigible_List_Click(object sender, EventArgs e)
        {
            List<Voter> voter;
            voter = DBhandler.GetVoterIneligible();
            if (voter.Count != 0)
            {
                label_Voter_RegAdmin_No_Record.Visible = false;
                dataGridView__Ad_vtr_reg_.DataSource = voter;
            }
            else
            {
                dataGridView__Ad_vtr_reg_.DataSource = voter;
                label_Voter_RegAdmin_No_Record.Visible = true;
            }
        }

        private void button_Search_Ad_vtr_reg_Click(object sender, EventArgs e)
        {
            if (IsValid() == true)
            {
                List<Voter> voter;
                voter = DBhandler.GetVoterwithCNIC(textBox_CNIC__Ad_vtr_reg.Text);
                if (voter.Count != 0)
                {
                    label_Voter_RegAdmin_No_Record.Visible = false;
                    dataGridView__Ad_vtr_reg_.DataSource = voter;
                }
                else
                {
                    dataGridView__Ad_vtr_reg_.DataSource = voter;
                    dataGridView__Ad_vtr_reg_.Visible = true;
                }
            }
        }

        private void button_Ad_vtr_reg_Eligible_Click(object sender, EventArgs e)
        {
            if (comboBox_Remove_Candidate.Text != "Select" && textBox_Remove_Candidate_Constituency.Text != "")
            {
                errorProvider_Ad_vtr_reg.SetError(textBox_Remove_Candidate_Constituency, "");
                bool result;
                string constituency = comboBox_Remove_Candidate.Text + "-" + textBox_Remove_Candidate_Constituency.Text;
                result = DBhandler.SetVoterEligibility(key,constituency);
                if (result == true)
                {
                    MessageBox.Show("Success");
                    button_Ad_vtr_reg_Eligible.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                errorProvider_Ad_vtr_reg.SetError(textBox_Remove_Candidate_Constituency, "This can't be Empty");
            }
        }
        private void button_Ad_vtr_reg_InEligible_Click(object sender, EventArgs e)
        {
            bool result;
            result = DBhandler.SetVoterINEligibility(key);
            if (result == true)
            {
                MessageBox.Show("Success!");
                button_Ad_vtr_reg_InEligible.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }

        private void dataGridView__Ad_vtr_reg__CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string button_flag = dataGridView__Ad_vtr_reg_.Rows[0].Cells[9].Value.ToString();
            if (button_flag == "Ineligible")
            {
                    button_Ad_vtr_reg_Eligible.Enabled = true;
                    button_Ad_vtr_reg_InEligible.Enabled = false;
                
            }
            else if(button_flag=="Eligible")
            {
                button_Ad_vtr_reg_InEligible.Enabled = true;
                button_Ad_vtr_reg_Eligible.Enabled = false;
            }else if (button_flag == "Pending")
            {
                button_Ad_vtr_reg_InEligible.Enabled = true;
                button_Ad_vtr_reg_Eligible.Enabled = true;
                   // button_Ad_vtr_reg_InEligible.Enabled = false;
                }
                key = dataGridView__Ad_vtr_reg_.Rows[0].Cells[2].Value.ToString();
        }

        
    }
}
