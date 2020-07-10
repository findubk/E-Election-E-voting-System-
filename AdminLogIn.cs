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
    public partial class AdminLogIn : Form
    {
        Form_main obj = Application.OpenForms["Form_main"] as Form_main;
        public AdminLogIn()
        {
            InitializeComponent();
        }
        
        private void button_adminLogin_Click(object sender, EventArgs e)
        {
            Form AdminPage = new AdminMainPagecs();
            AdminPage.Show();
            obj.Hide();
            this.Close();
           
            
        }

        private void AdminLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
