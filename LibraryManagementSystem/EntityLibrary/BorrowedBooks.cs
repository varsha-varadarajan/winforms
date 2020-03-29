using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class BorrowedBooks
    {
        private string userId;
        private int bookId;
        private DateTime issueDate;
        private DateTime returnDate;
        private bool returned;

        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        public DateTime IssueDate
        {
            get { return issueDate; }
            set { issueDate = value; }
        }

        public bool Returned
        {
            get { return returned; }
            set { returned = value; }
        }

        public int BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public BorrowedBooks()
        {

        }
        public BorrowedBooks(string userId, int bookId, DateTime issueDate, DateTime returnDate, bool returned )
        {
            UserId = userId;
            BookId = bookId;
            IssueDate = issueDate;
            ReturnDate = returnDate;
            Returned = returned;
        }
    }
}
