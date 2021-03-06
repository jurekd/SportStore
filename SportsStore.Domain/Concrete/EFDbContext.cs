﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SportsStore.Domain.Entities;
using System.Data.Entity;
namespace SportsStore.Domain.Concrete
{
    public class EFDbContext : DbContext

    {
        public EFDbContext():base("EFDbContext")
        {
            Database.SetInitializer<EFDbContext>(new ProductDBInitializer());

        }
        public DbSet<Product> Products { get; set; }
    }


}
