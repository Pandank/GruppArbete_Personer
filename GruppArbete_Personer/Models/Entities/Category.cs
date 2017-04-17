using System;
using System.Collections.Generic;

namespace GruppArbete_Personer.Models.Entities
{
    public partial class Category
    {
        public Category()
        {
            CategoryToProduct = new HashSet<CategoryToProduct>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CategoryToProduct> CategoryToProduct { get; set; }
    }
}
