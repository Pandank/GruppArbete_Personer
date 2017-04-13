using System.ComponentModel.DataAnnotations;

namespace GruppArbete_Personer.Models
{
    public class PeopleEditVM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        
    }
}