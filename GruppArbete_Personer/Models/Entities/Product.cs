using System;
using System.Collections.Generic;

namespace GruppArbete_Personer.Models.Entities
{
    public partial class Product
    {
        public Product()
        {
            CategoryToProduct = new HashSet<CategoryToProduct>();
            Image = new HashSet<Image>();
            OrdersByProduct = new HashSet<OrdersByProduct>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime Date { get; set; }
        public byte? IsHidden { get; set; }

        public virtual ICollection<CategoryToProduct> CategoryToProduct { get; set; }
        public virtual ICollection<Image> Image { get; set; }
        public virtual ICollection<OrdersByProduct> OrdersByProduct { get; set; }
    }
}
