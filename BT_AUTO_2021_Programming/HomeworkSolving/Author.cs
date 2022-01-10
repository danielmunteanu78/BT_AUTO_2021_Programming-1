using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming.HomeworkSolving
{
    class Author
    {
        string name; 
        string email;

        public Author(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public string GetName()
        {
            return name;
        }

        public string GetEmail()
        {
            return email;
        }
    }
}
