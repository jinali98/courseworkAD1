namespace courseworkAD1.UI
{
    partial class Customers
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUnitsTb = new System.Windows.Forms.Button();
            this.btnCustomersTb = new System.Windows.Forms.Button();
            this.btnProductsTb = new System.Windows.Forms.Button();
            this.btnJobsTb = new System.Windows.Forms.Button();
            this.btnHomeTb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(42, 127);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(603, 224);
            this.dgvCustomers.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUnitsTb);
            this.panel1.Controls.Add(this.btnCustomersTb);
            this.panel1.Controls.Add(this.btnProductsTb);
            this.panel1.Controls.Add(this.btnJobsTb);
            this.panel1.Controls.Add(this.btnHomeTb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 89);
            this.panel1.TabIndex = 12;
            // 
            // btnUnitsTb
            // 
            this.btnUnitsTb.Location = new System.Drawing.Point(554, 29);
            this.btnUnitsTb.Name = "btnUnitsTb";
            this.btnUnitsTb.Size = new System.Drawing.Size(108, 35);
            this.btnUnitsTb.TabIndex = 4;
            this.btnUnitsTb.Text = "Units";
            this.btnUnitsTb.UseVisualStyleBackColor = true;
            // 
            // btnCustomersTb
            // 
            this.btnCustomersTb.Location = new System.Drawing.Point(422, 29);
            this.btnCustomersTb.Name = "btnCustomersTb";
            this.btnCustomersTb.Size = new System.Drawing.Size(108, 35);
            this.btnCustomersTb.TabIndex = 3;
            this.btnCustomersTb.Text = "Customers";
            this.btnCustomersTb.UseVisualStyleBackColor = true;
            // 
            // btnProductsTb
            // 
            this.btnProductsTb.Location = new System.Drawing.Point(155, 29);
            this.btnProductsTb.Name = "btnProductsTb";
            this.btnProductsTb.Size = new System.Drawing.Size(108, 35);
            this.btnProductsTb.TabIndex = 2;
            this.btnProductsTb.Text = "Products";
            this.btnProductsTb.UseVisualStyleBackColor = true;
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
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.panel1);
            this.Name = "Customers";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUnitsTb;
        private System.Windows.Forms.Button btnCustomersTb;
        private System.Windows.Forms.Button btnProductsTb;
        private System.Windows.Forms.Button btnJobsTb;
        private System.Windows.Forms.Button btnHomeTb;
    }
}