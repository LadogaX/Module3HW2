using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2.Models
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string EMail { get; set; }

        public char FirstLetter => FirstName.First<char>();

        public string FullName => $"{FirstName} {LastName}";
    }
}