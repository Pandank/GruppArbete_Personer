using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GruppArbete_Personer.Models
{
    public class PeopleCreateVM
    {
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage = "It tickles")]
        public bool AcceptTerms { get; set; }   
    }
}
