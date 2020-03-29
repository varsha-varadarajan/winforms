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
    public partial class Category : Form
    {
        private int bookId;
        private string userID;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public int BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        public Category()
        {
            InitializeComponent();
        }

        public Category(int bookId, string userId)
        {
            InitializeComponent();
            BookId = bookId;
            UserID = userID;
        }

        private void radFiction_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LibraryManager.GetByCategory(1);            
        }

        private void radArt_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LibraryManager.GetByCategory(2); 
        }

        private void radComics_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LibraryManager.GetByCategory(3); 
        }

        private void radCooking_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LibraryManager.GetByCategory(4); 
        }
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult dr = MessageBox.Show("Borrow?", "Borrow Book", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                
                BookId = int.Parse(textBookId.Text);
                bool res = LibraryManager.AddIntoBorrowed(UserID, BookId, DateTime.Now, DateTime.Now.AddDays(2));
                if (res == true)
                {
                    MessageBox.Show("Return Date :" + DateTime.Now.AddDays(2));
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection collect = dataGridView1.SelectedCells;
            foreach (var item in collect)
            {
                textBookId.Text = item.ToString();
            }
        }
    }
}
