using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.DataBase
{
    public class CBContext:DbContext
    {
        public CBContext():base("ClothBazarConnection")
        {

        }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }

    }
}
