using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace OnlineBakingShopAPI.Controllers
{
    [EnableCors("*", "*", "*")]
    public class TypeController : ApiController
    {
        [Route("api/Type/GetAll")]
        [HttpGet]
        public List<TypeModel> GetAllTypeDetails()
        {
            return TypeService.GetAllTypeDetails();
        }

        [Route("api/Type/{id}")]
        [HttpGet]
        public TypeModel GetTypeDetails(int id)
        {
            return TypeService.GetTypeDetails(id);
        }

        [Route("api/Type/All/Details")]
        [HttpGet]
        public List<TypeDetail> GetAllTypeFullDetails()
        {
            return TypeService.GetAllTypeFullDetails();
        }
        [Route("api/Type/{id}/Details")]
        [HttpGet]
        public TypeDetail GetTypeFullDetails(int id)
        {
            return TypeService.GetTypeFullDetails(id);
        }

        [Route("api/Type/Add")]
        [HttpPost]
        public void AddType(TypeModel type)
        {
            TypeService.AddType(type);
        }

        [Route("api/Type/{id}/Delete")]
        [HttpPost]

        public void DeleteType(int id)
        {
            TypeService.DeleteType(id);
        }

        [Route("api/Type/{id}/Edit")]
        [HttpPost]

        public void UpdateTypeDetails(TypeModel type)
        {
            TypeService.UpdateTypeDetails(type);
        }
    }
}
