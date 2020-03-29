namespace LibraryManagementSystem
{
    partial class AdminLogin
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
            this.labelAdminName = new System.Windows.Forms.Label();
            this.labelAdminPass = new System.Windows.Forms.Label();
            this.textAdminName = new System.Windows.Forms.TextBox();
            this.textAdminPass = new System.Windows.Forms.TextBox();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAdminName
            // 
            this.labelAdminName.AutoSize = true;
            this.labelAdminName.Location = new System.Drawing.Point(46, 67);
            this.labelAdminName.Name = "labelAdminName";
            this.labelAdminName.Size = new System.Drawing.Size(60, 13);
            this.labelAdminName.TabIndex = 0;
            this.labelAdminName.Text = "User Name";
            // 
            // labelAdminPass
            // 
            this.labelAdminPass.AutoSize = true;
            this.labelAdminPass.Location = new System.Drawing.Point(46, 138);
            this.labelAdminPass.Name = "labelAdminPass";
            this.labelAdminPass.Size = new System.Drawing.Size(53, 13);
            this.labelAdminPass.TabIndex = 1;
            this.labelAdminPass.Text = "Password";
            // 
            // textAdminName
            // 
            this.textAdminName.Location = new System.Drawing.Point(144, 67);
            this.textAdminName.Name = "textAdminName";
            this.textAdminName.Size = new System.Drawing.Size(100, 20);
            this.textAdminName.TabIndex = 2;
            // 
            // textAdminPass
            // 
            this.textAdminPass.Location = new System.Drawing.Point(144, 135);
            this.textAdminPass.Name = "textAdminPass";
            this.textAdminPass.PasswordChar = '*';
            this.textAdminPass.Size = new System.Drawing.Size(100, 20);
            this.textAdminPass.TabIndex = 3;
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(103, 189);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(75, 23);
            this.btnAdminLogin.TabIndex = 4;
            this.btnAdminLogin.Text = "Login";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.textAdminPass);
            this.Controls.Add(this.textAdminName);
            this.Controls.Add(this.labelAdminPass);
            this.Controls.Add(this.labelAdminName);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdminName;
        private System.Windows.Forms.Label labelAdminPass;
        private System.Windows.Forms.TextBox textAdminName;
        private System.Windows.Forms.TextBox textAdminPass;
        private System.Windows.Forms.Button btnAdminLogin;
    }
}