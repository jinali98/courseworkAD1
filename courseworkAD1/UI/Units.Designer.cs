namespace courseworkAD1.UI
{
    partial class Units
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvUnits = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUnitsTb = new System.Windows.Forms.Button();
            this.btnCustomersTb = new System.Windows.Forms.Button();
            this.btnProductsTb = new System.Windows.Forms.Button();
            this.btnJobsTb = new System.Windows.Forms.Button();
            this.btnHomeTb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnitId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 35);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(156, 107);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 35);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvUnits
            // 
            this.dgvUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnits.Location = new System.Drawing.Point(19, 161);
            this.dgvUnits.Name = "dgvUnits";
            this.dgvUnits.RowHeadersWidth = 51;
            this.dgvUnits.RowTemplate.Height = 24;
            this.dgvUnits.Size = new System.Drawing.Size(715, 224);
            this.dgvUnits.TabIndex = 9;
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
            this.panel1.Size = new System.Drawing.Size(833, 89);
            this.panel1.TabIndex = 8;
            // 
            // btnUnitsTb
            // 
            this.btnUnitsTb.Location = new System.Drawing.Point(650, 30);
            this.btnUnitsTb.Name = "btnUnitsTb";
            this.btnUnitsTb.Size = new System.Drawing.Size(108, 35);
            this.btnUnitsTb.TabIndex = 4;
            this.btnUnitsTb.Text = "Units";
            this.btnUnitsTb.UseVisualStyleBackColor = true;
            // 
            // btnCustomersTb
            // 
            this.btnCustomersTb.Location = new System.Drawing.Point(518, 30);
            this.btnCustomersTb.Name = "btnCustomersTb";
            this.btnCustomersTb.Size = new System.Drawing.Size(108, 35);
            this.btnCustomersTb.TabIndex = 3;
            this.btnCustomersTb.Text = "Customers";
            this.btnCustomersTb.UseVisualStyleBackColor = true;
            // 
            // btnProductsTb
            // 
            this.btnProductsTb.Location = new System.Drawing.Point(251, 30);
            this.btnProductsTb.Name = "btnProductsTb";
            this.btnProductsTb.Size = new System.Drawing.Size(108, 35);
            this.btnProductsTb.TabIndex = 2;
            this.btnProductsTb.Text = "Products";
            this.btnProductsTb.UseVisualStyleBackColor = true;
            this.btnProductsTb.Click += new System.EventHandler(this.btnProductsTb_Click);
            // 
            // btnJobsTb
            // 
            this.btnJobsTb.Location = new System.Drawing.Point(386, 30);
            this.btnJobsTb.Name = "btnJobsTb";
            this.btnJobsTb.Size = new System.Drawing.Size(108, 35);
            this.btnJobsTb.TabIndex = 1;
            this.btnJobsTb.Text = "Jobs";
            this.btnJobsTb.UseVisualStyleBackColor = true;
            // 
            // btnHomeTb
            // 
            this.btnHomeTb.Location = new System.Drawing.Point(115, 30);
            this.btnHomeTb.Name = "btnHomeTb";
            this.btnHomeTb.Size = new System.Drawing.Size(108, 35);
            this.btnHomeTb.TabIndex = 0;
            this.btnHomeTb.Text = "Home";
            this.btnHomeTb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Unit ID";
            // 
            // txtUnitId
            // 
            this.txtUnitId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitId.Location = new System.Drawing.Point(116, 426);
            this.txtUnitId.Name = "txtUnitId";
            this.txtUnitId.Size = new System.Drawing.Size(321, 30);
            this.txtUnitId.TabIndex = 14;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(494, 421);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 35);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Units
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnitId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvUnits);
            this.Controls.Add(this.panel1);
            this.Name = "Units";
            this.Text = "Units";
            this.Load += new System.EventHandler(this.Units_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvUnits;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUnitsTb;
        private System.Windows.Forms.Button btnCustomersTb;
        private System.Windows.Forms.Button btnProductsTb;
        private System.Windows.Forms.Button btnJobsTb;
        private System.Windows.Forms.Button btnHomeTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnitId;
        private System.Windows.Forms.Button btnDelete;
    }
}