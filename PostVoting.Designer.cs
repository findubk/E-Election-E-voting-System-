namespace E_Election_Project
{
    partial class PostVoting
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
            this.label_postVoting_message = new System.Windows.Forms.Label();
            this.label_PostVoting_Ineleigible_message = new System.Windows.Forms.Label();
            this.label_POSTVOTING_RE_Vote_msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_postVoting_message
            // 
            this.label_postVoting_message.AutoSize = true;
            this.label_postVoting_message.BackColor = System.Drawing.Color.White;
            this.label_postVoting_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_postVoting_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_postVoting_message.Location = new System.Drawing.Point(65, 214);
            this.label_postVoting_message.Name = "label_postVoting_message";
            this.label_postVoting_message.Size = new System.Drawing.Size(371, 50);
            this.label_postVoting_message.TabIndex = 0;
            this.label_postVoting_message.Text = "               THANK YOU\r\nYOUR VOTE HAS BEEN CASTED!";
            this.label_postVoting_message.Visible = false;
            // 
            // label_PostVoting_Ineleigible_message
            // 
            this.label_PostVoting_Ineleigible_message.AutoSize = true;
            this.label_PostVoting_Ineleigible_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PostVoting_Ineleigible_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_PostVoting_Ineleigible_message.Location = new System.Drawing.Point(27, 214);
            this.label_PostVoting_Ineleigible_message.Name = "label_PostVoting_Ineleigible_message";
            this.label_PostVoting_Ineleigible_message.Size = new System.Drawing.Size(445, 50);
            this.label_PostVoting_Ineleigible_message.TabIndex = 1;
            this.label_PostVoting_Ineleigible_message.Text = "                       SORRY\r\nYOU ARE INELIGIBLE TO CAST A VOTE!";
            this.label_PostVoting_Ineleigible_message.Visible = false;
            // 
            // label_POSTVOTING_RE_Vote_msg
            // 
            this.label_POSTVOTING_RE_Vote_msg.AutoSize = true;
            this.label_POSTVOTING_RE_Vote_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_POSTVOTING_RE_Vote_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_POSTVOTING_RE_Vote_msg.Location = new System.Drawing.Point(15, 210);
            this.label_POSTVOTING_RE_Vote_msg.Name = "label_POSTVOTING_RE_Vote_msg";
            this.label_POSTVOTING_RE_Vote_msg.Size = new System.Drawing.Size(467, 50);
            this.label_POSTVOTING_RE_Vote_msg.TabIndex = 2;
            this.label_POSTVOTING_RE_Vote_msg.Text = "                          SORRY\r\nYOU HAVE ALREADY CASTED THE VOTE!\r\n";
            this.label_POSTVOTING_RE_Vote_msg.Visible = false;
            // 
            // PostVoting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_POSTVOTING_RE_Vote_msg);
            this.Controls.Add(this.label_PostVoting_Ineleigible_message);
            this.Controls.Add(this.label_postVoting_message);
            this.Name = "PostVoting";
            this.Size = new System.Drawing.Size(490, 515);
            this.Load += new System.EventHandler(this.PostVoting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_postVoting_message;
        private System.Windows.Forms.Label label_PostVoting_Ineleigible_message;
        private System.Windows.Forms.Label label_POSTVOTING_RE_Vote_msg;
    }
}
