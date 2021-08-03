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
    public class CategoryController : ApiController
    {
        [Route("api/Category/GetAll")]
        [HttpGet]
        public List<CategoryDetail> GetAllCategory()
        {
            return CategoryService.GetAllCategory();
        }
        [Route("api/Category/Add")]
        [HttpPost]
        public void Add(CategoryDetail cat)
        {
            CategoryService.AddCategory(cat);
        }
        [Route("api/Category/{id}")]
        public CategoryDetail GetCategory(int id)
        {
            return CategoryService.GetCategory(id);
        }
    }
}
