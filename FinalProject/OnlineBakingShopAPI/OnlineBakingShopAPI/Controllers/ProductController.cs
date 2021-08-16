using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlineBakingShopAPI.Controllers
{
    public class ProductController : ApiController
    {
        [Route("api/Product/GetAll")]
        [HttpGet]
        public List<ProductModel> GetAllProductDetails()
        {
            return ProductService.GetAllProductDetails();
        }

        [Route("api/Product/{id}")]
        [HttpGet]
        public ProductModel GetProductDetails(int id)
        {
            return ProductService.GetProductDetails(id);
        }

        [Route("api/Product/All/Details")]
        [HttpGet]
        public List<ProductDetails> GetAllProductFullDetails()
        {
            return ProductService.GetAllProductFullDetails();
        }
        [Route("api/Product/{id}/Details")]
        [HttpGet]
        public ProductDetails GetProductFullDetails(int id)
        {
            return ProductService.GetProductFullDetails(id);
        }

        [Route("api/Product/Add")]
        [HttpPost]
        public void AddProduct(ProductModel product)
        {
            ProductService.AddProduct(product);
        }

        [Route("api/Product/{id}/Delete")]
        [HttpPost]

        public void DeleteProduct(int id)
        {
            ProductService.DeleteProduct(id);
        }

        [Route("api/Product/{id}/Edit")]
        [HttpPost]

        public void UpdateProductDetails(ProductModel product)
        {
            ProductService.UpdateProductDetails(product);
        }
    }
}
