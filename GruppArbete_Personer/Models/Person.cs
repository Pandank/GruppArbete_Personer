using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //lägg till denna för att få valideringen att fungera
using System.Linq;
using System.Threading.Tasks;

namespace GruppArbete_Personer.Models
{
    public class Person
    {
        public static int PersonCount { get; set; }
        public Person()
        {
            this.Id = PersonCount;
            PersonCount++;
        }
        public int Id { get;}
        
        public string Name { get; set; }

        
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Name:{Name,-15} Email:{Email,-31} Id:{Id}";
        }
    }
}
