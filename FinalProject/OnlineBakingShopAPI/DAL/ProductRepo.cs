using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class ProductRepo
    {
        static OnlineBakingShopEntities context;
        static ProductRepo()
        {
            context = new OnlineBakingShopEntities();
        }

        public static Product GetProductDetails(int id)
        {
            var data = context.Products.FirstOrDefault(e => e.Id == id);
            return data;
        }
        public static List<Product> GetAllProductDetails()
        {
            return context.Products.ToList();
        }
        public static void AddProduct(Product data)
        {
            context.Products.Add(data);
            context.SaveChanges();
        }

        public static void UpdateProductDetails(Product newData)
        {
            var oldData = context.Products.FirstOrDefault(data => data.Id == newData.Id);
            context.Entry(oldData).CurrentValues.SetValues(newData);
            context.SaveChanges();
        }

        public static void DeleteProduct(int id)
        {
            var ProductData = context.Products.FirstOrDefault(data => data.Id == id);
            context.Products.Remove(ProductData);
            context.SaveChanges();
        }
    }
}