using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module3HW2.Models;
using Module3HW2.Models.Abstraction;

namespace Module3HW2.Services
{
    public class ServiceLetterGroup : IServiceLetterGroup
    {
        private Config _config;
        private ServiceConfig _serviceConfig;

        public ServiceLetterGroup()
        {
            _serviceConfig = new ServiceConfig();
            _config = _serviceConfig.Config;
            LettersGroup = new LettersGroup();

            PersonsBookService = new PersonsBookService();
        }

        public LettersGroup LettersGroup { get; set; }

        public PersonsBookService PersonsBookService { get; set; }
        public void SaveToFile()
        {
            PersonsBookService.SaveToFile();
        }

        public void Add(Person person)
        {
            var symbol = person.FirstLetter;

            if (DefineCulture(symbol) == _config.CurrentLanguage)
            {
                Add(symbol, person);
                return;
            }

            Add('#', person);
        }

        public void Add(char symbol, Person person)
        {
            List<Person> listPerson;
            if (LettersGroup.List.TryGetValue(symbol, out listPerson))
            {
                listPerson.Add(person);
            }
            else
            {
                listPerson = new List<Person>();
                listPerson.Add(person);
                LettersGroup.List.Add(symbol, listPerson);
            }
        }

        public List<Person> GetListPersons(char symbol)
        {
            List<Person> listPerson;
            LettersGroup.List.TryGetValue(symbol, out listPerson);
            return listPerson;
        }

        public string DefineCulture(char symbol)
        {
            string culture = null;
            List<char> listchars;

            if (char.IsDigit(symbol))
            {
                culture = _config.CurrentLanguage;
            }
            else
            {
                if (_config.LanguageSetting.TryGetValue(_config.CurrentLanguage, out listchars))
                {
                    if (listchars.Contains(symbol))
                    {
                        culture = _config.CurrentLanguage;
                    }
                }
            }

            return culture;
        }

        public void GroupPersonsBook()
        {
            Clear();
            foreach (var person in PersonsBookService.PersonsBook.PeopleList)
            {
                Add(person);
            }
        }

        public void Clear()
        {
            LettersGroup.List.Clear();
        }

        public void SetCurrentLanguage(string currentLanguage)
        {
            _config.CurrentLanguage = currentLanguage.ToLower();
        }

        public string GetCurrentLanguage()
        {
            return _config.CurrentLanguage.ToLower();
        }
    }
}
