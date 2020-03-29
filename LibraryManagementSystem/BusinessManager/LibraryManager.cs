using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntityLibrary;

namespace BusinessManager
{
    public class LibraryManager
    {
        static string admin_id = "admin";
        static string admin_pass = "admin";

        public static string Admin_id
        {
            get { return LibraryManager.admin_id; }
            set { LibraryManager.admin_id = value; }
        }
        public static string Admin_pass
        {
            get { return LibraryManager.admin_pass; }
            set { LibraryManager.admin_pass = value; }
        }

        static List<User> userList = new List<User>();  
        static List<Book> bookList = new List<Book>();
        static List<BorrowedBooks> borrowedList = new List<BorrowedBooks>();

        public static void PopulateUser()
        {
            userList.Add(new User("Varsha Varadarajan", "75021254", "varsha"));
            userList.Add(new User("Rahul Gaikwad", "75021255", "rahul"));
            userList.Add(new User("Kiran Khade", "75021256", "kiran"));
            userList.Add(new User("Vishnu Tore", "75021257", "vishnu"));
            userList.Add(new User("Yogesh Mhetre", "75021258", "yogesh"));
            userList.Add(new User("Harshita Kotian", "75021259", "harshita"));
        }

        public static void PopulateBook()
        {
            bookList.Add(new Fiction(1,"Harry Potter and the Prisoner of Azkaban","J.K.Rowling",599,5,"Magical"));
            bookList.Add(new Fiction(2,"Alice in Wonderland","Lewis Carol",399,4,"Magical"));
            bookList.Add(new Fiction(3, "Welcome to Hell", "P.G.Burr", 1999, 5, "Supernatural"));
            bookList.Add(new Art(4, "Art of Candle Making", "A.G.Kakde", 250, 3, "Modern"));
            bookList.Add(new Art(5, "Pottery", "V.Vyas", 349, 5, "Medieval"));
            bookList.Add(new Art(6, "Roman Sculptures", "E.I.James",999, 3, "Pre-historic"));
            bookList.Add(new Comics(7, "Ironman", "Marvel", 499, 2, "America"));
            bookList.Add(new Comics(8, "Pokemon", "Pikachu", 650, 3, "Japan"));
            bookList.Add(new Comics(9,"Chacha Choudhary","Chacha",199,3,"India"));
            bookList.Add(new Cooking(10, "Khana Khazana", "Sanjeev Kapoor", 550, 3, "Indian"));
            bookList.Add(new Cooking(11, "Palakkad Chamayal", "D.K.Patammal", 450, 4, "South Indian"));
            bookList.Add(new Cooking(12, "Perfect English Breakfast", "Von Liu", 200, 2, "European"));
        }

        public static bool isBookPresent(int bookId)
        {
            foreach (Book item in bookList)
            {
                if (item.Id == bookId)
                    return true;
            }
            return false;
        }

        public static List<Book> getBook(int bookId)
        {
            List<Book> bk = new List<Book>();
            if (isBookPresent(bookId))
            {
                foreach (Book item in bookList)
                {
                    if (item.Id == bookId)
                    {
                        bk.Add(item);
                        break;
                    }
                }
                return bk;
            }
            else
                return null;
        }

        public static void AddIntoUser(User u)
        {
            userList.Add(u);
        }

        public static bool AddIntoBorrowed(string userId, int bookId, DateTime issueDate, DateTime returnDate)
        {
            bool returned = false;
            BorrowedBooks borrowed = new BorrowedBooks(userId, bookId, issueDate, returnDate, returned);
            foreach (Book item in bookList)
            {
                if(item.Id == bookId)
                {
                    if (item.Available > 0)
                    {
                        item.Available -= 1;
                        borrowedList.Add(borrowed);
                        return true;
                    }
                    else
                    {
                        return false;
                    }                        
                }
            }
            return false;
        }

        public static List<Book> GetByCategory(int type)
        {
            List<Book> returnList = new List<Book>();
            switch(type)
            {
                case 1:
                    foreach (Book item in bookList)
                    {
                        if (item is Fiction)
                        {
                            returnList.Add(item);
                        }
                    }
                    break;
                case 2:
                    foreach (Book item in bookList)
                    {
                        if (item is Art)
                        {
                            returnList.Add(item);
                        }
                    }
                    break;
                case 3:
                    foreach (Book item in bookList)
                    {
                        if (item is Comics)
                        {
                            returnList.Add(item);
                        }
                    }
                    break;
                case 4:
                    foreach (Book item in bookList)
                    {
                        if (item is Cooking)
                        {
                            returnList.Add(item);
                        }
                    }
                    break;
            }
            return returnList;
        }

        public static List<Book> GetByUserId(string userId)
        {
            List<Book> returnList = new List<Book>();
            foreach (BorrowedBooks item in borrowedList)
            {
                if(item.UserId == userId)
                {
                    foreach (Book book in bookList)
                    {
                        if(book.Id == item.BookId)
                        {
                            returnList.Add(book);
                        }
                    }
                }
            }
            return returnList;
        }

        public static bool Return(int bookId, string userId)
        {
            foreach (BorrowedBooks item in borrowedList)
            {
                if(item.BookId == bookId && item.UserId == userId && System.DateTime.Now <= item.ReturnDate)
                {
                    borrowedList.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public static void AddIntoBook(string id, string title, string author, string available, string price, string label6, int val)
        {
            Book b = null;
            switch(val)
            {
                case 1:
                    b = new Fiction();
                    b.Id = int.Parse(id);
                    b.Title = title;
                    b.AuthorName = author;
                    b.Available = int.Parse(available);
                    b.Price = int.Parse(price);
                    (b as Fiction).Type = label6;
                    bookList.Add(b);
                    break;
                case 2:
                    b = new Art();
                    b.Id = int.Parse(id);
                    b.Title = title;
                    b.AuthorName = author;
                    b.Available = int.Parse(available);
                    b.Price = int.Parse(price);
                    (b as Art).Era = label6;
                    bookList.Add(b);
                    break;
                case 3:
                    b = new Art();
                    b.Id = int.Parse(id);
                    b.Title = title;
                    b.AuthorName = author;
                    b.Available = int.Parse(available);
                    b.Price = int.Parse(price);
                    (b as Comics).Region = label6;
                    bookList.Add(b);
                    break;
                case 4:
                    b = new Art();
                    b.Id = int.Parse(id);
                    b.Title = title;
                    b.AuthorName = author;
                    b.Available = int.Parse(available);
                    b.Price = int.Parse(price);
                    (b as Cooking).Cuisine = label6;
                    bookList.Add(b);
                    break;
            }

        }

        public static bool IsPresent(string rollNo, string password)
        {
            foreach (User item in userList)
            {
                if(item.Id == rollNo && item.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public static User getUser(string id)
        {
            foreach (User item in userList)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }
    }
}
