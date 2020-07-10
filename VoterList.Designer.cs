namespace E_Election_Project
{
    partial class VoterList
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_ELigible_List = new System.Windows.Forms.Button();
            this.button_InELigible_List = new System.Windows.Forms.Button();
            this.button_Pending_VoterList = new System.Windows.Forms.Button();
            this.dataGridView_Voter_List = new System.Windows.Forms.DataGridView();
            this.button_rtcReg_Alllist = new System.Windows.Forms.Button();
            this.button_Search_voter_List = new System.Windows.Forms.Button();
            this.textBox_CNIC_VOTER_List = new System.Windows.Forms.TextBox();
            this.label_Voter_RemoveCnic = new System.Windows.Forms.Label();
            this.errorProvider_Voter_List = new System.Windows.Forms.ErrorProvider(this.components);
            this.label_Voter_list_No_Record = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Voter_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Voter_List)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voters Lists";
            // 
            // button_ELigible_List
            // 
            this.button_ELigible_List.BackColor = System.Drawing.Color.White;
            this.button_ELigible_List.FlatAppearance.BorderSize = 0;
            this.button_ELigible_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ELigible_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ELigible_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_ELigible_List.Location = new System.Drawing.Point(429, 95);
            this.button_ELigible_List.Name = "button_ELigible_List";
            this.button_ELigible_List.Size = new System.Drawing.Size(100, 40);
            this.button_ELigible_List.TabIndex = 1;
            this.button_ELigible_List.Text = "Eligible Voters";
            this.button_ELigible_List.UseVisualStyleBackColor = false;
            this.button_ELigible_List.Click += new System.EventHandler(this.button_ELigible_List_Click);
            // 
            // button_InELigible_List
            // 
            this.button_InELigible_List.BackColor = System.Drawing.Color.White;
            this.button_InELigible_List.FlatAppearance.BorderSize = 0;
            this.button_InELigible_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_InELigible_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_InELigible_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_InELigible_List.Location = new System.Drawing.Point(592, 95);
            this.button_InELigible_List.Name = "button_InELigible_List";
            this.button_InELigible_List.Size = new System.Drawing.Size(100, 40);
            this.button_InELigible_List.TabIndex = 2;
            this.button_InELigible_List.Text = "Ineligible Voters";
            this.button_InELigible_List.UseVisualStyleBackColor = false;
            this.button_InELigible_List.Click += new System.EventHandler(this.button_InELigible_List_Click);
            // 
            // button_Pending_VoterList
            // 
            this.button_Pending_VoterList.BackColor = System.Drawing.Color.White;
            this.button_Pending_VoterList.FlatAppearance.BorderSize = 0;
            this.button_Pending_VoterList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Pending_VoterList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Pending_VoterList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_Pending_VoterList.Location = new System.Drawing.Point(592, 46);
            this.button_Pending_VoterList.Name = "button_Pending_VoterList";
            this.button_Pending_VoterList.Size = new System.Drawing.Size(100, 40);
            this.button_Pending_VoterList.TabIndex = 3;
            this.button_Pending_VoterList.Text = "Pending Eligibility";
            this.button_Pending_VoterList.UseVisualStyleBackColor = false;
            this.button_Pending_VoterList.Click += new System.EventHandler(this.button_Pending_List_Click);
            // 
            // dataGridView_Voter_List
            // 
            this.dataGridView_Voter_List.AllowUserToAddRows = false;
            this.dataGridView_Voter_List.AllowUserToDeleteRows = false;
            this.dataGridView_Voter_List.AllowUserToResizeColumns = false;
            this.dataGridView_Voter_List.AllowUserToResizeRows = false;
            this.dataGridView_Voter_List.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Voter_List.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView_Voter_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Voter_List.Cursor = System.Windows.Forms.Cursors.No;
            this.dataGridView_Voter_List.GridColor = System.Drawing.Color.Black;
            this.dataGridView_Voter_List.Location = new System.Drawing.Point(12, 148);
            this.dataGridView_Voter_List.Name = "dataGridView_Voter_List";
            this.dataGridView_Voter_List.ReadOnly = true;
            this.dataGridView_Voter_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Voter_List.Size = new System.Drawing.Size(710, 301);
            this.dataGridView_Voter_List.TabIndex = 4;
            // 
            // button_rtcReg_Alllist
            // 
            this.button_rtcReg_Alllist.BackColor = System.Drawing.Color.White;
            this.button_rtcReg_Alllist.FlatAppearance.BorderSize = 0;
            this.button_rtcReg_Alllist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rtcReg_Alllist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rtcReg_Alllist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_rtcReg_Alllist.Location = new System.Drawing.Point(429, 46);
            this.button_rtcReg_Alllist.Name = "button_rtcReg_Alllist";
            this.button_rtcReg_Alllist.Size = new System.Drawing.Size(100, 40);
            this.button_rtcReg_Alllist.TabIndex = 5;
            this.button_rtcReg_Alllist.Text = "All Voters";
            this.button_rtcReg_Alllist.UseVisualStyleBackColor = false;
            this.button_rtcReg_Alllist.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Search_voter_List
            // 
            this.button_Search_voter_List.BackColor = System.Drawing.Color.White;
            this.button_Search_voter_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search_voter_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search_voter_List.Location = new System.Drawing.Point(189, 95);
            this.button_Search_voter_List.Name = "button_Search_voter_List";
            this.button_Search_voter_List.Size = new System.Drawing.Size(103, 27);
            this.button_Search_voter_List.TabIndex = 11;
            this.button_Search_voter_List.Text = "Search";
            this.button_Search_voter_List.UseVisualStyleBackColor = false;
            this.button_Search_voter_List.Click += new System.EventHandler(this.button_Search_voter_List_Click);
            // 
            // textBox_CNIC_VOTER_List
            // 
            this.textBox_CNIC_VOTER_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CNIC_VOTER_List.Location = new System.Drawing.Point(101, 54);
            this.textBox_CNIC_VOTER_List.MaxLength = 13;
            this.textBox_CNIC_VOTER_List.Name = "textBox_CNIC_VOTER_List";
            this.textBox_CNIC_VOTER_List.Size = new System.Drawing.Size(210, 22);
            this.textBox_CNIC_VOTER_List.TabIndex = 10;
            // 
            // label_Voter_RemoveCnic
            // 
            this.label_Voter_RemoveCnic.AutoSize = true;
            this.label_Voter_RemoveCnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Voter_RemoveCnic.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_Voter_RemoveCnic.Location = new System.Drawing.Point(48, 60);
            this.label_Voter_RemoveCnic.Name = "label_Voter_RemoveCnic";
            this.label_Voter_RemoveCnic.Size = new System.Drawing.Size(47, 16);
            this.label_Voter_RemoveCnic.TabIndex = 9;
            this.label_Voter_RemoveCnic.Text = "CNIC:";
            // 
            // errorProvider_Voter_List
            // 
            this.errorProvider_Voter_List.ContainerControl = this;
            // 
            // label_Voter_list_No_Record
            // 
            this.label_Voter_list_No_Record.AutoSize = true;
            this.label_Voter_list_No_Record.BackColor = System.Drawing.Color.White;
            this.label_Voter_list_No_Record.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Voter_list_No_Record.Location = new System.Drawing.Point(279, 176);
            this.label_Voter_list_No_Record.Name = "label_Voter_list_No_Record";
            this.label_Voter_list_No_Record.Size = new System.Drawing.Size(155, 20);
            this.label_Voter_list_No_Record.TabIndex = 12;
            this.label_Voter_list_No_Record.Text = "No Record Found!";
            this.label_Voter_list_No_Record.Visible = false;
            // 
            // VoterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.ControlBox = false;
            this.Controls.Add(this.label_Voter_list_No_Record);
            this.Controls.Add(this.button_Search_voter_List);
            this.Controls.Add(this.textBox_CNIC_VOTER_List);
            this.Controls.Add(this.label_Voter_RemoveCnic);
            this.Controls.Add(this.button_rtcReg_Alllist);
            this.Controls.Add(this.dataGridView_Voter_List);
            this.Controls.Add(this.button_Pending_VoterList);
            this.Controls.Add(this.button_InELigible_List);
            this.Controls.Add(this.button_ELigible_List);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VoterList";
            this.Text = "VoterList";
            this.Load += new System.EventHandler(this.VoterList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Voter_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Voter_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ELigible_List;
        private System.Windows.Forms.Button button_InELigible_List;
        private System.Windows.Forms.Button button_Pending_VoterList;
        private System.Windows.Forms.DataGridView dataGridView_Voter_List;
        private System.Windows.Forms.Button button_rtcReg_Alllist;
        private System.Windows.Forms.Button button_Search_voter_List;
        private System.Windows.Forms.TextBox textBox_CNIC_VOTER_List;
        private System.Windows.Forms.Label label_Voter_RemoveCnic;
        private System.Windows.Forms.ErrorProvider errorProvider_Voter_List;
        private System.Windows.Forms.Label label_Voter_list_No_Record;
    }
}