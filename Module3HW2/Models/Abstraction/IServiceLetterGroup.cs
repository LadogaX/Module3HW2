using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2.Models.Abstraction
{
    public interface IServiceLetterGroup
    {
        public LettersGroup LettersGroup { get; set; }

        void Add(Person person);

        void Add(char symbol, Person person);

        public List<Person> GetListPersons(char symbol);

        public string DefineCulture(char symbol);

        public void GroupPersonsBook();

        string GetCurrentLanguage();

        void SetCurrentLanguage(string currentLanguage);

        void Clear();
     }
}
