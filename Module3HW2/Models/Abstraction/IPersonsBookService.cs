using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2.Models.Abstraction
{
    public interface IPersonsBookService
    {
        void LoadFromFile(string dataFileName);
        void SaveToFile(string dataFileName);
    }
}
