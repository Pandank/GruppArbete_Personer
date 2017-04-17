using System;
using System.Collections.Generic;

namespace GruppArbete_Personer.Models.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Address = new HashSet<Address>();
            Orders = new HashSet<Orders>();
        }

        public int UserId { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string IsAdmin { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
