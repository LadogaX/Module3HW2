using Module3HW2.Models;
using Module3HW2.Models.Comparers;

namespace Module3HW2.Helpers
{
    public static class PersonsBookHelper
    {
        public static void FillPersonBook(PersonsBook personsBook)
        {
            personsBook.PeopleList.Add(new Person() { FirstName = "Marvin", LastName = "Garcia", EMail = "Marvin@gmail.com", Phone = "+380(063)132 - 67 - 71" });
            personsBook.PeopleList.Add(new Person() { FirstName = "Vernon", LastName = "Gonzalez", EMail = "Vernon@gmail.com", Phone = "+380(063)823 - 45 - 86" });
            personsBook.PeopleList.Add(new Person() { FirstName = "Juan", LastName = "Taylor", EMail = "Juan@gmail.com", Phone = "+380(063)707 - 24 - 27" });
            personsBook.PeopleList.Add(new Person() { FirstName = "Rodney", LastName = "Ross", EMail = "Rodney@gmail.com", Phone = "+380(063)727 - 31 - 50" });
            personsBook.PeopleList.Add(new Person() { FirstName = "Daniel", LastName = "Smith", EMail = "Daniel@gmail.com", Phone = "+380(063)396 - 31 - 05" });
            personsBook.PeopleList.Add(new Person() { FirstName = "Danny", LastName = "Moran", EMail = "Danny@gmail.com", Phone = "+380(063)910 - 69 - 67" });
            personsBook.PeopleList.Add(new Person() { FirstName = "Gilbert", LastName = "Hicks", EMail = "Gilbert@gmail.com", Phone = "+380(063)710 - 96 - 58" });
            personsBook.PeopleList.Add(new Person() { FirstName = "John", LastName = "Torres", EMail = "John@gmail.com", Phone = "+380(063)560 - 92 - 77" });
            personsBook.PeopleList.Add(new Person() { FirstName = "James", LastName = "Weber", EMail = "James@gmail.com", Phone = "+380(063)524 - 47 - 15" });
            personsBook.PeopleList.Add(new Person() { FirstName = "Robert", LastName = "Moore", EMail = "Robert@gmail.com", Phone = "+380(063)693 - 80 - 45" });

            personsBook.PeopleList.Add(new Person() { FirstName = "Андреев", LastName = "Иван", EMail = "naasf@domy.me", Phone = "+038(099)734 - 01 - 99" });
            personsBook.PeopleList.Add(new Person() { FirstName = "Сычев", LastName = "Тимофей", EMail = "jonafah@azwav.site", Phone = "+038(099)613 - 77 - 35" });
            personsBook.PeopleList.Add(new Person() { FirstName = "Богданов", LastName = "Дамир", EMail = "lwmisaacs@greendike.com", Phone = "+038(099)952 - 36 - 48" });
            personsBook.PeopleList.Add(new Person() { FirstName = "Щербаков", LastName = "Кирилл", EMail = "vengersvetlaya@hungta2.com", Phone = "+038(099)832 - 00 - 13" });
            personsBook.PeopleList.Add(new Person() { FirstName = "Панфилов", LastName = "Арсений", EMail = "dougatron3030@eluvit.com", Phone = "+038(099)368 - 66 - 70" });
            personsBook.PeopleList.Add(new Person() { FirstName = "Федоров", LastName = "Гордей", EMail = "jkkstmar@hungta2.com", Phone = "+038(099)386 - 83 - 05" });
            personsBook.PeopleList.Add(new Person() { FirstName = "Ковалев", LastName = "Александр", EMail = "rockcrkcat@sungkian.com", Phone = "+038(099)972 - 06 - 65" });
            personsBook.PeopleList.Add(new Person() { FirstName = "Кондрашов", LastName = "Сергей", EMail = "nolijose@readt.site", Phone = "+038(099)488 - 10 - 60" });
            personsBook.PeopleList.Add(new Person() { FirstName = "Зотов", LastName = "Михаил", EMail = "grisharapoport@azwn.site", Phone = "+038(099)487 - 42 - 00" });
            personsBook.PeopleList.Add(new Person() { FirstName = "Алисеев", LastName = "Егор", EMail = "sprogman@boranora.com", Phone = "+038(099)845 - 49 - 59 " });

            personsBook.PeopleList.Add(new Person() { FirstName = "1_John", LastName = "Torres", EMail = "John@gmail.com", Phone = "+380(063)560 - 92 - 77" });
            personsBook.PeopleList.Add(new Person() { FirstName = "7-James", LastName = "Weber", EMail = "James@gmail.com", Phone = "+380(063)524 - 47 - 15" });
            personsBook.PeopleList.Add(new Person() { FirstName = "9 Robert", LastName = "Moore", EMail = "Robert@gmail.com", Phone = "+380(063)693 - 80 - 45" });

            personsBook.PeopleList.Add(new Person() { FirstName = "_Панфилов", LastName = "Арсений", EMail = "dougatron3030@eluvit.com", Phone = "+038(099)368 - 66 - 70" });
            personsBook.PeopleList.Add(new Person() { FirstName = "5*Федоров", LastName = "Гордей", EMail = "jkkstmar@hungta2.com", Phone = "+038(099)386 - 83 - 05" });
            personsBook.PeopleList.Add(new Person() { FirstName = "!Ковалев", LastName = "Александр", EMail = "rockcrkcat@sungkian.com", Phone = "+038(099)972 - 06 - 65" });

            personsBook.PeopleList.Sort(new PersonFullNameComparer());
        }
    }
}
