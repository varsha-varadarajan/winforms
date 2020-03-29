namespace LibraryManagementSystem
{
    partial class RegisterForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelRollNo = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textRollNo = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(22, 45);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(21, 122);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(53, 13);
            this.labelPass.TabIndex = 2;
            this.labelPass.Text = "Password";
            // 
            // labelRollNo
            // 
            this.labelRollNo.AutoSize = true;
            this.labelRollNo.Location = new System.Drawing.Point(21, 82);
            this.labelRollNo.Name = "labelRollNo";
            this.labelRollNo.Size = new System.Drawing.Size(42, 13);
            this.labelRollNo.TabIndex = 3;
            this.labelRollNo.Text = "Roll No";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(172, 37);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 4;
            // 
            // textRollNo
            // 
            this.textRollNo.Location = new System.Drawing.Point(172, 75);
            this.textRollNo.Name = "textRollNo";
            this.textRollNo.Size = new System.Drawing.Size(100, 20);
            this.textRollNo.TabIndex = 5;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(172, 122);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(100, 20);
            this.textPass.TabIndex = 6;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(104, 184);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textRollNo);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelRollNo);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelName);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelRollNo;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textRollNo;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button btnRegister;
    }
}