using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //lägg till denna för att få valideringen att fungera
using System.Linq;
using System.Threading.Tasks;

namespace GruppArbete_Personer.Models
{
    public class Person
    {
        
        public int Id { get; set; }
        
        public string Name { get; set; }

        
        public string Email { get; set; }

        
    }
}
