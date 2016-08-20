using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Сatalog.Models
{
    public class Car
    {
        public Car() { }
        public int CarId { get; set; }
       
        public string carName { get; set; }
        public string descriptioncar { get; set; }
        public int priceCar { get; set; }
        public byte[] Photo { get; set; }
      
        public virtual ICollection<Toy> Toy { get; set; }
    }
}