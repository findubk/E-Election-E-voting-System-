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
    public partial class Form_main : Form
    {
        public bool flag;
        public Form_main()
        {
            InitializeComponent();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle=FormBorderStyle.None;
            penalLock();
        }
        public void startDesign()
                {
                    panel_voterDropdown.Visible = false;
                    panel_admindropdown.Visible = false;
                }
        public void hidesubMenu()
                {
                    if (panel_voterDropdown.Visible == true)
                    {
                        panel_voterDropdown.Visible = false;
                    }
                    if (panel_admindropdown.Visible == true)
                    {
                        panel_admindropdown.Visible = false;
                    }
                }

        public void showSubMenu(Panel submenu)
                {
                    if (submenu.Visible == false)
                    {
                        hidesubMenu();
                        submenu.Visible = true;
                    }
                    else
                    {
                        submenu.Visible = false;
                    }
                }


        public void button_Voter_Click_1(object sender, EventArgs e)
        {
            //panel_ins_container.Visible = true;
            showSubMenu(panel_voterDropdown);
        }

        public void button_Admin_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panel_admindropdown);
        }

        public Form activeForm = null;
        public void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_container.Controls.Add(childForm);
            panel_container.Tag = childForm;
            childForm.Show();
        }

        private void button_VoteHere_Click(object sender, EventArgs e)
        {
            flag = true;
            openChildFormInPanel(new VoterLogIn());
            hidesubMenu();
        }

        private void button_voter_Reg_Click(object sender, EventArgs e)
        {
            //panel_ins_container.Visible = false;
            openChildFormInPanel(new voterRegistration());
            hidesubMenu();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            //panel_ins_container.Visible = false;
            openChildFormInPanel(new AdminLogIn());
            hidesubMenu();
        }

        private void button_hide_ins_Click(object sender, EventArgs e)
        {
            panel_ins_container.Visible = false;
            penalLock();
        }
        public void ShowInstruc()
        {
            panel_ins_container.Visible = true;
        }

        private void button_Main_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_VoterRegCheak_Click(object sender, EventArgs e)
        {
            flag = false;
            openChildFormInPanel(new VoterLogIn());
            hidesubMenu();
        }

        public void penalLock()
        {
            if (panel_sidebar.Enabled == true)
            {
                panel_sidebar.Enabled = false;
            }else if (panel_sidebar.Enabled == false)
            {
                panel_sidebar.Enabled = true;
            }

        }
    }
   }
