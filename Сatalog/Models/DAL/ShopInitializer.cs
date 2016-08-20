using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Сatalog.Models; 
 

namespace Сatalog.Models.DAL
{
    public class ShopInitializer : DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var cars = new List<Car> 
            { 
                new Car { carName = "Acura",   descriptioncar= "It is an original small copyr",priceCar = 5 }, 
                new Car { carName= "Alfa Romeo", descriptioncar= "It is an original small copyr",    priceCar = 2 }, 
                new Car { carName = "Aston Martin",  descriptioncar= "It is an original small copyr",   priceCar = 9 }, 
                new Car { carName= "Audi",    descriptioncar= "It is an original small copyr",priceCar = 6 }, 
               
            };
            cars.ForEach(s => context.Car.Add(s));
            context.SaveChanges();

            var dolls = new List<Doll> 
            { 
                new Doll { dollName= "Acura",   descriptionDoll = "It is an original small copyr",priceDoll = 5 }, 
                new Doll {  dollName= "Alfa Romeo",descriptionDoll = "It is an original small copyr",    priceDoll = 2 }, 
                new Doll {  dollName= "Aston Martin", descriptionDoll = "It is an original small copyr",   priceDoll = 9 }, 
                new Doll{  dollName= "Audi",    descriptionDoll ="It is an original small copyr",priceDoll = 6 }, 
               
            };
            dolls.ForEach(s => context.Doll.Add(s));
            context.SaveChanges();


            var toys = new List<Toy> 
            { 
                new Toy { CarId=888,   DollId = 999 }, 
               
                
            };
            toys.ForEach(s => context.toy.Add(s));
            context.SaveChanges(); 
        }
    }
}