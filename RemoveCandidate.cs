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
    public partial class RemoveCandidate : Form
    {
        string key;
        public RemoveCandidate()
        {
            InitializeComponent();
        }

        private void RemoveCandidate_Load(object sender, EventArgs e)
        {

        }

        private bool ISvalid()
        {
            string Constituency = "[0-9]{3}";
            //Combo box
            if (comboBox_Remove_Candidate.Text == "Select")
            {
                errorProvider_CandidateRemove.SetError(comboBox_Remove_Candidate, "Please Select any option!");
                return false;
            }
            errorProvider_CandidateRemove.SetError(textBox_Remove_Candidate_Constituency, "");
            //textbox
            if (textBox_Remove_Candidate_Constituency.Text == string.Empty)
            {
                errorProvider_CandidateRemove.SetError(textBox_Remove_Candidate_Constituency, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_Remove_Candidate_Constituency.Text, Constituency) == false)
            {
                errorProvider_CandidateRemove.SetError(textBox_Remove_Candidate_Constituency, "Numbers Allowed only");
                return false;
            }
            return true;
        }

        private void button_Remove_Candidate_Search_Click(object sender, EventArgs e)
        {
            if (ISvalid() == true)
            {
                string key = comboBox_Remove_Candidate.Text + "-" + textBox_Remove_Candidate_Constituency.Text;
                List<Candidate> candidate;
                candidate = DBhandler.GetSpecficConstituencyCandidateList(key);
                dataGridView_Candidate_Romove.DataSource = candidate;
            }
            else
            {
                MessageBox.Show("Enter Valid Constituency");
            }
        }

        private void button_AllCandidateList_Remove_Candidate_Click(object sender, EventArgs e)
        {
            List<Candidate> candidate;
            candidate = DBhandler.GetCandidateList();
            dataGridView_Candidate_Romove.DataSource = candidate;
        }

        

        private void button_Delete_Row_Candidate_Remove_Click(object sender, EventArgs e)
        {
            bool result;
            result = DBhandler.DeleteCandidate(key);
            if (result == true)
            {
                button_Delete_Row_Candidate_Remove.Enabled = false;
                MessageBox.Show("Data Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void dataGridView_Candidate_Romove_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            button_Delete_Row_Candidate_Remove.Enabled = true;
            key = dataGridView_Candidate_Romove.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
