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
    public partial class Pooling : Form
    {
        public int i;
        Form_main obj = Application.OpenForms["Form_main"] as Form_main;
        public Pooling()
        {
            InitializeComponent();
        }

        private void Pooling_Load(object sender, EventArgs e)
        {
            obj.penalLock();
            List<Voter> voter;
            voter = DBhandler.GetVoterwithCNIC(VoterLogIn.id);
            List<Candidate> candidate;
            candidate = DBhandler.GetSpecficConstituencyCandidateList(VoterLogIn.Constituency);
            foreach (Voter v in voter)
            {
                
                label_Pooling_votr_info_name.Text = v.firstName+" "+v.lastName;
                label_Pooling_votr_info_CNIC.Text = v.Cnic;
                label_Pooling_votr_info_DOB.Text = v.dob;
                label_Pooling_votr_info_Consti.Text = v.CONSTITUENCY;
                label_Pooling_votr_info_provience.Text = v.Provience;
                pictureBox__Pooling_votr_info_pic.Image = Image.FromFile(v.PICPATH);

                if (v.Eligibility == "Eligible" )
                { 
                    if (v.STATUS == "")
                    {
                        flowLayoutPanel_pooling.Controls.Clear();
                        int i = candidate.Count;
                        int j = 0;
                        PoolingCandidateItem[] listItem = new PoolingCandidateItem[i];
                        foreach (Candidate c in candidate)
                        {
                            listItem[j] = new PoolingCandidateItem();
                            listItem[j].NAME = c.FIRSTNAME + " " + c.LASTNAME;
                            listItem[j].PARTY = c.PARTY;
                            listItem[j].CONSTITUENCY = c.CONSTITUENCY;
                            listItem[j].ID = c.CNIC;
                            listItem[j].VOTECOUNT = c.VOTECOUNT;
                            listItem[j].PHOTO_PATH = c.PHOTOPATH;
                            flowLayoutPanel_pooling.Controls.Add(listItem[j]);
                            j++;
                        }
                    }
                    else
                    {
                        flowLayoutPanel_pooling.Controls.Clear();
                        PostVoting[] item = new PostVoting[1];
                        item[0] = new PostVoting();
                        item[0].Re_Vote_msg();
                        flowLayoutPanel_pooling.Controls.Add(item[0]);
                    }
                }
                else if (v.Eligibility == "Ineligible")
                {
                    flowLayoutPanel_pooling.Controls.Clear();
                    PostVoting[] item = new PostVoting[1];
                    item[0] = new PostVoting();
                    item[0].InEligible_msg();
                    flowLayoutPanel_pooling.Controls.Add(item[0]);
                }
            }
        }
        public void Message()
        {
            flowLayoutPanel_pooling.Controls.Clear();
            PostVoting[] item = new PostVoting[1];
            item[0] = new PostVoting();
            item[0].Thanks_msg();
            flowLayoutPanel_pooling.Controls.Add(item[0]);
        }

        private void button_Pooling_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            obj.penalLock();
        }
    }
}
