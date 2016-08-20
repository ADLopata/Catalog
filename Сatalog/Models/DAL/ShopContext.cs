using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Сatalog.Models.DAL
{
    public class ShopContext: DbContext
    {
        
       
        public DbSet<Doll> Doll { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Toy> toy { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 
        }

    }
}