namespace E_Election_Project
{
    partial class VoterLogIn
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
            this.components = new System.ComponentModel.Container();
            this.label_Voter_Login = new System.Windows.Forms.Label();
            this.button_VoterLogin = new System.Windows.Forms.Button();
            this.textBox_VOTER_LOGIN_PASSWORD = new System.Windows.Forms.TextBox();
            this.textBox_VOTER_LOGIN_CNIC = new System.Windows.Forms.TextBox();
            this.label_Admin_Password = new System.Windows.Forms.Label();
            this.label_admin_Username = new System.Windows.Forms.Label();
            this.label_voter_login_CNIC_error_label = new System.Windows.Forms.Label();
            this.errorProvider_voterlogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label__voter_login_Pass_error_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_voterlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Voter_Login
            // 
            this.label_Voter_Login.AutoSize = true;
            this.label_Voter_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Voter_Login.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_Voter_Login.Location = new System.Drawing.Point(290, 95);
            this.label_Voter_Login.Name = "label_Voter_Login";
            this.label_Voter_Login.Size = new System.Drawing.Size(149, 24);
            this.label_Voter_Login.TabIndex = 20;
            this.label_Voter_Login.Text = "VOTER LOGIN";
            // 
            // button_VoterLogin
            // 
            this.button_VoterLogin.BackColor = System.Drawing.Color.White;
            this.button_VoterLogin.FlatAppearance.BorderSize = 0;
            this.button_VoterLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_VoterLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_VoterLogin.ForeColor = System.Drawing.Color.Maroon;
            this.button_VoterLogin.Location = new System.Drawing.Point(614, 345);
            this.button_VoterLogin.Name = "button_VoterLogin";
            this.button_VoterLogin.Size = new System.Drawing.Size(75, 23);
            this.button_VoterLogin.TabIndex = 19;
            this.button_VoterLogin.Text = "LOG IN";
            this.button_VoterLogin.UseVisualStyleBackColor = false;
            this.button_VoterLogin.Click += new System.EventHandler(this.button_VoterLogin_Click);
            // 
            // textBox_VOTER_LOGIN_PASSWORD
            // 
            this.textBox_VOTER_LOGIN_PASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VOTER_LOGIN_PASSWORD.Location = new System.Drawing.Point(398, 290);
            this.textBox_VOTER_LOGIN_PASSWORD.MaxLength = 8;
            this.textBox_VOTER_LOGIN_PASSWORD.Name = "textBox_VOTER_LOGIN_PASSWORD";
            this.textBox_VOTER_LOGIN_PASSWORD.Size = new System.Drawing.Size(309, 22);
            this.textBox_VOTER_LOGIN_PASSWORD.TabIndex = 18;
            // 
            // textBox_VOTER_LOGIN_CNIC
            // 
            this.textBox_VOTER_LOGIN_CNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VOTER_LOGIN_CNIC.Location = new System.Drawing.Point(398, 198);
            this.textBox_VOTER_LOGIN_CNIC.MaxLength = 13;
            this.textBox_VOTER_LOGIN_CNIC.Name = "textBox_VOTER_LOGIN_CNIC";
            this.textBox_VOTER_LOGIN_CNIC.Size = new System.Drawing.Size(309, 22);
            this.textBox_VOTER_LOGIN_CNIC.TabIndex = 17;
            // 
            // label_Admin_Password
            // 
            this.label_Admin_Password.AutoSize = true;
            this.label_Admin_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Admin_Password.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_Admin_Password.Location = new System.Drawing.Point(275, 293);
            this.label_Admin_Password.Name = "label_Admin_Password";
            this.label_Admin_Password.Size = new System.Drawing.Size(80, 16);
            this.label_Admin_Password.TabIndex = 16;
            this.label_Admin_Password.Text = "Password:";
            // 
            // label_admin_Username
            // 
            this.label_admin_Username.AutoSize = true;
            this.label_admin_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_admin_Username.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_admin_Username.Location = new System.Drawing.Point(308, 204);
            this.label_admin_Username.Name = "label_admin_Username";
            this.label_admin_Username.Size = new System.Drawing.Size(47, 16);
            this.label_admin_Username.TabIndex = 15;
            this.label_admin_Username.Text = "CNIC:";
            // 
            // label_voter_login_CNIC_error_label
            // 
            this.label_voter_login_CNIC_error_label.AutoSize = true;
            this.label_voter_login_CNIC_error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_voter_login_CNIC_error_label.ForeColor = System.Drawing.Color.Red;
            this.label_voter_login_CNIC_error_label.Location = new System.Drawing.Point(404, 223);
            this.label_voter_login_CNIC_error_label.Name = "label_voter_login_CNIC_error_label";
            this.label_voter_login_CNIC_error_label.Size = new System.Drawing.Size(143, 16);
            this.label_voter_login_CNIC_error_label.TabIndex = 22;
            this.label_voter_login_CNIC_error_label.Text = "CNIC is not Registered";
            this.label_voter_login_CNIC_error_label.Visible = false;
            // 
            // errorProvider_voterlogin
            // 
            this.errorProvider_voterlogin.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E_Election_Project.Properties.Resources.download__1_;
            this.pictureBox1.Location = new System.Drawing.Point(24, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label__voter_login_Pass_error_label
            // 
            this.label__voter_login_Pass_error_label.AutoSize = true;
            this.label__voter_login_Pass_error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label__voter_login_Pass_error_label.ForeColor = System.Drawing.Color.Red;
            this.label__voter_login_Pass_error_label.Location = new System.Drawing.Point(404, 315);
            this.label__voter_login_Pass_error_label.Name = "label__voter_login_Pass_error_label";
            this.label__voter_login_Pass_error_label.Size = new System.Drawing.Size(122, 16);
            this.label__voter_login_Pass_error_label.TabIndex = 24;
            this.label__voter_login_Pass_error_label.Text = "Incorrect Password";
            this.label__voter_login_Pass_error_label.Visible = false;
            // 
            // VoterLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(731, 484);
            this.Controls.Add(this.label__voter_login_Pass_error_label);
            this.Controls.Add(this.label_voter_login_CNIC_error_label);
            this.Controls.Add(this.label_Voter_Login);
            this.Controls.Add(this.button_VoterLogin);
            this.Controls.Add(this.textBox_VOTER_LOGIN_PASSWORD);
            this.Controls.Add(this.textBox_VOTER_LOGIN_CNIC);
            this.Controls.Add(this.label_Admin_Password);
            this.Controls.Add(this.label_admin_Username);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VoterLogIn";
            this.Text = "VoterLogIn";
            this.Load += new System.EventHandler(this.VoterLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_voterlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Voter_Login;
        private System.Windows.Forms.Button button_VoterLogin;
        private System.Windows.Forms.TextBox textBox_VOTER_LOGIN_PASSWORD;
        private System.Windows.Forms.TextBox textBox_VOTER_LOGIN_CNIC;
        private System.Windows.Forms.Label label_Admin_Password;
        private System.Windows.Forms.Label label_admin_Username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_voter_login_CNIC_error_label;
        private System.Windows.Forms.ErrorProvider errorProvider_voterlogin;
        private System.Windows.Forms.Label label__voter_login_Pass_error_label;
    }
}