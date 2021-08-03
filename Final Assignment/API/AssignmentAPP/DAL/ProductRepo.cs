using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepo
    {
        static PMSEntities context;
        static ProductRepo()
        {
            context = new PMSEntities();
        }
        public static void AddProduct(product model)
        {
            context.products.Add(model);
            context.SaveChanges();
        }
        public static List<product> GetAllProducts()
        {
            var data = context.products.ToList();
            return data;
        }
        public static product GetProduct(int id)
        {
            var data = context.products.FirstOrDefault(e => e.id == id);
            return data;
        }

        public static List<string> GetProductNames()
        {
            var data = context.products.Select(e => e.name).ToList();
            return data;
        }
    }
}
