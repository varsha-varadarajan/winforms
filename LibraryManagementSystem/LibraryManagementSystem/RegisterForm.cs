using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EntityLibrary;
using BusinessManager;

namespace LibraryManagementSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" || textRollNo.Text == "" || textPass.Text == "")
                MessageBox.Show("Enter all fields");
            else
            {
                User u = new User();

                u.Name = textName.Text;
                u.Id = textRollNo.Text;
                u.Password = textPass.Text;

                System.Windows.Forms.DialogResult dr = MessageBox.Show("Register?", "Register", MessageBoxButtons.YesNo);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show("Registered successfully. Go to login page.");

                    textName.Text = "";
                    textRollNo.Text = "";
                    textPass.Text = "";
           
                    LibraryManager.AddIntoUser(u);

                    this.Close();
                }
                else
                    MessageBox.Show("Not registered");
            }
        }
    }
}
