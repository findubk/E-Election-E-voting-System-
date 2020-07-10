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
    public partial class CandidateList : Form
    {
        public CandidateList()
        {
            InitializeComponent();
        }

        private void CandidateList_Load(object sender, EventArgs e)
        {

        }

        private bool ISvalid()
        {
            string Constituency = "[0-9]{3}";
            //Combo box
            if (comboBox_CandidateList.Text == "Select")
            {
                errorProvider_CandidateList.SetError(comboBox_CandidateList, "Please Select any option!");
                return false;
            }
            errorProvider_CandidateList.SetError(textBox_CandidateListConstituency, "");
            //textbox
            if (textBox_CandidateListConstituency.Text == string.Empty)
            {
                errorProvider_CandidateList.SetError(textBox_CandidateListConstituency, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_CandidateListConstituency.Text, Constituency) == false)
            {
                errorProvider_CandidateList.SetError(textBox_CandidateListConstituency, "Numbers Allowed only");
                return false;
            }
            errorProvider_CandidateList.SetError(textBox_CandidateListConstituency, "");
            return true;
        }

        private void button_AllCandidateList_Click(object sender, EventArgs e)
        {
            List<Candidate> candidate;
            candidate = DBhandler.GetCandidateList();
            if (candidate.Count != 0)
            {
                label_CandidateList_No_Record.Visible = false ;
                dataGridView_CandidateList.DataSource = candidate;
            }
            else
            {
                label_CandidateList_No_Record.Visible = true;
            }
        }
        private void button_candidateListSearch_Click(object sender, EventArgs e)
        {
            if (ISvalid() == true)
            {
                string key = comboBox_CandidateList.Text + "-" + textBox_CandidateListConstituency.Text;
                List<Candidate> candidate;
                candidate = DBhandler.GetSpecficConstituencyCandidateList(key);
                if (candidate.Count != 0)
                {
                    label_CandidateList_No_Record.Visible = false;
                    dataGridView_CandidateList.DataSource = candidate;
                }
                else
                {
                    label_CandidateList_No_Record.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Constituency");
            }
        }
    }
}
