using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2.Models
{
   public class PersonsBook
    {
        public PersonsBook()
        {
            PeopleList = new List<Person>();
        }

        public List<Person> PeopleList { get; set; }
    }
}
