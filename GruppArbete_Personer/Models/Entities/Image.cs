using System;
using System.Collections.Generic;

namespace GruppArbete_Personer.Models.Entities
{
    public partial class Image
    {
        public int ImageId { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
