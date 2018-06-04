using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
    class ProductDBInitializer: DropCreateDatabaseAlways<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {
            IList<Product> produkty = new List<Product>();

            produkty.Add(new Product { Name = "Piłka nożna", Price = 25 });
            produkty.Add(new Product { Name = "Deska surfingowa", Price = 179 });
            produkty.Add(new Product { Name = "Buty do biegania", Price = 95 });

            context.Products.AddRange(produkty);

            base.Seed(context);
        }
    }
}
