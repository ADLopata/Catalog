using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Сatalog.Models
{
    public class Toy
    {
        public int ToyId { get; set; }
        public int CarId { get; set; }
        public int DollId { get; set; }

        public string toyName { get; set; }
        public string descriptionToy { get; set; }
        public int price { get; set; }
        public byte[] Photo { get; set; }
        public virtual Car Car { get; set; }
        public virtual Doll Doll { get; set; }
    }
}