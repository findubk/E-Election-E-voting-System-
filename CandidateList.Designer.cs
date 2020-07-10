namespace E_Election_Project
{
    partial class CandidateList
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
            this.dataGridView_CandidateList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_AllCandidateList = new System.Windows.Forms.Button();
            this.label_CandidateListConstituency = new System.Windows.Forms.Label();
            this.comboBox_CandidateList = new System.Windows.Forms.ComboBox();
            this.textBox_CandidateListConstituency = new System.Windows.Forms.TextBox();
            this.button_candidateListSearch = new System.Windows.Forms.Button();
            this.label_Candidatelist = new System.Windows.Forms.Label();
            this.errorProvider_CandidateList = new System.Windows.Forms.ErrorProvider(this.components);
            this.label_CandidateList_No_Record = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CandidateList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_CandidateList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_CandidateList
            // 
            this.dataGridView_CandidateList.AllowUserToAddRows = false;
            this.dataGridView_CandidateList.AllowUserToDeleteRows = false;
            this.dataGridView_CandidateList.AllowUserToResizeColumns = false;
            this.dataGridView_CandidateList.AllowUserToResizeRows = false;
            this.dataGridView_CandidateList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_CandidateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CandidateList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.dataGridView_CandidateList.Location = new System.Drawing.Point(12, 101);
            this.dataGridView_CandidateList.Name = "dataGridView_CandidateList";
            this.dataGridView_CandidateList.Size = new System.Drawing.Size(705, 348);
            this.dataGridView_CandidateList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Candidate List";
            // 
            // button_AllCandidateList
            // 
            this.button_AllCandidateList.BackColor = System.Drawing.Color.White;
            this.button_AllCandidateList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_AllCandidateList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AllCandidateList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.button_AllCandidateList.Location = new System.Drawing.Point(620, 51);
            this.button_AllCandidateList.Name = "button_AllCandidateList";
            this.button_AllCandidateList.Size = new System.Drawing.Size(87, 38);
            this.button_AllCandidateList.TabIndex = 2;
            this.button_AllCandidateList.Text = "All Candidates";
            this.button_AllCandidateList.UseVisualStyleBackColor = false;
            this.button_AllCandidateList.Click += new System.EventHandler(this.button_AllCandidateList_Click);
            // 
            // label_CandidateListConstituency
            // 
            this.label_CandidateListConstituency.AutoSize = true;
            this.label_CandidateListConstituency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CandidateListConstituency.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_CandidateListConstituency.Location = new System.Drawing.Point(30, 59);
            this.label_CandidateListConstituency.Name = "label_CandidateListConstituency";
            this.label_CandidateListConstituency.Size = new System.Drawing.Size(100, 16);
            this.label_CandidateListConstituency.TabIndex = 3;
            this.label_CandidateListConstituency.Text = "Constituency:";
            // 
            // comboBox_CandidateList
            // 
            this.comboBox_CandidateList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_CandidateList.FormattingEnabled = true;
            this.comboBox_CandidateList.Items.AddRange(new object[] {
            "NA",
            "PP",
            "PS",
            "PB",
            "PK",
            "GBLA"});
            this.comboBox_CandidateList.Location = new System.Drawing.Point(149, 58);
            this.comboBox_CandidateList.Name = "comboBox_CandidateList";
            this.comboBox_CandidateList.Size = new System.Drawing.Size(78, 21);
            this.comboBox_CandidateList.TabIndex = 4;
            this.comboBox_CandidateList.Text = "Select";
            // 
            // textBox_CandidateListConstituency
            // 
            this.textBox_CandidateListConstituency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CandidateListConstituency.Location = new System.Drawing.Point(257, 57);
            this.textBox_CandidateListConstituency.Name = "textBox_CandidateListConstituency";
            this.textBox_CandidateListConstituency.Size = new System.Drawing.Size(131, 22);
            this.textBox_CandidateListConstituency.TabIndex = 5;
            // 
            // button_candidateListSearch
            // 
            this.button_candidateListSearch.BackColor = System.Drawing.Color.White;
            this.button_candidateListSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_candidateListSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_candidateListSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.button_candidateListSearch.Location = new System.Drawing.Point(425, 51);
            this.button_candidateListSearch.Name = "button_candidateListSearch";
            this.button_candidateListSearch.Size = new System.Drawing.Size(87, 37);
            this.button_candidateListSearch.TabIndex = 6;
            this.button_candidateListSearch.Text = "Search";
            this.button_candidateListSearch.UseVisualStyleBackColor = false;
            this.button_candidateListSearch.Click += new System.EventHandler(this.button_candidateListSearch_Click);
            // 
            // label_Candidatelist
            // 
            this.label_Candidatelist.AutoSize = true;
            this.label_Candidatelist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Candidatelist.Location = new System.Drawing.Point(181, 85);
            this.label_Candidatelist.Name = "label_Candidatelist";
            this.label_Candidatelist.Size = new System.Drawing.Size(183, 13);
            this.label_Candidatelist.TabIndex = 87;
            this.label_Candidatelist.Text = "Exp: NA-125,PP-10,PS-125,GBLA-25";
            // 
            // errorProvider_CandidateList
            // 
            this.errorProvider_CandidateList.ContainerControl = this;
            // 
            // label_CandidateList_No_Record
            // 
            this.label_CandidateList_No_Record.AutoSize = true;
            this.label_CandidateList_No_Record.BackColor = System.Drawing.Color.White;
            this.label_CandidateList_No_Record.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CandidateList_No_Record.ForeColor = System.Drawing.Color.Black;
            this.label_CandidateList_No_Record.Location = new System.Drawing.Point(276, 127);
            this.label_CandidateList_No_Record.Name = "label_CandidateList_No_Record";
            this.label_CandidateList_No_Record.Size = new System.Drawing.Size(155, 20);
            this.label_CandidateList_No_Record.TabIndex = 88;
            this.label_CandidateList_No_Record.Text = "No Record Found!";
            this.label_CandidateList_No_Record.Visible = false;
            // 
            // CandidateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(729, 461);
            this.Controls.Add(this.label_CandidateList_No_Record);
            this.Controls.Add(this.label_Candidatelist);
            this.Controls.Add(this.button_candidateListSearch);
            this.Controls.Add(this.textBox_CandidateListConstituency);
            this.Controls.Add(this.comboBox_CandidateList);
            this.Controls.Add(this.label_CandidateListConstituency);
            this.Controls.Add(this.button_AllCandidateList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_CandidateList);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CandidateList";
            this.Text = "Candidate Lists";
            this.Load += new System.EventHandler(this.CandidateList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CandidateList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_CandidateList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_CandidateList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AllCandidateList;
        private System.Windows.Forms.Label label_CandidateListConstituency;
        private System.Windows.Forms.ComboBox comboBox_CandidateList;
        private System.Windows.Forms.TextBox textBox_CandidateListConstituency;
        private System.Windows.Forms.Button button_candidateListSearch;
        private System.Windows.Forms.Label label_Candidatelist;
        private System.Windows.Forms.ErrorProvider errorProvider_CandidateList;
        private System.Windows.Forms.Label label_CandidateList_No_Record;
    }
}