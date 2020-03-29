using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class User
    {
        private string name;
        private string id;
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }    

        public string Id
        {
            get { return id; }
            set { id = value; }
        }       

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public User()
        {

        }

        public User(string name, string id, string password)
        {
            Name = name;
            Id = id;
            Password = password;
        }
        
    }
}
