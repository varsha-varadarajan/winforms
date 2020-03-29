using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeCalculator
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void radBtnDev_Click(object sender, EventArgs e)
        {
            labName.Show();
            labId.Show();
            labBs.Show();
            labDa.Show();
            labHra.Show();
            label6.Text = "Incentive";
            label6.Show();
            btnCalc.Show();
            btnSubmit.Show();
            labTot.Show();

            textName.Show();
            textID.Show();
            textBs.Show();
            textDa.Show();
            textHra.Show();
            textLabel6.Show();
            textTot.Show();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            labName.Hide();
            labId.Hide();
            labBs.Hide();
            labDa.Hide();
            labHra.Hide();
            label6.Hide();
            btnCalc.Hide();
            btnSubmit.Hide();
            labTot.Hide();

            textName.Hide();
            textID.Hide();
            textBs.Hide();
            textDa.Hide();
            textHra.Hide();
            textLabel6.Hide();
            textTot.Hide();
            
        }

        private void radBtnHr_Click(object sender, EventArgs e)
        {
            labName.Show();
            labId.Show();
            labBs.Show();
            labDa.Show();
            labHra.Show();
            label6.Text = "GratuityPay";
            label6.Show();
            btnCalc.Show();
            btnSubmit.Show();
            labTot.Show();

            textName.Show();
            textID.Show();
            textBs.Show();
            textDa.Show();
            textHra.Show();
            textLabel6.Show();
            textTot.Show();
        }

        private void radBtnHr_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radBtnDev_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {            
            Employee employee = null;
            if (radBtnDev.Checked == true)
            {

                employee = new Developer();
                (employee as Developer).Incentive = int.Parse(textLabel6.Text);
                employee.Basic = int.Parse(textBs.Text);
                employee.Da = int.Parse(textDa.Text);
                employee.Hra = int.Parse(textHra.Text);

                employee.CalculateSalary();

                textTot.Text = employee.Total.ToString();
            }
            else
                if (radBtnHr.Checked == true)
                {
                    employee = new HR();
                    (employee as HR).Gratuity = int.Parse(textLabel6.Text);
                    employee.Basic = int.Parse(textBs.Text);
                    employee.Da = int.Parse(textDa.Text);
                    employee.Hra = int.Parse(textHra.Text);

                    employee.CalculateSalary();
                    textTot.Text = employee.Total.ToString();
                }

           

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = MessageBox.Show("Submit the entry?", "Decide", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Employee employee = null;
                if (radBtnDev.Checked == true)
                {

                    employee = new Developer();
                    (employee as Developer).Incentive = int.Parse(textLabel6.Text);
                    employee.Basic = int.Parse(textBs.Text);
                    employee.Da = int.Parse(textDa.Text);
                    employee.Hra = int.Parse(textHra.Text);

                    employee.CalculateSalary();

                    employee.Name = textName.Text;
                    employee.Id = int.Parse(textID.Text);

                    BusinessManager.AddEmployeeIntoList(employee as Developer);

                    //textTot.Text = employee.Total.ToString();
                }
                else
                    if (radBtnHr.Checked == true)
                    {
                        employee = new HR();
                        (employee as HR).Gratuity = int.Parse(textLabel6.Text);
                        employee.Basic = int.Parse(textBs.Text);
                        employee.Da = int.Parse(textDa.Text);
                        employee.Hra = int.Parse(textHra.Text);

                        employee.CalculateSalary();
                        //textTot.Text = employee.Total.ToString();

                        employee.Name = textName.Text;
                        employee.Id = int.Parse(textID.Text);

                        BusinessManager.AddEmployeeIntoList(employee as HR);
                    }
                MessageBox.Show("Submitted successfully !!!!");
                this.Close();

            }
            else
                this.Close();

        }

    }
}
