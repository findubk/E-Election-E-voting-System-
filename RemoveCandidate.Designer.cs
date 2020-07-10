namespace E_Election_Project
{
    partial class RemoveCandidate
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
            this.label_Candidatelist = new System.Windows.Forms.Label();
            this.button_Remove_Candidate_Search = new System.Windows.Forms.Button();
            this.textBox_Remove_Candidate_Constituency = new System.Windows.Forms.TextBox();
            this.comboBox_Remove_Candidate = new System.Windows.Forms.ComboBox();
            this.label_Remove_Candidate_Constituency = new System.Windows.Forms.Label();
            this.button_AllCandidateList_Remove_Candidate = new System.Windows.Forms.Button();
            this.label_Remove_Candidate = new System.Windows.Forms.Label();
            this.dataGridView_Candidate_Romove = new System.Windows.Forms.DataGridView();
            this.errorProvider_CandidateRemove = new System.Windows.Forms.ErrorProvider(this.components);
            this.label__Candidate_Remove_inst = new System.Windows.Forms.Label();
            this.button_Delete_Row_Candidate_Remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Candidate_Romove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_CandidateRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Candidatelist
            // 
            this.label_Candidatelist.AutoSize = true;
            this.label_Candidatelist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Candidatelist.Location = new System.Drawing.Point(181, 86);
            this.label_Candidatelist.Name = "label_Candidatelist";
            this.label_Candidatelist.Size = new System.Drawing.Size(183, 13);
            this.label_Candidatelist.TabIndex = 95;
            this.label_Candidatelist.Text = "Exp: NA-125,PP-10,PS-125,GBLA-25";
            // 
            // button_Remove_Candidate_Search
            // 
            this.button_Remove_Candidate_Search.BackColor = System.Drawing.Color.White;
            this.button_Remove_Candidate_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Remove_Candidate_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Remove_Candidate_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.button_Remove_Candidate_Search.Location = new System.Drawing.Point(425, 52);
            this.button_Remove_Candidate_Search.Name = "button_Remove_Candidate_Search";
            this.button_Remove_Candidate_Search.Size = new System.Drawing.Size(87, 37);
            this.button_Remove_Candidate_Search.TabIndex = 94;
            this.button_Remove_Candidate_Search.Text = "Search";
            this.button_Remove_Candidate_Search.UseVisualStyleBackColor = false;
            this.button_Remove_Candidate_Search.Click += new System.EventHandler(this.button_Remove_Candidate_Search_Click);
            // 
            // textBox_Remove_Candidate_Constituency
            // 
            this.textBox_Remove_Candidate_Constituency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Remove_Candidate_Constituency.Location = new System.Drawing.Point(257, 58);
            this.textBox_Remove_Candidate_Constituency.Name = "textBox_Remove_Candidate_Constituency";
            this.textBox_Remove_Candidate_Constituency.Size = new System.Drawing.Size(131, 22);
            this.textBox_Remove_Candidate_Constituency.TabIndex = 93;
            // 
            // comboBox_Remove_Candidate
            // 
            this.comboBox_Remove_Candidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Remove_Candidate.FormattingEnabled = true;
            this.comboBox_Remove_Candidate.Items.AddRange(new object[] {
            "NA",
            "PP",
            "PS",
            "PB",
            "PK",
            "GBLA"});
            this.comboBox_Remove_Candidate.Location = new System.Drawing.Point(149, 59);
            this.comboBox_Remove_Candidate.Name = "comboBox_Remove_Candidate";
            this.comboBox_Remove_Candidate.Size = new System.Drawing.Size(78, 21);
            this.comboBox_Remove_Candidate.TabIndex = 92;
            this.comboBox_Remove_Candidate.Text = "Select";
            // 
            // label_Remove_Candidate_Constituency
            // 
            this.label_Remove_Candidate_Constituency.AutoSize = true;
            this.label_Remove_Candidate_Constituency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Remove_Candidate_Constituency.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_Remove_Candidate_Constituency.Location = new System.Drawing.Point(30, 60);
            this.label_Remove_Candidate_Constituency.Name = "label_Remove_Candidate_Constituency";
            this.label_Remove_Candidate_Constituency.Size = new System.Drawing.Size(100, 16);
            this.label_Remove_Candidate_Constituency.TabIndex = 91;
            this.label_Remove_Candidate_Constituency.Text = "Constituency:";
            // 
            // button_AllCandidateList_Remove_Candidate
            // 
            this.button_AllCandidateList_Remove_Candidate.BackColor = System.Drawing.Color.White;
            this.button_AllCandidateList_Remove_Candidate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_AllCandidateList_Remove_Candidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AllCandidateList_Remove_Candidate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.button_AllCandidateList_Remove_Candidate.Location = new System.Drawing.Point(620, 52);
            this.button_AllCandidateList_Remove_Candidate.Name = "button_AllCandidateList_Remove_Candidate";
            this.button_AllCandidateList_Remove_Candidate.Size = new System.Drawing.Size(87, 38);
            this.button_AllCandidateList_Remove_Candidate.TabIndex = 90;
            this.button_AllCandidateList_Remove_Candidate.Text = "All Candidates";
            this.button_AllCandidateList_Remove_Candidate.UseVisualStyleBackColor = false;
            this.button_AllCandidateList_Remove_Candidate.Click += new System.EventHandler(this.button_AllCandidateList_Remove_Candidate_Click);
            // 
            // label_Remove_Candidate
            // 
            this.label_Remove_Candidate.AutoSize = true;
            this.label_Remove_Candidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Remove_Candidate.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_Remove_Candidate.Location = new System.Drawing.Point(285, 10);
            this.label_Remove_Candidate.Name = "label_Remove_Candidate";
            this.label_Remove_Candidate.Size = new System.Drawing.Size(211, 25);
            this.label_Remove_Candidate.TabIndex = 89;
            this.label_Remove_Candidate.Text = "Remove Candidate";
            // 
            // dataGridView_Candidate_Romove
            // 
            this.dataGridView_Candidate_Romove.AllowUserToAddRows = false;
            this.dataGridView_Candidate_Romove.AllowUserToDeleteRows = false;
            this.dataGridView_Candidate_Romove.AllowUserToResizeColumns = false;
            this.dataGridView_Candidate_Romove.AllowUserToResizeRows = false;
            this.dataGridView_Candidate_Romove.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Candidate_Romove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Candidate_Romove.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.dataGridView_Candidate_Romove.Location = new System.Drawing.Point(12, 102);
            this.dataGridView_Candidate_Romove.Name = "dataGridView_Candidate_Romove";
            this.dataGridView_Candidate_Romove.ReadOnly = true;
            this.dataGridView_Candidate_Romove.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Candidate_Romove.Size = new System.Drawing.Size(705, 305);
            this.dataGridView_Candidate_Romove.TabIndex = 88;
            this.dataGridView_Candidate_Romove.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Candidate_Romove_CellMouseClick);
            // 
            // errorProvider_CandidateRemove
            // 
            this.errorProvider_CandidateRemove.ContainerControl = this;
            // 
            // label__Candidate_Remove_inst
            // 
            this.label__Candidate_Remove_inst.AutoSize = true;
            this.label__Candidate_Remove_inst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label__Candidate_Remove_inst.ForeColor = System.Drawing.Color.Gainsboro;
            this.label__Candidate_Remove_inst.Location = new System.Drawing.Point(12, 424);
            this.label__Candidate_Remove_inst.Name = "label__Candidate_Remove_inst";
            this.label__Candidate_Remove_inst.Size = new System.Drawing.Size(415, 16);
            this.label__Candidate_Remove_inst.TabIndex = 96;
            this.label__Candidate_Remove_inst.Text = "*CLick on Row you want to select and press \"Delete\" button";
            // 
            // button_Delete_Row_Candidate_Remove
            // 
            this.button_Delete_Row_Candidate_Remove.BackColor = System.Drawing.Color.White;
            this.button_Delete_Row_Candidate_Remove.Enabled = false;
            this.button_Delete_Row_Candidate_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete_Row_Candidate_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete_Row_Candidate_Remove.ForeColor = System.Drawing.Color.Black;
            this.button_Delete_Row_Candidate_Remove.Location = new System.Drawing.Point(604, 419);
            this.button_Delete_Row_Candidate_Remove.Name = "button_Delete_Row_Candidate_Remove";
            this.button_Delete_Row_Candidate_Remove.Size = new System.Drawing.Size(103, 27);
            this.button_Delete_Row_Candidate_Remove.TabIndex = 97;
            this.button_Delete_Row_Candidate_Remove.Text = "Delete";
            this.button_Delete_Row_Candidate_Remove.UseVisualStyleBackColor = false;
            this.button_Delete_Row_Candidate_Remove.Click += new System.EventHandler(this.button_Delete_Row_Candidate_Remove_Click);
            // 
            // RemoveCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(729, 461);
            this.Controls.Add(this.button_Delete_Row_Candidate_Remove);
            this.Controls.Add(this.label__Candidate_Remove_inst);
            this.Controls.Add(this.label_Candidatelist);
            this.Controls.Add(this.button_Remove_Candidate_Search);
            this.Controls.Add(this.textBox_Remove_Candidate_Constituency);
            this.Controls.Add(this.comboBox_Remove_Candidate);
            this.Controls.Add(this.label_Remove_Candidate_Constituency);
            this.Controls.Add(this.button_AllCandidateList_Remove_Candidate);
            this.Controls.Add(this.label_Remove_Candidate);
            this.Controls.Add(this.dataGridView_Candidate_Romove);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "RemoveCandidate";
            this.Text = "RemoveCandidate";
            this.Load += new System.EventHandler(this.RemoveCandidate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Candidate_Romove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_CandidateRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Candidatelist;
        private System.Windows.Forms.Button button_Remove_Candidate_Search;
        private System.Windows.Forms.TextBox textBox_Remove_Candidate_Constituency;
        private System.Windows.Forms.ComboBox comboBox_Remove_Candidate;
        private System.Windows.Forms.Label label_Remove_Candidate_Constituency;
        private System.Windows.Forms.Button button_AllCandidateList_Remove_Candidate;
        private System.Windows.Forms.Label label_Remove_Candidate;
        private System.Windows.Forms.DataGridView dataGridView_Candidate_Romove;
        private System.Windows.Forms.ErrorProvider errorProvider_CandidateRemove;
        private System.Windows.Forms.Label label__Candidate_Remove_inst;
        private System.Windows.Forms.Button button_Delete_Row_Candidate_Remove;
    }
}