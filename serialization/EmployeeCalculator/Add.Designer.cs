namespace EmployeeCalculator
{
    partial class Add
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
            this.radBtnDev = new System.Windows.Forms.RadioButton();
            this.radBtnHr = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labName = new System.Windows.Forms.Label();
            this.labBs = new System.Windows.Forms.Label();
            this.labId = new System.Windows.Forms.Label();
            this.labDa = new System.Windows.Forms.Label();
            this.labHra = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labTot = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textDa = new System.Windows.Forms.TextBox();
            this.textHra = new System.Windows.Forms.TextBox();
            this.textLabel6 = new System.Windows.Forms.TextBox();
            this.textTot = new System.Windows.Forms.TextBox();
            this.textBs = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radBtnDev
            // 
            this.radBtnDev.AutoSize = true;
            this.radBtnDev.Location = new System.Drawing.Point(12, 12);
            this.radBtnDev.Name = "radBtnDev";
            this.radBtnDev.Size = new System.Drawing.Size(74, 17);
            this.radBtnDev.TabIndex = 0;
            this.radBtnDev.Text = "Developer";
            this.radBtnDev.UseVisualStyleBackColor = true;
            this.radBtnDev.CheckedChanged += new System.EventHandler(this.radBtnDev_CheckedChanged);
            this.radBtnDev.Click += new System.EventHandler(this.radBtnDev_Click);
            // 
            // radBtnHr
            // 
            this.radBtnHr.AutoSize = true;
            this.radBtnHr.Location = new System.Drawing.Point(150, 12);
            this.radBtnHr.Name = "radBtnHr";
            this.radBtnHr.Size = new System.Drawing.Size(41, 17);
            this.radBtnHr.TabIndex = 1;
            this.radBtnHr.Text = "HR";
            this.radBtnHr.UseVisualStyleBackColor = true;
            this.radBtnHr.CheckedChanged += new System.EventHandler(this.radBtnHr_CheckedChanged);
            this.radBtnHr.Click += new System.EventHandler(this.radBtnHr_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(9, 56);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(35, 13);
            this.labName.TabIndex = 2;
            this.labName.Text = "Name";
            // 
            // labBs
            // 
            this.labBs.AutoSize = true;
            this.labBs.Location = new System.Drawing.Point(9, 131);
            this.labBs.Name = "labBs";
            this.labBs.Size = new System.Drawing.Size(62, 13);
            this.labBs.TabIndex = 3;
            this.labBs.Text = "BasicSalary";
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(9, 94);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(18, 13);
            this.labId.TabIndex = 4;
            this.labId.Text = "ID";
            // 
            // labDa
            // 
            this.labDa.AutoSize = true;
            this.labDa.Location = new System.Drawing.Point(9, 168);
            this.labDa.Name = "labDa";
            this.labDa.Size = new System.Drawing.Size(22, 13);
            this.labDa.TabIndex = 5;
            this.labDa.Text = "DA";
            // 
            // labHra
            // 
            this.labHra.AutoSize = true;
            this.labHra.Location = new System.Drawing.Point(9, 204);
            this.labHra.Name = "labHra";
            this.labHra.Size = new System.Drawing.Size(30, 13);
            this.labHra.TabIndex = 6;
            this.labHra.Text = "HRA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // labTot
            // 
            this.labTot.AutoSize = true;
            this.labTot.Location = new System.Drawing.Point(9, 304);
            this.labTot.Name = "labTot";
            this.labTot.Size = new System.Drawing.Size(31, 13);
            this.labTot.TabIndex = 8;
            this.labTot.Text = "Total";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(116, 255);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(116, 336);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(116, 56);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 11;
            // 
            // textDa
            // 
            this.textDa.Location = new System.Drawing.Point(116, 171);
            this.textDa.Name = "textDa";
            this.textDa.Size = new System.Drawing.Size(100, 20);
            this.textDa.TabIndex = 12;
            // 
            // textHra
            // 
            this.textHra.Location = new System.Drawing.Point(116, 197);
            this.textHra.Name = "textHra";
            this.textHra.Size = new System.Drawing.Size(100, 20);
            this.textHra.TabIndex = 13;
            this.textHra.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textLabel6
            // 
            this.textLabel6.Location = new System.Drawing.Point(116, 229);
            this.textLabel6.Name = "textLabel6";
            this.textLabel6.Size = new System.Drawing.Size(100, 20);
            this.textLabel6.TabIndex = 14;
            // 
            // textTot
            // 
            this.textTot.Location = new System.Drawing.Point(116, 297);
            this.textTot.Name = "textTot";
            this.textTot.ReadOnly = true;
            this.textTot.Size = new System.Drawing.Size(100, 20);
            this.textTot.TabIndex = 15;
            // 
            // textBs
            // 
            this.textBs.Location = new System.Drawing.Point(116, 131);
            this.textBs.Name = "textBs";
            this.textBs.Size = new System.Drawing.Size(100, 20);
            this.textBs.TabIndex = 16;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(116, 94);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 17;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 371);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textBs);
            this.Controls.Add(this.textTot);
            this.Controls.Add(this.textLabel6);
            this.Controls.Add(this.textHra);
            this.Controls.Add(this.textDa);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.labTot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labHra);
            this.Controls.Add(this.labDa);
            this.Controls.Add(this.labId);
            this.Controls.Add(this.labBs);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.radBtnHr);
            this.Controls.Add(this.radBtnDev);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radBtnDev;
        private System.Windows.Forms.RadioButton radBtnHr;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labBs;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Label labDa;
        private System.Windows.Forms.Label labHra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labTot;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textDa;
        private System.Windows.Forms.TextBox textHra;
        private System.Windows.Forms.TextBox textLabel6;
        private System.Windows.Forms.TextBox textTot;
        private System.Windows.Forms.TextBox textBs;
        private System.Windows.Forms.TextBox textID;
    }
}