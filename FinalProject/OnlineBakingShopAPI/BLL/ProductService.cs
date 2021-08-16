using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BEL;
using BLL.MapperConfig;
using DAL;

namespace BLL
{
    public class ProductService
    {
        public static ProductModel GetProductDetails(int id)
        {
            var data = ProductRepo.GetProductDetails(id);
            var productDetails = AutoMapper.Mapper.Map<Product, ProductModel>(data);
            return productDetails;
        }
        public static List<ProductModel> GetAllProductDetails()
        {
            var data = ProductRepo.GetAllProductDetails();
            var productsDetails = AutoMapper.Mapper.Map<List<Product>, List<ProductModel>>(data);
            return productsDetails;
        }

        public static ProductDetails GetProductFullDetails(int id)
        {
            var data = ProductRepo.GetProductDetails(id);
            var productDetail = AutoMapper.Mapper.Map<Product, ProductDetails>(data);
            return productDetail;
        }

        public static List<ProductDetails> GetAllProductFullDetails()
        {
            var data = ProductRepo.GetAllProductDetails();
            var productDetails = AutoMapper.Mapper.Map<List<Product>, List<ProductDetails>>(data);
            return productDetails;
        }
        public static void AddProduct(ProductModel data)
        {
            var productData = AutoMapper.Mapper.Map<ProductModel, Product>(data);
            ProductRepo.AddProduct(productData);
        }

        public static void UpdateProductDetails(ProductModel newData)
        {
            var productData = AutoMapper.Mapper.Map<ProductModel, Product>(newData);
            ProductRepo.UpdateProductDetails(productData);
        }

        public static void DeleteProduct(int id)
        {
            ProductRepo.DeleteProduct(id);
        }
    }
}