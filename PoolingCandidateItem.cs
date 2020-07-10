using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Election_Project
{
    public partial class PoolingCandidateItem : UserControl
    {
        public PoolingCandidateItem()
        {
            InitializeComponent();
        }

        private void PoolingCandidateItem_Load(object sender, EventArgs e)
        {
            
        }
        
        public string Party;
        public new string Name;
        public string Constituency;
        public string Id;
        public int VoteCount;
        public string Pic_Path;

        public  string NAME
        {
            get { return Name; }
            set { Name = value; label_UC_Candidate_Name.Text = value; }
        }

        public string CONSTITUENCY
        {
            get { return Constituency; }
            set { Constituency = value; label_UC_Candidate_Consti.Text = value; }
        }

        public string PARTY
        {
            get { return Party; }
            set { Party = value; label_UC_Candidate_Party.Text = value; }
        }

        public string ID
        {
            get { return Id; }
            set { Id = value;  }
        }
        public int VOTECOUNT
        {
            get { return VoteCount; }
            set { VoteCount = value; }
        }
        public string PHOTO_PATH
        {
            get { return Pic_Path; }
            set { Pic_Path = value; pictureBox_UC_Candidate_PIC.Image = Image.FromFile(value); }
        }
        private void button_UC_VOTE_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to vote "+NAME+"?","Vote COnfirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes){
                VOTECOUNT = VOTECOUNT + 1;
                DBhandler.VoterCast(VoterLogIn.id, ID);
                DBhandler.SetVoteCount(ID, VOTECOUNT);
            }
            
        }
    }
}
