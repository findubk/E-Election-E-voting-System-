namespace E_Election_Project
{
    partial class RemoveVoter
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
            this.dataGridView_Voter_Romove = new System.Windows.Forms.DataGridView();
            this.label_Voter_RemoveCnic = new System.Windows.Forms.Label();
            this.textBox_CNIC_VOTER_REMOVE = new System.Windows.Forms.TextBox();
            this.button_Search_voter_remove = new System.Windows.Forms.Button();
            this.button_All_LIst_VOTER_REMOVE = new System.Windows.Forms.Button();
            this.button_Pending_Eligible_List_VOTER_REMOVE = new System.Windows.Forms.Button();
            this.button_Eligible_List_VOTER_REMOVE = new System.Windows.Forms.Button();
            this.button_inEligible_List_VOTER_REMOVE = new System.Windows.Forms.Button();
            this.button_Delete_Row_VOTER_REMOVE = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider_Voter_Remove = new System.Windows.Forms.ErrorProvider(this.components);
            this.label_Voter_Remove_No_Record = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Voter_Romove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Voter_Remove)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remove Voter";
            // 
            // dataGridView_Voter_Romove
            // 
            this.dataGridView_Voter_Romove.AllowUserToAddRows = false;
            this.dataGridView_Voter_Romove.AllowUserToDeleteRows = false;
            this.dataGridView_Voter_Romove.AllowUserToResizeColumns = false;
            this.dataGridView_Voter_Romove.AllowUserToResizeRows = false;
            this.dataGridView_Voter_Romove.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Voter_Romove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Voter_Romove.Cursor = System.Windows.Forms.Cursors.No;
            this.dataGridView_Voter_Romove.GridColor = System.Drawing.Color.Black;
            this.dataGridView_Voter_Romove.Location = new System.Drawing.Point(12, 143);
            this.dataGridView_Voter_Romove.Name = "dataGridView_Voter_Romove";
            this.dataGridView_Voter_Romove.ReadOnly = true;
            this.dataGridView_Voter_Romove.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Voter_Romove.Size = new System.Drawing.Size(705, 233);
            this.dataGridView_Voter_Romove.TabIndex = 5;
            this.dataGridView_Voter_Romove.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Voter_Romove_CellMouseClick);
            // 
            // label_Voter_RemoveCnic
            // 
            this.label_Voter_RemoveCnic.AutoSize = true;
            this.label_Voter_RemoveCnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Voter_RemoveCnic.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_Voter_RemoveCnic.Location = new System.Drawing.Point(36, 57);
            this.label_Voter_RemoveCnic.Name = "label_Voter_RemoveCnic";
            this.label_Voter_RemoveCnic.Size = new System.Drawing.Size(47, 16);
            this.label_Voter_RemoveCnic.TabIndex = 6;
            this.label_Voter_RemoveCnic.Text = "CNIC:";
            // 
            // textBox_CNIC_VOTER_REMOVE
            // 
            this.textBox_CNIC_VOTER_REMOVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CNIC_VOTER_REMOVE.Location = new System.Drawing.Point(94, 51);
            this.textBox_CNIC_VOTER_REMOVE.Name = "textBox_CNIC_VOTER_REMOVE";
            this.textBox_CNIC_VOTER_REMOVE.Size = new System.Drawing.Size(210, 22);
            this.textBox_CNIC_VOTER_REMOVE.TabIndex = 7;
            // 
            // button_Search_voter_remove
            // 
            this.button_Search_voter_remove.BackColor = System.Drawing.Color.White;
            this.button_Search_voter_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search_voter_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search_voter_remove.ForeColor = System.Drawing.Color.Black;
            this.button_Search_voter_remove.Location = new System.Drawing.Point(183, 88);
            this.button_Search_voter_remove.Name = "button_Search_voter_remove";
            this.button_Search_voter_remove.Size = new System.Drawing.Size(103, 27);
            this.button_Search_voter_remove.TabIndex = 8;
            this.button_Search_voter_remove.Text = "Search";
            this.button_Search_voter_remove.UseVisualStyleBackColor = false;
            this.button_Search_voter_remove.Click += new System.EventHandler(this.button_Search_voter_remove_Click);
            // 
            // button_All_LIst_VOTER_REMOVE
            // 
            this.button_All_LIst_VOTER_REMOVE.BackColor = System.Drawing.Color.White;
            this.button_All_LIst_VOTER_REMOVE.FlatAppearance.BorderSize = 0;
            this.button_All_LIst_VOTER_REMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_All_LIst_VOTER_REMOVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_All_LIst_VOTER_REMOVE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_All_LIst_VOTER_REMOVE.Location = new System.Drawing.Point(429, 46);
            this.button_All_LIst_VOTER_REMOVE.Name = "button_All_LIst_VOTER_REMOVE";
            this.button_All_LIst_VOTER_REMOVE.Size = new System.Drawing.Size(100, 40);
            this.button_All_LIst_VOTER_REMOVE.TabIndex = 9;
            this.button_All_LIst_VOTER_REMOVE.Text = "All Voters";
            this.button_All_LIst_VOTER_REMOVE.UseVisualStyleBackColor = false;
            this.button_All_LIst_VOTER_REMOVE.Click += new System.EventHandler(this.button_All_LIst_VOTER_REMOVE_Click);
            // 
            // button_Pending_Eligible_List_VOTER_REMOVE
            // 
            this.button_Pending_Eligible_List_VOTER_REMOVE.BackColor = System.Drawing.Color.White;
            this.button_Pending_Eligible_List_VOTER_REMOVE.FlatAppearance.BorderSize = 0;
            this.button_Pending_Eligible_List_VOTER_REMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Pending_Eligible_List_VOTER_REMOVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Pending_Eligible_List_VOTER_REMOVE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_Pending_Eligible_List_VOTER_REMOVE.Location = new System.Drawing.Point(592, 95);
            this.button_Pending_Eligible_List_VOTER_REMOVE.Name = "button_Pending_Eligible_List_VOTER_REMOVE";
            this.button_Pending_Eligible_List_VOTER_REMOVE.Size = new System.Drawing.Size(100, 40);
            this.button_Pending_Eligible_List_VOTER_REMOVE.TabIndex = 10;
            this.button_Pending_Eligible_List_VOTER_REMOVE.Text = "Pending ";
            this.button_Pending_Eligible_List_VOTER_REMOVE.UseVisualStyleBackColor = false;
            this.button_Pending_Eligible_List_VOTER_REMOVE.Click += new System.EventHandler(this.button_Pending_Eligible_List_VOTER_REMOVE_Click);
            // 
            // button_Eligible_List_VOTER_REMOVE
            // 
            this.button_Eligible_List_VOTER_REMOVE.BackColor = System.Drawing.Color.White;
            this.button_Eligible_List_VOTER_REMOVE.FlatAppearance.BorderSize = 0;
            this.button_Eligible_List_VOTER_REMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Eligible_List_VOTER_REMOVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Eligible_List_VOTER_REMOVE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_Eligible_List_VOTER_REMOVE.Location = new System.Drawing.Point(592, 46);
            this.button_Eligible_List_VOTER_REMOVE.Name = "button_Eligible_List_VOTER_REMOVE";
            this.button_Eligible_List_VOTER_REMOVE.Size = new System.Drawing.Size(100, 40);
            this.button_Eligible_List_VOTER_REMOVE.TabIndex = 11;
            this.button_Eligible_List_VOTER_REMOVE.Text = "Eligible Voters";
            this.button_Eligible_List_VOTER_REMOVE.UseVisualStyleBackColor = false;
            this.button_Eligible_List_VOTER_REMOVE.Click += new System.EventHandler(this.button_Eligible_List_VOTER_REMOVE_Click);
            // 
            // button_inEligible_List_VOTER_REMOVE
            // 
            this.button_inEligible_List_VOTER_REMOVE.BackColor = System.Drawing.Color.White;
            this.button_inEligible_List_VOTER_REMOVE.FlatAppearance.BorderSize = 0;
            this.button_inEligible_List_VOTER_REMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_inEligible_List_VOTER_REMOVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_inEligible_List_VOTER_REMOVE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_inEligible_List_VOTER_REMOVE.Location = new System.Drawing.Point(429, 95);
            this.button_inEligible_List_VOTER_REMOVE.Name = "button_inEligible_List_VOTER_REMOVE";
            this.button_inEligible_List_VOTER_REMOVE.Size = new System.Drawing.Size(100, 40);
            this.button_inEligible_List_VOTER_REMOVE.TabIndex = 12;
            this.button_inEligible_List_VOTER_REMOVE.Text = "InEligible Voters";
            this.button_inEligible_List_VOTER_REMOVE.UseVisualStyleBackColor = false;
            this.button_inEligible_List_VOTER_REMOVE.Click += new System.EventHandler(this.button_inEligible_List_VOTER_REMOVE_Click);
            // 
            // button_Delete_Row_VOTER_REMOVE
            // 
            this.button_Delete_Row_VOTER_REMOVE.BackColor = System.Drawing.Color.White;
            this.button_Delete_Row_VOTER_REMOVE.Enabled = false;
            this.button_Delete_Row_VOTER_REMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete_Row_VOTER_REMOVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete_Row_VOTER_REMOVE.ForeColor = System.Drawing.Color.Black;
            this.button_Delete_Row_VOTER_REMOVE.Location = new System.Drawing.Point(596, 382);
            this.button_Delete_Row_VOTER_REMOVE.Name = "button_Delete_Row_VOTER_REMOVE";
            this.button_Delete_Row_VOTER_REMOVE.Size = new System.Drawing.Size(103, 27);
            this.button_Delete_Row_VOTER_REMOVE.TabIndex = 13;
            this.button_Delete_Row_VOTER_REMOVE.Text = "Delete";
            this.button_Delete_Row_VOTER_REMOVE.UseVisualStyleBackColor = false;
            this.button_Delete_Row_VOTER_REMOVE.Click += new System.EventHandler(this.button_Delete_Row_VOTER_REMOVE_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(14, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "*CLick on Row you want to select and press \"Delete\" button";
            // 
            // errorProvider_Voter_Remove
            // 
            this.errorProvider_Voter_Remove.ContainerControl = this;
            // 
            // label_Voter_Remove_No_Record
            // 
            this.label_Voter_Remove_No_Record.AutoSize = true;
            this.label_Voter_Remove_No_Record.BackColor = System.Drawing.Color.White;
            this.label_Voter_Remove_No_Record.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Voter_Remove_No_Record.Location = new System.Drawing.Point(272, 177);
            this.label_Voter_Remove_No_Record.Name = "label_Voter_Remove_No_Record";
            this.label_Voter_Remove_No_Record.Size = new System.Drawing.Size(155, 20);
            this.label_Voter_Remove_No_Record.TabIndex = 15;
            this.label_Voter_Remove_No_Record.Text = "No Record Found!";
            this.label_Voter_Remove_No_Record.Visible = false;
            // 
            // RemoveVoter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(729, 421);
            this.Controls.Add(this.label_Voter_Remove_No_Record);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Delete_Row_VOTER_REMOVE);
            this.Controls.Add(this.button_inEligible_List_VOTER_REMOVE);
            this.Controls.Add(this.button_Eligible_List_VOTER_REMOVE);
            this.Controls.Add(this.button_Pending_Eligible_List_VOTER_REMOVE);
            this.Controls.Add(this.button_All_LIst_VOTER_REMOVE);
            this.Controls.Add(this.button_Search_voter_remove);
            this.Controls.Add(this.textBox_CNIC_VOTER_REMOVE);
            this.Controls.Add(this.label_Voter_RemoveCnic);
            this.Controls.Add(this.dataGridView_Voter_Romove);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "RemoveVoter";
            this.Text = "RemoveVoter";
            this.Load += new System.EventHandler(this.RemoveVoter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Voter_Romove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Voter_Remove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Voter_Romove;
        private System.Windows.Forms.Label label_Voter_RemoveCnic;
        private System.Windows.Forms.TextBox textBox_CNIC_VOTER_REMOVE;
        private System.Windows.Forms.Button button_Search_voter_remove;
        private System.Windows.Forms.Button button_All_LIst_VOTER_REMOVE;
        private System.Windows.Forms.Button button_Pending_Eligible_List_VOTER_REMOVE;
        private System.Windows.Forms.Button button_Eligible_List_VOTER_REMOVE;
        private System.Windows.Forms.Button button_inEligible_List_VOTER_REMOVE;
        private System.Windows.Forms.Button button_Delete_Row_VOTER_REMOVE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider_Voter_Remove;
        private System.Windows.Forms.Label label_Voter_Remove_No_Record;
    }
}