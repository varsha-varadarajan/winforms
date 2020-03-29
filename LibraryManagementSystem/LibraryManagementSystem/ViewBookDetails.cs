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
    public partial class ViewBookDetails : Form
    {
        private int bookId;
        private string userId;

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public int BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        
        public ViewBookDetails()
        {
            InitializeComponent();
        }

        public ViewBookDetails(int bookId,string userId)
        {
            InitializeComponent();
            BookId = bookId;
        }

        private void ViewBookDetails_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LibraryManager.getBook(BookId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult dr = MessageBox.Show("Borrow?", "Borrow Book", MessageBoxButtons.YesNo);
            if(dr == System.Windows.Forms.DialogResult.Yes)
            {
                bool res = LibraryManager.AddIntoBorrowed(userId,bookId,DateTime.Now,DateTime.Now.AddDays(2));
                if(res == true)
                {
                    MessageBox.Show("Return Date :"+DateTime.Now.AddDays(2));
                    this.Close();
                }
                else
                {

                    MessageBox.Show("Insufficient copies. Try again later");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Book not issued");
                this.Close();
            }
        }
    }
}
