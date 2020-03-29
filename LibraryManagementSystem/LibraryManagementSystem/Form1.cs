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
    public partial class Form1 : Form
    {
        private string id=null;
        Login loginForm;

        //public bool ChildCalled
        //{
        //    get { return childCalled; }
        //    set { childCalled = value; }
        //}

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.MdiParent = this;
            registerForm.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm = new Login(this,id);
            loginForm.MdiParent = this;
            loginForm.Show();            
        }

        public void setLogin()
        {            
            textBox1.Text = "Welcome "+ LibraryManager.getUser(id).Name;
            textBox1.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.MdiParent = this;
            adminLogin.Show();
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                Borrow borrowPage = new Borrow(id);
                borrowPage.MdiParent = this;
                borrowPage.Show();
            }
            else
            {
                MessageBox.Show("Please login first.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Hide();
            LibraryManager.PopulateBook();
            LibraryManager.PopulateUser();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                ReturnForm returnForm = new ReturnForm(id);
                returnForm.MdiParent = this;
                returnForm.Show();
            }
            else
                MessageBox.Show("Please login first.");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                MessageBox.Show("Logout successful.");
                id = null;
                textBox1.Hide();
            }
            else
                MessageBox.Show("Please login first.");
        }

    }
}
