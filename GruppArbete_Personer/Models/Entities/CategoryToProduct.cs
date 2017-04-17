using System;
using System.Collections.Generic;

namespace GruppArbete_Personer.Models.Entities
{
    public partial class CategoryToProduct
    {
        public int CtpId { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}
