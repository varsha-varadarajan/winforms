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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if(LibraryManager.Admin_id == textAdminName.Text && LibraryManager.Admin_pass == textAdminPass.Text)
            {
                MessageBox.Show("Login success.");
                AddBook addBook = new AddBook();
                addBook.Show();
            }
            else
            {
                MessageBox.Show("Enter valid credentials");
            }
        }
    }
}
