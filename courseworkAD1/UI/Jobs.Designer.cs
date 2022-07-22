namespace courseworkAD1.UI
{
    partial class Jobs
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUnitsTb = new System.Windows.Forms.Button();
            this.btnProductsTb = new System.Windows.Forms.Button();
            this.btnJobsTb = new System.Windows.Forms.Button();
            this.btnHomeTb = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.txtJobId = new System.Windows.Forms.TextBox();
            this.lbRegEmail = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(27, 105);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 35);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvJobs
            // 
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Location = new System.Drawing.Point(27, 146);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.RowHeadersWidth = 51;
            this.dgvJobs.RowTemplate.Height = 24;
            this.dgvJobs.Size = new System.Drawing.Size(754, 224);
            this.dgvJobs.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUnitsTb);
            this.panel1.Controls.Add(this.btnProductsTb);
            this.panel1.Controls.Add(this.btnJobsTb);
            this.panel1.Controls.Add(this.btnHomeTb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 89);
            this.panel1.TabIndex = 7;
            // 
            // btnUnitsTb
            // 
            this.btnUnitsTb.Location = new System.Drawing.Point(427, 29);
            this.btnUnitsTb.Name = "btnUnitsTb";
            this.btnUnitsTb.Size = new System.Drawing.Size(108, 35);
            this.btnUnitsTb.TabIndex = 4;
            this.btnUnitsTb.Text = "Units";
            this.btnUnitsTb.UseVisualStyleBackColor = true;
            this.btnUnitsTb.Click += new System.EventHandler(this.btnUnitsTb_Click);
            // 
            // btnProductsTb
            // 
            this.btnProductsTb.Location = new System.Drawing.Point(155, 29);
            this.btnProductsTb.Name = "btnProductsTb";
            this.btnProductsTb.Size = new System.Drawing.Size(108, 35);
            this.btnProductsTb.TabIndex = 2;
            this.btnProductsTb.Text = "Products";
            this.btnProductsTb.UseVisualStyleBackColor = true;
            this.btnProductsTb.Click += new System.EventHandler(this.btnProductsTb_Click_1);
            // 
            // btnJobsTb
            // 
            this.btnJobsTb.Location = new System.Drawing.Point(290, 29);
            this.btnJobsTb.Name = "btnJobsTb";
            this.btnJobsTb.Size = new System.Drawing.Size(108, 35);
            this.btnJobsTb.TabIndex = 1;
            this.btnJobsTb.Text = "Jobs";
            this.btnJobsTb.UseVisualStyleBackColor = true;
            // 
            // btnHomeTb
            // 
            this.btnHomeTb.Location = new System.Drawing.Point(19, 29);
            this.btnHomeTb.Name = "btnHomeTb";
            this.btnHomeTb.Size = new System.Drawing.Size(108, 35);
            this.btnHomeTb.TabIndex = 0;
            this.btnHomeTb.Text = "Home";
            this.btnHomeTb.UseVisualStyleBackColor = true;
            this.btnHomeTb.Click += new System.EventHandler(this.btnHomeTb_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(438, 497);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(84, 35);
            this.btnDecline.TabIndex = 11;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // txtJobId
            // 
            this.txtJobId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobId.Location = new System.Drawing.Point(115, 502);
            this.txtJobId.Name = "txtJobId";
            this.txtJobId.Size = new System.Drawing.Size(212, 30);
            this.txtJobId.TabIndex = 20;
            // 
            // lbRegEmail
            // 
            this.lbRegEmail.AutoSize = true;
            this.lbRegEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegEmail.Location = new System.Drawing.Point(22, 504);
            this.lbRegEmail.Name = "lbRegEmail";
            this.lbRegEmail.Size = new System.Drawing.Size(69, 25);
            this.lbRegEmail.TabIndex = 19;
            this.lbRegEmail.Text = "Job ID";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(346, 497);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(86, 35);
            this.btnAccept.TabIndex = 21;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.Location = new System.Drawing.Point(528, 497);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(161, 35);
            this.btnCompleted.TabIndex = 22;
            this.btnCompleted.Text = "Mark As Completed";
            this.btnCompleted.UseVisualStyleBackColor = true;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(695, 497);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(86, 35);
            this.btnView.TabIndex = 23;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 594);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtJobId);
            this.Controls.Add(this.lbRegEmail);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvJobs);
            this.Controls.Add(this.panel1);
            this.Name = "Jobs";
            this.Text = "Jobs";
            this.Load += new System.EventHandler(this.Jobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUnitsTb;
        private System.Windows.Forms.Button btnProductsTb;
        private System.Windows.Forms.Button btnJobsTb;
        private System.Windows.Forms.Button btnHomeTb;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.TextBox txtJobId;
        private System.Windows.Forms.Label lbRegEmail;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Button btnView;
    }
}