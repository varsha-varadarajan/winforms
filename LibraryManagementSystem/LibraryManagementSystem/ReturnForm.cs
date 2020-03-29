using System;
using System.Windows.Forms;

using BusinessManager;

namespace LibraryManagementSystem
{
    public partial class ReturnForm : Form
    {
        private string userid;
        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }
        public ReturnForm()
        {
            InitializeComponent();
        }

        public ReturnForm(string userId)
        {
            InitializeComponent();
            Userid = userid;
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
           // if (userid != null)
            {
                dataGridView1.DataSource = LibraryManager.GetByUserId(Userid);
            }
           // else
           // {
           //     MessageBox.Show("Please login");
           //     this.Close();
           // }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(textBookId.Text);
            if(LibraryManager.Return(bookId, userid))
            {
                MessageBox.Show("Book returned successfully");
                dataGridView1.DataSource = LibraryManager.GetByUserId(Userid);
            }
            else
            {
                MessageBox.Show("Enter valid Book ID");
            }       
        }
    }
}
