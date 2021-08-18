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
    public class DetailController : ApiController
    {
        [Route("api/Detail/GetAll")]
        [HttpGet]
        public List<DetailModel> GetAllDetailDetails()
        {
            return DetailService.GetAllDetailDetails();
        }

        [Route("api/Detail/{id}")]
        [HttpGet]
        public DetailModel GetDetailDetails(int id)
        {
            return DetailService.GetDetailDetails(id);
        }

        [Route("api/Detail/Add")]
        [HttpPost]
        public void AddDetail(DetailModel detail)
        {
            DetailService.AddDetail(detail);
        }

        [Route("api/Detail/{id}/Delete")]
        [HttpPost]

        public void DeleteDetail(int id)
        {
            DetailService.DeleteDetail(id);
        }

        [Route("api/Detail/{id}/Edit")]
        [HttpPost]

        public void UpdateDetailDetails(DetailModel detail)
        {
            DetailService.UpdateDetailDetails(detail);
        }
    }
}
