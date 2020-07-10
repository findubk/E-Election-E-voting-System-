namespace E_Election_Project
{
    partial class Form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.panel_sidebar = new System.Windows.Forms.Panel();
            this.button_Main_Quit = new System.Windows.Forms.Button();
            this.panel_admindropdown = new System.Windows.Forms.Panel();
            this.button_login = new System.Windows.Forms.Button();
            this.button_Admin = new System.Windows.Forms.Button();
            this.panel_voterDropdown = new System.Windows.Forms.Panel();
            this.button_VoterRegCheak = new System.Windows.Forms.Button();
            this.button_voter_Reg = new System.Windows.Forms.Button();
            this.button_VoteHere = new System.Windows.Forms.Button();
            this.button_Voter = new System.Windows.Forms.Button();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.label_logo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel_ins_container = new System.Windows.Forms.Panel();
            this.button_hide_ins = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label_inst = new System.Windows.Forms.Label();
            this.label_Mainpage = new System.Windows.Forms.Label();
            this.panel_sidebar.SuspendLayout();
            this.panel_admindropdown.SuspendLayout();
            this.panel_voterDropdown.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_container.SuspendLayout();
            this.panel_ins_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel_sidebar.Controls.Add(this.button_Main_Quit);
            this.panel_sidebar.Controls.Add(this.panel_admindropdown);
            this.panel_sidebar.Controls.Add(this.button_Admin);
            this.panel_sidebar.Controls.Add(this.panel_voterDropdown);
            this.panel_sidebar.Controls.Add(this.button_Voter);
            this.panel_sidebar.Controls.Add(this.panel_Logo);
            this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sidebar.Location = new System.Drawing.Point(0, 0);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.Size = new System.Drawing.Size(250, 523);
            this.panel_sidebar.TabIndex = 0;
            // 
            // button_Main_Quit
            // 
            this.button_Main_Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.button_Main_Quit.FlatAppearance.BorderSize = 0;
            this.button_Main_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Main_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Main_Quit.ForeColor = System.Drawing.Color.Red;
            this.button_Main_Quit.Location = new System.Drawing.Point(71, 474);
            this.button_Main_Quit.Name = "button_Main_Quit";
            this.button_Main_Quit.Size = new System.Drawing.Size(111, 34);
            this.button_Main_Quit.TabIndex = 6;
            this.button_Main_Quit.Text = "QUIT";
            this.button_Main_Quit.UseVisualStyleBackColor = false;
            this.button_Main_Quit.Click += new System.EventHandler(this.button_Main_Quit_Click);
            // 
            // panel_admindropdown
            // 
            this.panel_admindropdown.Controls.Add(this.button_login);
            this.panel_admindropdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_admindropdown.Location = new System.Drawing.Point(0, 320);
            this.panel_admindropdown.Name = "panel_admindropdown";
            this.panel_admindropdown.Size = new System.Drawing.Size(250, 88);
            this.panel_admindropdown.TabIndex = 5;
            this.panel_admindropdown.Visible = false;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.button_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_login.Location = new System.Drawing.Point(0, 0);
            this.button_login.Name = "button_login";
            this.button_login.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_login.Size = new System.Drawing.Size(250, 40);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "LOG IN";
            this.button_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_Admin
            // 
            this.button_Admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Admin.FlatAppearance.BorderSize = 0;
            this.button_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Admin.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_Admin.Location = new System.Drawing.Point(0, 275);
            this.button_Admin.Name = "button_Admin";
            this.button_Admin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Admin.Size = new System.Drawing.Size(250, 45);
            this.button_Admin.TabIndex = 4;
            this.button_Admin.Text = "Admin";
            this.button_Admin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Admin.UseVisualStyleBackColor = true;
            this.button_Admin.Click += new System.EventHandler(this.button_Admin_Click_1);
            // 
            // panel_voterDropdown
            // 
            this.panel_voterDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel_voterDropdown.Controls.Add(this.button_VoterRegCheak);
            this.panel_voterDropdown.Controls.Add(this.button_voter_Reg);
            this.panel_voterDropdown.Controls.Add(this.button_VoteHere);
            this.panel_voterDropdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_voterDropdown.Location = new System.Drawing.Point(0, 145);
            this.panel_voterDropdown.Name = "panel_voterDropdown";
            this.panel_voterDropdown.Size = new System.Drawing.Size(250, 130);
            this.panel_voterDropdown.TabIndex = 3;
            this.panel_voterDropdown.Visible = false;
            // 
            // button_VoterRegCheak
            // 
            this.button_VoterRegCheak.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_VoterRegCheak.FlatAppearance.BorderSize = 0;
            this.button_VoterRegCheak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_VoterRegCheak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_VoterRegCheak.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_VoterRegCheak.Location = new System.Drawing.Point(0, 80);
            this.button_VoterRegCheak.Name = "button_VoterRegCheak";
            this.button_VoterRegCheak.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_VoterRegCheak.Size = new System.Drawing.Size(250, 40);
            this.button_VoterRegCheak.TabIndex = 2;
            this.button_VoterRegCheak.Text = "Cheak Your Registration";
            this.button_VoterRegCheak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_VoterRegCheak.UseVisualStyleBackColor = true;
            this.button_VoterRegCheak.Click += new System.EventHandler(this.button_VoterRegCheak_Click);
            // 
            // button_voter_Reg
            // 
            this.button_voter_Reg.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_voter_Reg.FlatAppearance.BorderSize = 0;
            this.button_voter_Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_voter_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_voter_Reg.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_voter_Reg.Location = new System.Drawing.Point(0, 40);
            this.button_voter_Reg.Name = "button_voter_Reg";
            this.button_voter_Reg.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_voter_Reg.Size = new System.Drawing.Size(250, 40);
            this.button_voter_Reg.TabIndex = 1;
            this.button_voter_Reg.Text = "Register As Voter";
            this.button_voter_Reg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_voter_Reg.UseVisualStyleBackColor = true;
            this.button_voter_Reg.Click += new System.EventHandler(this.button_voter_Reg_Click);
            // 
            // button_VoteHere
            // 
            this.button_VoteHere.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_VoteHere.FlatAppearance.BorderSize = 0;
            this.button_VoteHere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_VoteHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_VoteHere.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_VoteHere.Location = new System.Drawing.Point(0, 0);
            this.button_VoteHere.Name = "button_VoteHere";
            this.button_VoteHere.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_VoteHere.Size = new System.Drawing.Size(250, 40);
            this.button_VoteHere.TabIndex = 0;
            this.button_VoteHere.Text = "Vote Here!";
            this.button_VoteHere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_VoteHere.UseVisualStyleBackColor = true;
            this.button_VoteHere.Click += new System.EventHandler(this.button_VoteHere_Click);
            // 
            // button_Voter
            // 
            this.button_Voter.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Voter.FlatAppearance.BorderSize = 0;
            this.button_Voter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Voter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Voter.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_Voter.Location = new System.Drawing.Point(0, 100);
            this.button_Voter.Name = "button_Voter";
            this.button_Voter.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Voter.Size = new System.Drawing.Size(250, 45);
            this.button_Voter.TabIndex = 1;
            this.button_Voter.Text = "Voter";
            this.button_Voter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Voter.UseVisualStyleBackColor = true;
            this.button_Voter.Click += new System.EventHandler(this.button_Voter_Click_1);
            // 
            // panel_Logo
            // 
            this.panel_Logo.Controls.Add(this.label_logo);
            this.panel_Logo.Controls.Add(this.pictureBox1);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(250, 100);
            this.panel_Logo.TabIndex = 2;
            // 
            // label_logo
            // 
            this.label_logo.AutoSize = true;
            this.label_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logo.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_logo.Location = new System.Drawing.Point(67, 38);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(180, 24);
            this.label_logo.TabIndex = 0;
            this.label_logo.Text = "E-Election System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E_Election_Project.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel_container.Controls.Add(this.panel_ins_container);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(250, 0);
            this.panel_container.MinimumSize = new System.Drawing.Size(747, 523);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(747, 523);
            this.panel_container.TabIndex = 1;
            // 
            // panel_ins_container
            // 
            this.panel_ins_container.Controls.Add(this.button_hide_ins);
            this.panel_ins_container.Controls.Add(this.richTextBox1);
            this.panel_ins_container.Controls.Add(this.label_inst);
            this.panel_ins_container.Controls.Add(this.label_Mainpage);
            this.panel_ins_container.Location = new System.Drawing.Point(18, 26);
            this.panel_ins_container.Name = "panel_ins_container";
            this.panel_ins_container.Size = new System.Drawing.Size(717, 485);
            this.panel_ins_container.TabIndex = 0;
            // 
            // button_hide_ins
            // 
            this.button_hide_ins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hide_ins.Location = new System.Drawing.Point(583, 445);
            this.button_hide_ins.Name = "button_hide_ins";
            this.button_hide_ins.Size = new System.Drawing.Size(113, 26);
            this.button_hide_ins.TabIndex = 6;
            this.button_hide_ins.Text = "Hide";
            this.button_hide_ins.UseVisualStyleBackColor = true;
            this.button_hide_ins.Click += new System.EventHandler(this.button_hide_ins_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.richTextBox1.Location = new System.Drawing.Point(3, 91);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(703, 391);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label_inst
            // 
            this.label_inst.AutoSize = true;
            this.label_inst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_inst.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_inst.Location = new System.Drawing.Point(12, 58);
            this.label_inst.Name = "label_inst";
            this.label_inst.Size = new System.Drawing.Size(120, 16);
            this.label_inst.TabIndex = 4;
            this.label_inst.Text = "INSTRUCTION:-";
            // 
            // label_Mainpage
            // 
            this.label_Mainpage.AutoSize = true;
            this.label_Mainpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Mainpage.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_Mainpage.Location = new System.Drawing.Point(212, 11);
            this.label_Mainpage.Name = "label_Mainpage";
            this.label_Mainpage.Size = new System.Drawing.Size(293, 25);
            this.label_Mainpage.TabIndex = 3;
            this.label_Mainpage.Text = "WelCome E-Voting System";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 523);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panel_sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Election";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.panel_sidebar.ResumeLayout(false);
            this.panel_admindropdown.ResumeLayout(false);
            this.panel_voterDropdown.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            this.panel_Logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_container.ResumeLayout(false);
            this.panel_ins_container.ResumeLayout(false);
            this.panel_ins_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_sidebar;
        private System.Windows.Forms.Panel panel_voterDropdown;
        private System.Windows.Forms.Button button_VoterRegCheak;
        private System.Windows.Forms.Button button_voter_Reg;
        private System.Windows.Forms.Button button_VoteHere;
        private System.Windows.Forms.Button button_Voter;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Panel panel_admindropdown;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_Admin;
        private System.Windows.Forms.Label label_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_ins_container;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label_inst;
        private System.Windows.Forms.Label label_Mainpage;
        private System.Windows.Forms.Button button_hide_ins;
        private System.Windows.Forms.Button button_Main_Quit;
    }
}

