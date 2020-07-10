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
    public partial class VoterLogIn : Form
    {
        Form_main obj = Application.OpenForms["Form_main"] as Form_main;
        //VoterLogIn obj2 = Application.OpenForms["VoterLogIn"] as VoterLogIn;
        public static string id;
        public static string Constituency;
        public VoterLogIn()
        {
            InitializeComponent();
        }

        private bool IsValid()
        {
            string CNIC = "[0-9]{13}";
            string password = "^[a-zA-Z0-9]{8}";
            //CNIC
            if (textBox_VOTER_LOGIN_CNIC.Text == string.Empty)
            {
                errorProvider_voterlogin.SetError(textBox_VOTER_LOGIN_CNIC, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_VOTER_LOGIN_CNIC.Text, CNIC) == false)
            {
                errorProvider_voterlogin.SetError(textBox_VOTER_LOGIN_CNIC, "Numerics are Allowed only");
                return false;
            }
            errorProvider_voterlogin.SetError(textBox_VOTER_LOGIN_CNIC, "");
            //Password
            if (textBox_VOTER_LOGIN_PASSWORD.Text == string.Empty)
            {
                errorProvider_voterlogin.SetError(textBox_VOTER_LOGIN_PASSWORD, "This can't be Empty");
                return false;
            }
            else if (Regex.IsMatch(textBox_VOTER_LOGIN_PASSWORD.Text, password) == false)
            {
                errorProvider_voterlogin.SetError(textBox_VOTER_LOGIN_PASSWORD, "Alpha-Numeric values Allowed only");
                return false;
            }
            errorProvider_voterlogin.SetError(textBox_VOTER_LOGIN_PASSWORD, "");
            return true;
        }
        private void button_VoterLogin_Click(object sender, EventArgs e)
        {
            if (IsValid() == true)
            {
                if (obj.flag == false)
                {
                    Voter_Reg_Check();
                }else if (obj.flag == true)
                {
                    Vote_here();
                }
            }
        }

        private void Voter_Reg_Check()
        {
            id = textBox_VOTER_LOGIN_CNIC.Text;
            string pass = textBox_VOTER_LOGIN_PASSWORD.Text;
            List<Voter> voter = new List<Voter>();
            voter = DBhandler.GetVoterwithCNIC(id);
            if (voter.Count != 0)
            {
                label_voter_login_CNIC_error_label.Visible = false;
                foreach (Voter v in voter)
                {
                    if (v.password == pass)
                    {
                        label__voter_login_Pass_error_label.Visible = false;
                        //  Form vtrReg = new VoterRegistrationCheck();
                        obj.penalLock();
                        obj.openChildFormInPanel(new VoterRegistrationCheck());
                    }
                    else
                    {
                        label__voter_login_Pass_error_label.Visible = true;
                        label__voter_login_Pass_error_label.Visible = true;
                    }
                }
            }
            else
            {
                label_voter_login_CNIC_error_label.Visible = true;
            }
        }

        private void Vote_here()
        {
            id = textBox_VOTER_LOGIN_CNIC.Text;
            string pass = textBox_VOTER_LOGIN_PASSWORD.Text;
            List<Voter> voter = new List<Voter>();
            voter = DBhandler.GetVoterwithCNIC(id);
            if (voter.Count != 0)
            {
                label_voter_login_CNIC_error_label.Visible = false;
                foreach (Voter v in voter)
                {
                    if (v.password == pass)
                    {
                        label__voter_login_Pass_error_label.Visible = false;
                        //  Form vtrReg = new VoterRegistrationCheck();
                        //obj.penalLock();
                        Constituency = v.CONSTITUENCY;
                        obj.openChildFormInPanel(new Pooling());
                    }
                    else
                    {
                        label__voter_login_Pass_error_label.Visible = true;
                        label__voter_login_Pass_error_label.Visible = true;
                    }
                }
            }
            else
            {
                label_voter_login_CNIC_error_label.Visible = true;
            }
        }

        private void VoterLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
