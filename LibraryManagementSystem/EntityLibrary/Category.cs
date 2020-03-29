using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Fiction: Book
    {
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        
        public Fiction():base()
        {
        }

        public Fiction(int id, string title, string author, int price, int available, string type): base(id,title,author,price,available)
        {
            Type = type;
        }
    }

    public class Art : Book
    {
        private string era;

        public string Era
        {
            get { return era; }
            set { era = value; }
        }
        public Art():base()
        {
        }

        public Art(int id, string title, string author, int price, int available, string era): base(id,title,author,price,available)
        {
            Era = era;
        }
    }

    public class Comics: Book
    {
        private string region;

        public string Region
        {
            get { return region; }
            set { region = value; }
        }  
        public Comics():base()
        {
        }

        public Comics(int id, string title, string author, int price, int available, string region): base(id,title,author,price,available)
        {
            Region = region;
        }
    }   

    public class Cooking: Book
    {
        private string cuisine;

        public string Cuisine
        {
            get { return cuisine; }
            set { cuisine = value; }
        }      
        public Cooking():base()
        {
        }

        public Cooking(int id, string title, string author, int price, int available, string cuisine): base(id,title,author,price,available)
        {
            Cuisine = cuisine;
        }
    }
}
