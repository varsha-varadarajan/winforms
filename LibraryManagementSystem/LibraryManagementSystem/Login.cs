using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessManager;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        string id;
        string password;
        Form1 parent;
        public Login()
        {
            InitializeComponent();
        }

        public Login(Form1 frm, string id)
        {
            InitializeComponent();
            parent = frm;
            this.id = id;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            id = textRollNo.Text;
            password = textPass.Text;
            
            if (LibraryManager.IsPresent(id, password))
            {
                MessageBox.Show("Login successful.\nGo to operations to borrow or return books.");
                parent.Id = id;
                parent.setLogin();
                //parent.ChildCalled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter valid Id and Password");
                textRollNo.Text = "";
                textPass.Text = "";
            }
        }
    }
}
