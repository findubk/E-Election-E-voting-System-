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
    public partial class PostVoting : UserControl
    {
        public PostVoting()
        {
            InitializeComponent();
        }

        private void PostVoting_Load(object sender, EventArgs e)
        {

        }
        public void InEligible_msg()
        {
            label_PostVoting_Ineleigible_message.Visible = true;
        }
        public void Re_Vote_msg()
        {
            label_POSTVOTING_RE_Vote_msg.Visible = true;
        }
        public void Thanks_msg()
        {
            label_postVoting_message.Visible = true;
        }
    }
}
