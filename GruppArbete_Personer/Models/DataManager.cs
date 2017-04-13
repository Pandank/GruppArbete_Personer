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




        public static void AddPerson(PeopleCreateVM viewModel)
        {
            var person = new Person
            {
                Email = viewModel.Email,
                Name = viewModel.Name
            };


            personList.Add(person);
        }

        public static PeopleIndexVM[] GetAllPersons()
        {
            var peoplelist = personList
                .Select(p => new PeopleIndexVM
                {
                    Name = p.Name,
                    Email = p.Email,
                    Id = p.Id
                }).ToArray();

            return peoplelist;
        }

        public static Person GetPerson(int id)
        {
            var q = personList
                .FirstOrDefault(p => p.Id == id);

            return q;
        }

        public static void EditPerson(PeopleEditVM viewModel)
        {
            var personToChange = GetPerson(viewModel.Id);

            personToChange.Name = viewModel.Name;
            personToChange.Email = viewModel.Email;

        }


    }
}