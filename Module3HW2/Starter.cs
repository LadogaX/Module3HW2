using System;
using Module3HW2.Helpers;
using Module3HW2.Models;
using Module3HW2.Models.Abstraction;
using Module3HW2.Services;

namespace Module3HW2
{
    public class Starter
    {
        public void Run()
        {
            var serviceLetterGroup = new ServiceLetterGroup();
            var personsBook = serviceLetterGroup.PersonsBookService.PersonsBook;
            PersonsBookHelper.FillPersonBook(personsBook);

            serviceLetterGroup.GroupPersonsBook(personsBook);

            LetterGroupHelper.Display(serviceLetterGroup);

            serviceLetterGroup.SaveToFile();

            serviceLetterGroup.SetCurrentLanguage("en");
            serviceLetterGroup.GroupPersonsBook(personsBook);
            LetterGroupHelper.Display(serviceLetterGroup);
        }
    }
}