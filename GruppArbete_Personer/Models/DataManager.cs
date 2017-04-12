using System.Collections.Generic;
using System.Linq;

namespace GruppArbete_Personer.Models
{
    public static class DataManager
    {
        

        public static List<Person> personList = new List<Person>
        {
            new Person{Email = "kalle@kalle.com",Name = "Kalle Pettersson"},
            new Person{Email = "Alexander@Arana.com",Name = "Alexander Arana"},
            new Person{Email = "help@bris.com",Name = "Pelle Svanslös"},
            new Person{Email = "bjorn@bamse.se",Name = "Björn Green"},
            new Person{Email = "victoroman2@gmail.com",Name = "Victor Öman"},
        };


        

        public static void AddPerson(Person person)
        {
            personList.Add(person);
        }

        public static Person[] GetAllPersons()
        {   
            return personList.ToArray();
        }

        public static Person GetPerson(int id)
        {
            var q = personList
                .FirstOrDefault(p => p.Id == id);

            return q;
        }

        public static void EditPerson(Person person)
        {
            var personToChange = GetPerson(person.Id);

            personToChange.Name = person.Name;
            personToChange.Email = person.Email;

        }
    }
}