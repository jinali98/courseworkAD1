namespace courseworkAD1.UI
{
    partial class AdminDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHomeTb = new System.Windows.Forms.Button();
            this.btnJobsTb = new System.Windows.Forms.Button();
            this.btnProductsTb = new System.Windows.Forms.Button();
            this.btnCustomersTb = new System.Windows.Forms.Button();
            this.btnUnitsTb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(897, 89);
            this.panel1.TabIndex = 0;
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
            // btnJobsTb
            // 
            this.btnJobsTb.Location = new System.Drawing.Point(290, 29);
            this.btnJobsTb.Name = "btnJobsTb";
            this.btnJobsTb.Size = new System.Drawing.Size(108, 35);
            this.btnJobsTb.TabIndex = 1;
            this.btnJobsTb.Text = "Jobs";
            this.btnJobsTb.UseVisualStyleBackColor = true;
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
            // btnCustomersTb
            // 
            this.btnCustomersTb.Location = new System.Drawing.Point(422, 29);
            this.btnCustomersTb.Name = "btnCustomersTb";
            this.btnCustomersTb.Size = new System.Drawing.Size(108, 35);
            this.btnCustomersTb.TabIndex = 3;
            this.btnCustomersTb.Text = "Customers";
            this.btnCustomersTb.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 279);
            this.button1.TabIndex = 5;
            this.button1.Text = "View List Of Accepted Jobs";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 279);
            this.button2.TabIndex = 6;
            this.button2.Text = "View List Of Declined Jobs";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(476, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 279);
            this.button3.TabIndex = 7;
            this.button3.Text = "View List Of Completed Jobs";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(697, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 279);
            this.button4.TabIndex = 8;
            this.button4.Text = "View List Of Jobs In Current Month";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 500);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUnitsTb;
        private System.Windows.Forms.Button btnCustomersTb;
        private System.Windows.Forms.Button btnProductsTb;
        private System.Windows.Forms.Button btnJobsTb;
        private System.Windows.Forms.Button btnHomeTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}