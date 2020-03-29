using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Book
    {
        private int id;
        private string title;
        private string authorName;
        private float price;
        private int available;

        public int Available
        {
            get { return available; }
            set { available = value; }
        }
        

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        

        public string AuthorName
        {
            get { return authorName; }
            set { authorName = value; }
        }
        

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Book()
        {

        }
        public Book(int id, string title, string author, int price, int available)
        {
            Id = id;
            Title = title;
            AuthorName = author;
            Price = price;
            Available = available;
        }
    }
}
