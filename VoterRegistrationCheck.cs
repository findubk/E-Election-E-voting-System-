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
    public partial class VoterRegistrationCheck : Form
    {
        Form_main obj = Application.OpenForms["Form_main"] as Form_main;
        public VoterRegistrationCheck()
        {
            InitializeComponent();
        }


        private void VoterRegistrationCheck_Load(object sender, EventArgs e)
        {
            List<Voter> voter;
            voter = DBhandler.GetVoterwithCNIC(VoterLogIn.id);
            
                
                foreach (Voter v in voter)
                {
                    label_Fname_Voter_Reg_Cheak_Display.Text = v.firstName;
                    label_Lname_Voter_Reg_Check_display.Text = v.lastName;
                    label_Cnic_Voter_Reg_Check_display.Text = v.Cnic;
                    label_DOB_Voter_Reg_Check_display.Text = v.dob;
                    label_Email_Voter_Reg_Check_display.Text = v.Email;
                    label_PhNO_Voter_Reg_Check_display.Text = v.PhoneNo;
                    label_Address_Voter_Reg_Check_display.Text = v.address;
                    label_Elgib_Voter_Reg_Check_display.Text = v.Eligibility;
                    label_Prov_Voter_Reg_Check_display.Text = v.Provience;
                    pictureBox_voterPic.Image = Image.FromFile(v.PICPATH);
                    if (v.Eligibility == "Eligible")
                    {
                        label_Elgib_Voter_Reg_Check_display.ForeColor = Color.Green;
                    }
                    else if (v.Eligibility == "Ineligible")
                    {
                        label_Elgib_Voter_Reg_Check_display.ForeColor = Color.Red;
                    }
                }
            
        }

        

        private void button_logout_voter_List_Click(object sender, EventArgs e)
        {
            this.Close();
            obj.penalLock();
        }
    }
}
    
