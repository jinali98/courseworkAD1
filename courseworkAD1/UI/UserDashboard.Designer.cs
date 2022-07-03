namespace courseworkAD1.UI
{
    partial class UserDashboard
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
            this.btnCreateJob = new System.Windows.Forms.Button();
            this.btnViewJobs = new System.Windows.Forms.Button();
            this.btnTrackJob = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateJob
            // 
            this.btnCreateJob.Location = new System.Drawing.Point(236, 107);
            this.btnCreateJob.Name = "btnCreateJob";
            this.btnCreateJob.Size = new System.Drawing.Size(479, 63);
            this.btnCreateJob.TabIndex = 0;
            this.btnCreateJob.Text = "Create A New Job";
            this.btnCreateJob.UseVisualStyleBackColor = true;
            // 
            // btnViewJobs
            // 
            this.btnViewJobs.Location = new System.Drawing.Point(236, 204);
            this.btnViewJobs.Name = "btnViewJobs";
            this.btnViewJobs.Size = new System.Drawing.Size(479, 63);
            this.btnViewJobs.TabIndex = 1;
            this.btnViewJobs.Text = "View All Jobs";
            this.btnViewJobs.UseVisualStyleBackColor = true;
            // 
            // btnTrackJob
            // 
            this.btnTrackJob.Location = new System.Drawing.Point(236, 306);
            this.btnTrackJob.Name = "btnTrackJob";
            this.btnTrackJob.Size = new System.Drawing.Size(479, 63);
            this.btnTrackJob.TabIndex = 2;
            this.btnTrackJob.Text = "Track A Job";
            this.btnTrackJob.UseVisualStyleBackColor = true;
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 515);
            this.Controls.Add(this.btnTrackJob);
            this.Controls.Add(this.btnViewJobs);
            this.Controls.Add(this.btnCreateJob);
            this.Name = "UserDashboard";
            this.Text = "UserDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateJob;
        private System.Windows.Forms.Button btnViewJobs;
        private System.Windows.Forms.Button btnTrackJob;
    }
}