using System;
using System.Collections.Generic;

namespace GruppArbete_Personer.Models.Entities
{
    public partial class Orders
    {
        public Orders()
        {
            OrdersByProduct = new HashSet<OrdersByProduct>();
        }

        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }

        public virtual ICollection<OrdersByProduct> OrdersByProduct { get; set; }
        public virtual Customer User { get; set; }
    }
}
