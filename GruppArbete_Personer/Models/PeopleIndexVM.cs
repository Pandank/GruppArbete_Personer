using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GruppArbete_Personer.Models
{
    public class PeopleIndexVM
    {
        private bool _showAsHighlighted;

        [Display(Name = "First name")]
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        public int Id { get; set; } 

        public bool ShowAsHighlighted
        {
            get => Regex.IsMatch(this.Email, "([\\w%+-])+@acme\\.com");

            set => _showAsHighlighted = value;
        }

        public override string ToString()
        {
            return $"Name:{Name,-15} Email:{Email,-31} Id:{Id}";
        }
    }
}
