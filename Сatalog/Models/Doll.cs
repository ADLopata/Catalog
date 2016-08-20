using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Сatalog.Models
{
    public class Doll
    {
        public int DollId { get; set; }

        public string dollName { get; set; }
        public string descriptionDoll { get; set; }
        public int priceDoll { get; set; }
        public byte[] photoDoll { get; set; }

        public virtual ICollection<Toy> toy { get; set; }
    }
}