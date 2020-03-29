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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void radFiction_Click(object sender, EventArgs e)
        {
            label6.Text = "Type";
            labelBookId.Show();
            labelBookTitle.Show();
            labelAuthorName.Show();
            labelPrice.Show();
            labelAvaliable.Show();
            label6.Show();

            textBookId.Show();
            textTitle.Show();
            textAuthorName.Show();
            textAvailable.Show();
            textPrice.Show();
            textLabel6.Show();

            btnAddBook.Show();
        }

        private void radArt_Click(object sender, EventArgs e)
        {
            label6.Text = "Era";
            labelBookId.Show();
            labelBookTitle.Show();
            labelAuthorName.Show();
            labelPrice.Show();
            labelAvaliable.Show();
            label6.Show();

            textBookId.Show();
            textTitle.Show();
            textAuthorName.Show();
            textAvailable.Show();
            textPrice.Show();
            textLabel6.Show();

            btnAddBook.Show();
        }

        private void radComics_Click(object sender, EventArgs e)
        {
            label6.Text = "Region";
            labelBookId.Show();
            labelBookTitle.Show();
            labelAuthorName.Show();
            labelPrice.Show();
            labelAvaliable.Show();
            label6.Show();

            textBookId.Show();
            textTitle.Show();
            textAuthorName.Show();
            textAvailable.Show();
            textPrice.Show();
            textLabel6.Show();

            btnAddBook.Show();
        }

        private void radCooking_Click(object sender, EventArgs e)
        {
            label6.Text = "Cuisine";
            labelBookId.Show();
            labelBookTitle.Show();
            labelAuthorName.Show();
            labelPrice.Show();
            labelAvaliable.Show();
            label6.Show();

            textBookId.Show();
            textTitle.Show();
            textAuthorName.Show();
            textAvailable.Show();
            textPrice.Show();
            textLabel6.Show();

            btnAddBook.Show();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            labelBookId.Hide();
            labelBookTitle.Hide();
            labelAuthorName.Hide();
            labelPrice.Hide();
            labelAvaliable.Hide();
            label6.Hide();

            textBookId.Hide();
            textTitle.Hide();
            textAuthorName.Hide();
            textAvailable.Hide();
            textPrice.Hide();
            textLabel6.Hide();

            btnAddBook.Hide();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            int val = 0;
            if (radFiction.Checked == true)
                val = 1;
            else if (radArt.Checked == true)
                val = 2;
            else if (radComics.Checked == true)
                val = 3;
            else
                if (radCooking.Checked == true)
                    val = 4;
            if(!(textBookId.Text == "" || textTitle.Text == "" || textAuthorName.Text == "" || textAvailable.Text == "" || textPrice.Text == "" || textLabel6.Text == ""))
            {
                LibraryManager.AddIntoBook(textBookId.Text, textTitle.Text, textAuthorName.Text, textAvailable.Text, textPrice.Text, textLabel6.Text, val);

                MessageBox.Show("Book Record added successfully");

                textBookId.Text = "";
                textTitle.Text = "";
                textAuthorName.Text = "";
                textAvailable.Text = "";
                textPrice.Text = "";
                textLabel6.Text = "";
            }
            else
            {
                MessageBox.Show("Enter all the fields");
            }
        }
    }
}
