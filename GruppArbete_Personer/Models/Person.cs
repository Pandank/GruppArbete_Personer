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

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Dude write an email...")]
        [Display(Name = "E-mail")]
        [RegularExpression("([A-Za-z0-9_%+-])+@acme\\.com",ErrorMessage = "only acme.com")]
        [Required]
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Name:{Name,-15} Email:{Email,-31} Id:{Id}";
        }
    }
}
