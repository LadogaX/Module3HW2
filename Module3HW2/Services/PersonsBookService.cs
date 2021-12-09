using System.IO;
using System.Text.Json;
using Newtonsoft.Json;
using Module3HW2.Models;
using Module3HW2.Models.Abstraction;

namespace Module3HW2.Services
{
    public class PersonsBookService : IPersonsBookService
    {
        public PersonsBookService()
        {
           PersonsBook = new PersonsBook();
        }

        public PersonsBook PersonsBook { get; set; }

        public void LoadFromFile(string dataFileName = "Persons.json")
        {
            var dataFile = File.ReadAllText(dataFileName);
            PersonsBook = JsonConvert.DeserializeObject<PersonsBook>(dataFile);
        }

        public void SaveToFile(string dataFileName = "Persons.json")
        {
            var json = JsonConvert.SerializeObject(PersonsBook, Formatting.Indented);
            File.WriteAllText(dataFileName, json);
        }
    }
}
