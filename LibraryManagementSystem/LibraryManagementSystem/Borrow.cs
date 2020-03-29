using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Borrow : Form
    {
        private string id;
        private int bookId;

        public int BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public Borrow()
        {
            InitializeComponent();
        }

        public Borrow(string id)
        {
            InitializeComponent();
            Id = id;
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
                labelBookID.Hide();
                textBookId.Hide();
                btnViewDetails.Hide();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            labelBookID.Show();
            textBookId.Show();
            btnViewDetails.Show();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            BookId = int.Parse(textBookId.Text);
            ViewBookDetails viewBookDetails = new ViewBookDetails(BookId,id);
            viewBookDetails.Show();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            Category category = new Category(BookId,id);
            category.Show();
        }
    }
}
