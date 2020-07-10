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
    public partial class voterRegistration : Form
    {
        static string Image_Path;
        public voterRegistration()
        {
            InitializeComponent();
        }

        private void button_VoterPhotoUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_voterPic.Image = new Bitmap(opnfd.FileName);
            }
            if (pictureBox_voterPic.Image != null)
            {
                String id = textBox_VoterCnic.Text+".jpg";
                string folder = "C:\\Users\\Admin\\Desktop\\C# E-Election Project\\User Control\\E-Election_Project\\E-Election_Project\\Resources\\Voter_Images";
                Image_Path = System.IO.Path.Combine(folder,id);
                Image a = pictureBox_voterPic.Image;
                a.Save(Image_Path);
            }
        }

        private void clear()
        {
            foreach(Control c in Controls)
            {
                if(c is TextBox || c is DateTimePicker)
                {
                    c.Text = "";
                }
            }
        }
        private void button_AddVoter_Click(object sender, EventArgs e)
        {
            if (IsValid() == true)
            {
                Voter voter = new Voter();
                voter.CNIC = textBox_VoterCnic.Text;
                voter.FIRST_NAME = textBox_Voterfname.Text;
                voter.LAST_NAME = textBox_VoterLname.Text;
                voter.DOB = dateTimePicker_Voter.Text;
                voter.EMAIL_ID = textBox_VoterEmail.Text;
                voter.PHONE_NO = textBox_VoterphNO.Text;
                voter.ADDRESS = textBox_VoterAddress.Text;
                voter.PROVIENCE = textBox_Voterprovience.Text;
                voter.PASSWORD = textBox_VoterPassword.Text;
                voter.Re_password = voter.PASSWORD;
                voter.ELIGIBILITY = "Pending";
                voter.CONSTITUENCY = "";
                voter.STATUS = "";
                voter.VOTE = "";
                voter.PICPATH = Image_Path;
                DBhandler.insertIntoVoter(voter);
                clear();
            }
            else
            {
                MessageBox.Show("Data you Enter is not Valid to be processed.Please!Enter the valid Data.");
            }
        }

        //Form Validation
        private bool IsValid()
        {
            string stringChar = @"^[a-zA-Z\s]+$";
            string CNIC = "[0-9]{13}";
            string PhoenNo = "[0-9]{11}";
            string mail = @"\A(?:[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            string password = "^[a-zA-Z0-9]{8}";
            string Address = @"^[A-Za-z0-9]+(?:\s[A-Za-z0-9'_-]+)+$";
            //First Name
            if (textBox_Voterfname.Text == string.Empty)
            {
                errorProvider_VoterRegForm.SetError(textBox_Voterfname, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_Voterfname.Text, stringChar, RegexOptions.IgnoreCase) == false)
            {
                errorProvider_VoterRegForm.SetError(textBox_Voterfname, "Alphabets Allowed only");
                return false;
            }
            errorProvider_VoterRegForm.SetError(textBox_Voterfname, "");
            
            //Last Name
            if (textBox_VoterLname.Text == string.Empty)
            {
                errorProvider_VoterRegForm.SetError(textBox_VoterLname, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_VoterLname.Text, stringChar, RegexOptions.IgnoreCase) == false)
            {
                errorProvider_VoterRegForm.SetError(textBox_VoterLname, "Alphabets Allowed only");
                return false;
            }
            errorProvider_VoterRegForm.SetError(textBox_VoterLname, "");
           
            
            //CNIC
            if (textBox_VoterCnic.Text == string.Empty)
            {
                errorProvider_VoterRegForm.SetError(textBox_VoterCnic, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_VoterCnic.Text,CNIC ) == false)
            {
                errorProvider_VoterRegForm.SetError(textBox_VoterCnic, "Numerics are Allowed only");
                return false;
            }
            errorProvider_VoterRegForm.SetError(textBox_VoterCnic, "");

            //DOB
            DateTime Selected = Convert.ToDateTime(dateTimePicker_Voter.Text);
            DateTime todate = Convert.ToDateTime(DateTime.Now.ToString());
            TimeSpan ts = todate.Subtract(Selected);
            int days = Convert.ToInt16(ts.Days);
            int years = days / 365;
            if (years<18)
            {
                errorProvider_VoterRegForm.SetError(dateTimePicker_Voter, "Please Pick A Date");
                return false;
            }
            errorProvider_VoterRegForm.SetError(dateTimePicker_Voter, "");
            
            //Email
            if (textBox_VoterEmail.Text == string.Empty)
            {
                errorProvider_VoterRegForm.SetError(textBox_VoterEmail, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_VoterEmail.Text, mail) == false)
            {
                errorProvider_VoterRegForm.SetError(textBox_VoterEmail, "Mail Must match the Exp Formate");
                return false;
            }
            errorProvider_VoterRegForm.SetError(textBox_VoterEmail, "");

            //Phone NO
            if (textBox_VoterphNO.Text == string.Empty)
            {
                errorProvider_VoterRegForm.SetError(textBox_VoterphNO, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_VoterphNO.Text, PhoenNo) == false)
            {
                errorProvider_VoterRegForm.SetError(textBox_VoterphNO, "Numerics are Allowed only");
                return false;
            }
            errorProvider_VoterRegForm.SetError(textBox_VoterphNO, "");

            //Address
            if (textBox_VoterAddress.Text == string.Empty)
            {
                errorProvider_VoterRegForm.SetError(textBox_VoterAddress, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_VoterAddress.Text,Address , RegexOptions.IgnoreCase) == false)
            {
                errorProvider_VoterRegForm.SetError(textBox_VoterAddress, "Alpha-Numeric and special Allowed only");
                return false;
            }
            errorProvider_VoterRegForm.SetError(textBox_VoterAddress, "");
            //Provience
            if (textBox_Voterprovience.Text == string.Empty)
            {
                errorProvider_VoterRegForm.SetError(textBox_Voterprovience, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_Voterprovience.Text,stringChar) == false)
            {
                errorProvider_VoterRegForm.SetError(textBox_Voterprovience, "Alphabets Allowed only");
                return false;
            }
            errorProvider_VoterRegForm.SetError(textBox_Voterprovience, "");
           

            //Password
            if (textBox_VoterPassword.Text == string.Empty)
            {
                errorProvider_VoterRegForm.SetError(textBox_VoterPassword, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_VoterPassword.Text,password) == false)
            {
                errorProvider_VoterRegForm.SetError(textBox_VoterPassword, "Alpha-Numeric values Allowed only");
                return false;
            }
            errorProvider_VoterRegForm.SetError(textBox_VoterPassword, "");
            //Re-password
            if (textBox_VoterConfrmPass.Text == string.Empty)
            {
                errorProvider_VoterRegForm.SetError(textBox_VoterConfrmPass, "This can't be Empty");
                return false;
            }
            else if (textBox_VoterPassword.Text!= textBox_VoterConfrmPass.Text)
            {
                errorProvider_VoterRegForm.SetError(textBox_VoterConfrmPass, "Password didn't Match!");
                return false;
            }
            errorProvider_VoterRegForm.SetError(textBox_VoterConfrmPass, "");

            return true;
        }

        private void voterRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
