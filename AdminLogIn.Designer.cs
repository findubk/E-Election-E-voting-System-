namespace E_Election_Project
{
    partial class AdminLogIn
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
            this.label_admin_head = new System.Windows.Forms.Label();
            this.button_adminLogin = new System.Windows.Forms.Button();
            this.textBox_adminPassword = new System.Windows.Forms.TextBox();
            this.textBox_adminUsername = new System.Windows.Forms.TextBox();
            this.label_Admin_Password = new System.Windows.Forms.Label();
            this.label_admin_Username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_admin_head
            // 
            this.label_admin_head.AutoSize = true;
            this.label_admin_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_admin_head.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_admin_head.Location = new System.Drawing.Point(289, 64);
            this.label_admin_head.Name = "label_admin_head";
            this.label_admin_head.Size = new System.Drawing.Size(132, 24);
            this.label_admin_head.TabIndex = 13;
            this.label_admin_head.Text = "Administrator";
            // 
            // button_adminLogin
            // 
            this.button_adminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_adminLogin.Location = new System.Drawing.Point(613, 314);
            this.button_adminLogin.Name = "button_adminLogin";
            this.button_adminLogin.Size = new System.Drawing.Size(75, 23);
            this.button_adminLogin.TabIndex = 12;
            this.button_adminLogin.Text = "LOG IN";
            this.button_adminLogin.UseVisualStyleBackColor = true;
            this.button_adminLogin.Click += new System.EventHandler(this.button_adminLogin_Click);
            // 
            // textBox_adminPassword
            // 
            this.textBox_adminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_adminPassword.Location = new System.Drawing.Point(397, 259);
            this.textBox_adminPassword.Name = "textBox_adminPassword";
            this.textBox_adminPassword.Size = new System.Drawing.Size(309, 22);
            this.textBox_adminPassword.TabIndex = 11;
            // 
            // textBox_adminUsername
            // 
            this.textBox_adminUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_adminUsername.Location = new System.Drawing.Point(397, 167);
            this.textBox_adminUsername.Name = "textBox_adminUsername";
            this.textBox_adminUsername.Size = new System.Drawing.Size(309, 22);
            this.textBox_adminUsername.TabIndex = 10;
            // 
            // label_Admin_Password
            // 
            this.label_Admin_Password.AutoSize = true;
            this.label_Admin_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Admin_Password.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_Admin_Password.Location = new System.Drawing.Point(274, 262);
            this.label_Admin_Password.Name = "label_Admin_Password";
            this.label_Admin_Password.Size = new System.Drawing.Size(80, 16);
            this.label_Admin_Password.TabIndex = 9;
            this.label_Admin_Password.Text = "Password:";
            // 
            // label_admin_Username
            // 
            this.label_admin_Username.AutoSize = true;
            this.label_admin_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_admin_Username.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_admin_Username.Location = new System.Drawing.Point(271, 170);
            this.label_admin_Username.Name = "label_admin_Username";
            this.label_admin_Username.Size = new System.Drawing.Size(83, 16);
            this.label_admin_Username.TabIndex = 8;
            this.label_admin_Username.Text = "Username:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E_Election_Project.Properties.Resources.download__1_;
            this.pictureBox1.Location = new System.Drawing.Point(23, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // AdminLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(731, 484);
            this.Controls.Add(this.label_admin_head);
            this.Controls.Add(this.button_adminLogin);
            this.Controls.Add(this.textBox_adminPassword);
            this.Controls.Add(this.textBox_adminUsername);
            this.Controls.Add(this.label_Admin_Password);
            this.Controls.Add(this.label_admin_Username);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(747, 523);
            this.Name = "AdminLogIn";
            this.Text = "AdminLogIn";
            this.Load += new System.EventHandler(this.AdminLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_admin_head;
        private System.Windows.Forms.Button button_adminLogin;
        private System.Windows.Forms.TextBox textBox_adminPassword;
        private System.Windows.Forms.TextBox textBox_adminUsername;
        private System.Windows.Forms.Label label_Admin_Password;
        private System.Windows.Forms.Label label_admin_Username;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}