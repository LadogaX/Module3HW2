using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2.Models
{
    public class Config
    {
        public string CurrentLanguage { get; set; }
        public Dictionary<string, List<char>> LanguageSetting { get; set; } = new Dictionary<string, List<char>>();
    }
}
