using System;
using System.Collections.Generic;

namespace GruppArbete_Personer.Models.Entities
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int UserId { get; set; }

        public virtual Customer User { get; set; }
    }
}
