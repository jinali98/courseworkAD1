namespace courseworkAD1
{
    partial class Registration
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
            this.regHeadingLabel = new System.Windows.Forms.Label();
            this.lbRegEmail = new System.Windows.Forms.Label();
            this.lbRegPassword = new System.Windows.Forms.Label();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.btnRegConfirm = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regHeadingLabel
            // 
            this.regHeadingLabel.AutoSize = true;
            this.regHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regHeadingLabel.Location = new System.Drawing.Point(466, 81);
            this.regHeadingLabel.Name = "regHeadingLabel";
            this.regHeadingLabel.Size = new System.Drawing.Size(154, 29);
            this.regHeadingLabel.TabIndex = 0;
            this.regHeadingLabel.Text = "Registration";
            this.regHeadingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbRegEmail
            // 
            this.lbRegEmail.AutoSize = true;
            this.lbRegEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegEmail.Location = new System.Drawing.Point(206, 221);
            this.lbRegEmail.Name = "lbRegEmail";
            this.lbRegEmail.Size = new System.Drawing.Size(60, 25);
            this.lbRegEmail.TabIndex = 4;
            this.lbRegEmail.Text = "Email";
            // 
            // lbRegPassword
            // 
            this.lbRegPassword.AutoSize = true;
            this.lbRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegPassword.Location = new System.Drawing.Point(206, 277);
            this.lbRegPassword.Name = "lbRegPassword";
            this.lbRegPassword.Size = new System.Drawing.Size(98, 25);
            this.lbRegPassword.TabIndex = 5;
            this.lbRegPassword.Text = "Password";
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegEmail.Location = new System.Drawing.Point(471, 225);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(479, 30);
            this.txtRegEmail.TabIndex = 9;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegPassword.Location = new System.Drawing.Point(471, 281);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(479, 30);
            this.txtRegPassword.TabIndex = 10;
            // 
            // btnRegConfirm
            // 
            this.btnRegConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegConfirm.Location = new System.Drawing.Point(377, 471);
            this.btnRegConfirm.Name = "btnRegConfirm";
            this.btnRegConfirm.Size = new System.Drawing.Size(146, 43);
            this.btnRegConfirm.TabIndex = 11;
            this.btnRegConfirm.Text = "Register";
            this.btnRegConfirm.UseVisualStyleBackColor = true;
            this.btnRegConfirm.Click += new System.EventHandler(this.btnRegConfirm_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(593, 471);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(146, 43);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(471, 352);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(479, 30);
            this.txtConfirmPassword.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Confirm Password";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 731);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegConfirm);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.txtRegEmail);
            this.Controls.Add(this.lbRegPassword);
            this.Controls.Add(this.lbRegEmail);
            this.Controls.Add(this.regHeadingLabel);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label regHeadingLabel;
        private System.Windows.Forms.Label lbRegEmail;
        private System.Windows.Forms.Label lbRegPassword;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.Button btnRegConfirm;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label1;
    }
}

