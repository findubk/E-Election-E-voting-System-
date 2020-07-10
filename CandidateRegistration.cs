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
    public partial class CandidateRegistration : Form
    {
        public string Image_Path;
        public CandidateRegistration()
        {
            InitializeComponent();
        }

        private void CandidateRegistration_Load(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox || c is DateTimePicker)
                {
                    c.Text = "";
                }
            }
        }
        private void button_AddVoter_Click(object sender, EventArgs e)
        {
            if (ISvalid() == true)
            {
                Candidate candidate = new Candidate();
                candidate.CNIC = textBox_CandidateCnic.Text;
                candidate.FIRSTNAME = textBox_Candidatefname.Text;
                candidate.LASTNAME = textBox_CandidateLname.Text;
                candidate.CONSTITUENCY =comboBox_Candidate_House.Text+"-"+textBox_CandidateConstituency.Text;
                candidate.PROVIENCE = textBox_Candidateprovience.Text;
                candidate.PARTY = textBox_Candidateparty.Text;
                candidate.VOTECOUNT = 0;
                candidate.PHOTOPATH = Image_Path;
                DBhandler.insertIntoCandidate(candidate);
                clear();
            }
            else
            {
                MessageBox.Show("Data you Enter is not Valid to be processed.Please!Enter the valid Data.");
            }
        }

        //form avlidation
        private bool ISvalid()
        {
            string stringChar = @"^[a-zA-Z\s]+$";
            string Constituency = "[0-9]{3}";
            string CNIC = "[0-9]{13}";
            //First Name
            if (textBox_Candidatefname.Text == string.Empty)
            {
            
                errorProvider_CandidateForm.SetError(textBox_Candidatefname, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_Candidatefname.Text, stringChar) == false)
            {
                errorProvider_CandidateForm.SetError(textBox_Candidatefname, "Alphabets Allowed only");
                return false;
            }
            errorProvider_CandidateForm.SetError(textBox_Candidatefname, "");
            
            //Last Name
            if (textBox_CandidateLname.Text == string.Empty)
            {
                
                errorProvider_CandidateForm.SetError(textBox_CandidateLname, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_CandidateLname.Text, stringChar) == false)
            {
                errorProvider_CandidateForm.SetError(textBox_CandidateLname, "Alphabets Allowed only");
                return false;
            }
            errorProvider_CandidateForm.SetError(textBox_CandidateLname, "");

            //CNIC
            if (textBox_CandidateCnic.Text == string.Empty)
            {
                
                errorProvider_CandidateForm.SetError(textBox_CandidateCnic, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_CandidateCnic.Text, CNIC) == false)
            {
                errorProvider_CandidateForm.SetError(textBox_CandidateCnic, "Alphabets Allowed only");
                return false;
            }
            errorProvider_CandidateForm.SetError(textBox_CandidateCnic, "");
           
            
            //Counstituency combo box

            if (comboBox_Candidate_House.Text == "Select")
            {
                errorProvider_CandidateForm.SetError(textBox_CandidateConstituency, "Please Select any option!");
                return false;
            }
            errorProvider_CandidateForm.SetError(textBox_CandidateConstituency, "");
            //Constituency Text BOX
            if (textBox_CandidateConstituency.Text == string.Empty)
            { 
                    errorProvider_CandidateForm.SetError(textBox_CandidateConstituency, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_CandidateConstituency.Text, Constituency) == false)
            {
                errorProvider_CandidateForm.SetError(textBox_CandidateConstituency, "Alphabets Allowed only");
                return false;
            }
            errorProvider_CandidateForm.SetError(textBox_CandidateConstituency, "");
            
            //Provience
            if (textBox_Candidateprovience.Text == string.Empty)
            {
                errorProvider_CandidateForm.SetError(textBox_Candidateprovience, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_Candidateprovience.Text, stringChar) == false)
            {
                errorProvider_CandidateForm.SetError(textBox_Candidateprovience, "Alphabets Allowed only");
                return false;
            }
            errorProvider_CandidateForm.SetError(textBox_CandidateConstituency, "");

            //Party
            if (textBox_Candidateparty.Text == string.Empty)
            {
                
                errorProvider_CandidateForm.SetError(textBox_Candidateparty, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_Candidateparty.Text, stringChar) == false)
            {
                errorProvider_CandidateForm.SetError(textBox_Candidateparty, "Alphabets Allowed only");
                return false;
            }
            errorProvider_CandidateForm.SetError(textBox_Candidateparty, "");
            return true;
        }

        private void button_VoterPhotoUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_CandidatePic.Image = new Bitmap(opnfd.FileName);
            }
            if (pictureBox_CandidatePic.Image != null)
            {
                String id = textBox_CandidateCnic.Text + ".jpg";
                string folder = "C:\\Users\\Admin\\Desktop\\C# E-Election Project\\User Control\\E-Election_Project\\E-Election_Project\\Resources\\Candidate_Images";
                Image_Path = System.IO.Path.Combine(folder, id);
                Image a = pictureBox_CandidatePic.Image;
                a.Save(Image_Path);
            }
        }
    }
}
