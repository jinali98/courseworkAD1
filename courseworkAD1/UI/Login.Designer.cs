namespace courseworkAD1.UI
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegConfirm = new System.Windows.Forms.Button();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.lbRegPassword = new System.Windows.Forms.Label();
            this.lbRegEmail = new System.Windows.Forms.Label();
            this.regHeadingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(489, 407);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(146, 43);
            this.btnLogin.TabIndex = 21;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegConfirm
            // 
            this.btnRegConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegConfirm.Location = new System.Drawing.Point(273, 407);
            this.btnRegConfirm.Name = "btnRegConfirm";
            this.btnRegConfirm.Size = new System.Drawing.Size(146, 43);
            this.btnRegConfirm.TabIndex = 20;
            this.btnRegConfirm.Text = "Register";
            this.btnRegConfirm.UseVisualStyleBackColor = true;
            this.btnRegConfirm.Click += new System.EventHandler(this.btnRegConfirm_Click);
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegPassword.Location = new System.Drawing.Point(358, 287);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(479, 30);
            this.txtRegPassword.TabIndex = 19;
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegEmail.Location = new System.Drawing.Point(358, 208);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(479, 30);
            this.txtRegEmail.TabIndex = 18;
            // 
            // lbRegPassword
            // 
            this.lbRegPassword.AutoSize = true;
            this.lbRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegPassword.Location = new System.Drawing.Point(93, 283);
            this.lbRegPassword.Name = "lbRegPassword";
            this.lbRegPassword.Size = new System.Drawing.Size(98, 25);
            this.lbRegPassword.TabIndex = 17;
            this.lbRegPassword.Text = "Password";
            // 
            // lbRegEmail
            // 
            this.lbRegEmail.AutoSize = true;
            this.lbRegEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegEmail.Location = new System.Drawing.Point(93, 204);
            this.lbRegEmail.Name = "lbRegEmail";
            this.lbRegEmail.Size = new System.Drawing.Size(60, 25);
            this.lbRegEmail.TabIndex = 16;
            this.lbRegEmail.Text = "Email";
            // 
            // regHeadingLabel
            // 
            this.regHeadingLabel.AutoSize = true;
            this.regHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regHeadingLabel.Location = new System.Drawing.Point(412, 83);
            this.regHeadingLabel.Name = "regHeadingLabel";
            this.regHeadingLabel.Size = new System.Drawing.Size(78, 29);
            this.regHeadingLabel.TabIndex = 15;
            this.regHeadingLabel.Text = "Login";
            this.regHeadingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 570);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegConfirm);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.txtRegEmail);
            this.Controls.Add(this.lbRegPassword);
            this.Controls.Add(this.lbRegEmail);
            this.Controls.Add(this.regHeadingLabel);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegConfirm;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.Label lbRegPassword;
        private System.Windows.Forms.Label lbRegEmail;
        private System.Windows.Forms.Label regHeadingLabel;
    }
}