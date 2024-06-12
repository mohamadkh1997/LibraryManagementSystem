using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class User
    {

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }// Note: Storing passwords as plain text is not secure.
        public DateTime CreatedDate { get; set; }


    }
}
