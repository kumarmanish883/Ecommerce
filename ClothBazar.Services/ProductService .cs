using ClothBazar.DataBase;
using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Services
{
    public class ProductService
    {
        public Product GetProduct(int ID)
        {
            using (var context = new CBContext())
            {
                return context.products.Find(ID);

            }


        }
        public List<Product> GetProducts()
        {
            using (var context = new CBContext())
            {
                return context.products.ToList();

            }
               

        }
        public void SaveProduct(Product  product)
        {
            using (var context=new CBContext())
            {
                context.products.Add(product);
                context.SaveChanges();

            }

        }
        public void UpdateProduct(Product product)
        {
            using (var context = new CBContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

            }

        }
        public void DeleteProduct(int ID)
        {
            using (var context = new CBContext())
            {
                //context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
                var product = context.products.Find(ID);
                context.products.Remove(product);
                context.SaveChanges();

            }

        }
    }
}
