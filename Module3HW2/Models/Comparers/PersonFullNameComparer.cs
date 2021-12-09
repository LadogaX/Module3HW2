using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2.Models.Comparers
{
    public class PersonFullNameComparer : IComparer<Person>
    {
            public int Compare(Person person1, Person person2)
            {
                if (person1 == null || person2 == null)
                {
                    return 1;
                }

                return string.Compare(person1.FullName, person2.FullName);
            }
    }
}
