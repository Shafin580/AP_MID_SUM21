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
    public class CourierController : ApiController
    {
        [Route("api/Courier/GetAll")]
        [HttpGet]
        public List<CourierModel> GetAllCourierDetails()
        {
            return CourierService.GetAllCourierDetails();
        }

        [Route("api/Courier/{username}")]
        [HttpGet]
        public CourierModel GetCourierDetails(string username)
        {
            return CourierService.GetCourierDetails(username);
        }

        [Route("api/Courier/Add")]
        [HttpPost]
        public void AddCourier(CourierModel courier)
        {
            CourierService.AddCourier(courier);
        }
        [Route("api/Courier/All/Details")]
        [HttpGet]
        public List<CourierDetail> GetAllCourierFullDetails()
        {
            return CourierService.GetAllCourierFullDetails();
        }
        [Route("api/Courier/{username}/Details")]
        [HttpGet]
        public CourierDetail GetCourierFullDetails(string username)
        {
            return CourierService.GetCourierFullDetails(username);
        }

        [Route("api/Courier/{username}/Delete")]
        [HttpPost]
        
        public void DeleteCourier(string username)
        {
            CourierService.DeleteCourier(username);
        }

        [Route("api/Courier/{username}/Edit")]
        [HttpPost]

        public void UpdateCourierDetails(CourierModel courier)
        {
            CourierService.UpdateCourierDetails(courier);
        }
    }
}
