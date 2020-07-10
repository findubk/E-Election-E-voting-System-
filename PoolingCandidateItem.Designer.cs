namespace E_Election_Project
{
    partial class PoolingCandidateItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_UC_Candidate_Name = new System.Windows.Forms.Label();
            this.label_UC_Candidate_Party = new System.Windows.Forms.Label();
            this.label_UC_Candidate_Consti = new System.Windows.Forms.Label();
            this.pictureBox_UC_Candidate_PIC = new System.Windows.Forms.PictureBox();
            this.button_UC_VOTE = new System.Windows.Forms.Button();
            this.panel_UC_PicBox = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UC_Candidate_PIC)).BeginInit();
            this.panel_UC_PicBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_UC_Candidate_Name
            // 
            this.label_UC_Candidate_Name.AutoSize = true;
            this.label_UC_Candidate_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UC_Candidate_Name.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_UC_Candidate_Name.Location = new System.Drawing.Point(153, 24);
            this.label_UC_Candidate_Name.Name = "label_UC_Candidate_Name";
            this.label_UC_Candidate_Name.Size = new System.Drawing.Size(0, 16);
            this.label_UC_Candidate_Name.TabIndex = 1;
            // 
            // label_UC_Candidate_Party
            // 
            this.label_UC_Candidate_Party.AutoSize = true;
            this.label_UC_Candidate_Party.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UC_Candidate_Party.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_UC_Candidate_Party.Location = new System.Drawing.Point(153, 54);
            this.label_UC_Candidate_Party.Name = "label_UC_Candidate_Party";
            this.label_UC_Candidate_Party.Size = new System.Drawing.Size(0, 16);
            this.label_UC_Candidate_Party.TabIndex = 2;
            // 
            // label_UC_Candidate_Consti
            // 
            this.label_UC_Candidate_Consti.AutoSize = true;
            this.label_UC_Candidate_Consti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UC_Candidate_Consti.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_UC_Candidate_Consti.Location = new System.Drawing.Point(153, 84);
            this.label_UC_Candidate_Consti.Name = "label_UC_Candidate_Consti";
            this.label_UC_Candidate_Consti.Size = new System.Drawing.Size(0, 16);
            this.label_UC_Candidate_Consti.TabIndex = 3;
            // 
            // pictureBox_UC_Candidate_PIC
            // 
            this.pictureBox_UC_Candidate_PIC.BackColor = System.Drawing.Color.White;
            this.pictureBox_UC_Candidate_PIC.Image = global::E_Election_Project.Properties.Resources._129_1298005_png_file_upload_image_icon_png;
            this.pictureBox_UC_Candidate_PIC.Location = new System.Drawing.Point(20, 14);
            this.pictureBox_UC_Candidate_PIC.Name = "pictureBox_UC_Candidate_PIC";
            this.pictureBox_UC_Candidate_PIC.Size = new System.Drawing.Size(89, 95);
            this.pictureBox_UC_Candidate_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_UC_Candidate_PIC.TabIndex = 0;
            this.pictureBox_UC_Candidate_PIC.TabStop = false;
            // 
            // button_UC_VOTE
            // 
            this.button_UC_VOTE.BackColor = System.Drawing.Color.White;
            this.button_UC_VOTE.FlatAppearance.BorderSize = 0;
            this.button_UC_VOTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UC_VOTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UC_VOTE.ForeColor = System.Drawing.Color.Maroon;
            this.button_UC_VOTE.Location = new System.Drawing.Point(385, 102);
            this.button_UC_VOTE.Name = "button_UC_VOTE";
            this.button_UC_VOTE.Size = new System.Drawing.Size(85, 20);
            this.button_UC_VOTE.TabIndex = 4;
            this.button_UC_VOTE.Text = "Vote";
            this.button_UC_VOTE.UseVisualStyleBackColor = false;
            this.button_UC_VOTE.Click += new System.EventHandler(this.button_UC_VOTE_Click);
            // 
            // panel_UC_PicBox
            // 
            this.panel_UC_PicBox.BackColor = System.Drawing.Color.White;
            this.panel_UC_PicBox.Controls.Add(this.pictureBox_UC_Candidate_PIC);
            this.panel_UC_PicBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_UC_PicBox.Location = new System.Drawing.Point(0, 0);
            this.panel_UC_PicBox.Name = "panel_UC_PicBox";
            this.panel_UC_PicBox.Size = new System.Drawing.Size(129, 125);
            this.panel_UC_PicBox.TabIndex = 5;
            // 
            // PoolingCandidateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel_UC_PicBox);
            this.Controls.Add(this.button_UC_VOTE);
            this.Controls.Add(this.label_UC_Candidate_Consti);
            this.Controls.Add(this.label_UC_Candidate_Party);
            this.Controls.Add(this.label_UC_Candidate_Name);
            this.Name = "PoolingCandidateItem";
            this.Size = new System.Drawing.Size(476, 125);
            this.Load += new System.EventHandler(this.PoolingCandidateItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UC_Candidate_PIC)).EndInit();
            this.panel_UC_PicBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_UC_Candidate_PIC;
        private System.Windows.Forms.Label label_UC_Candidate_Name;
        private System.Windows.Forms.Label label_UC_Candidate_Party;
        private System.Windows.Forms.Label label_UC_Candidate_Consti;
        private System.Windows.Forms.Button button_UC_VOTE;
        private System.Windows.Forms.Panel panel_UC_PicBox;
    }
}
