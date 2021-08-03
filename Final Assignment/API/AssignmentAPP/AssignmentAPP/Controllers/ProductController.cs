using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL;
using BLL;

namespace AssignmentAPP.Controllers
{
    public class ProductController : ApiController
    {
        [Route("api/Product/Names")]
        [HttpGet]
        public List<string> GetProductNames()
        {
            return ProductService.GetProductNames();
        }
        [Route("api/Product/GetAll")]
        [HttpGet]
        public List<ProductModel> GetAllProducts()
        {
            return ProductService.GetAllProduct();
        }
        [Route("api/Product/Add")]
        [HttpPost]
        public void Add(ProductModel prod)
        {
            ProductService.AddProduct(prod);
        }
        [Route("api/Product/{id}")]
        public ProductModel GetProduct(int id)
        {
            return ProductService.GetProduct(id);
        }
    }
}
