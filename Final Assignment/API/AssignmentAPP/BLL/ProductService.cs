using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using BLL.MapperConfig;
using DAL;

namespace BLL
{
    public class ProductService
    {
        public static void AddProduct(ProductModel model)
        {
            var data = AutoMapper.Mapper.Map<ProductModel, product>(model);
            ProductRepo.AddProduct(data);
        }
        public static ProductModel GetProduct(int id)
        {
            var data = ProductRepo.GetProduct(id);
            var prod = AutoMapper.Mapper.Map<product, ProductModel>(data);
            return prod;
        }
        public static List<ProductModel> GetAllProduct()
        {
            var data = ProductRepo.GetAllProducts();
            var prod = AutoMapper.Mapper.Map<List<product>, List<ProductModel>>(data);
            return prod;
        }

        public static List<string> GetProductNames()
        {
            var data = ProductRepo.GetProductNames();
            return data;
        }
    }
}
