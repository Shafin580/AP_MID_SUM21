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
    public class AdminController : ApiController
    {
        [Route("api/Admin/GetAll")]
        [HttpGet]
        public List<AdminModel> GetAllAdminDetails()
        {
            return AdminService.GetAllAdminDetails();
        }

        [Route("api/Admin/{username}")]
        [HttpGet]
        public AdminModel GetAdminDetails(string username)
        {
            return AdminService.GetAdminDetails(username);
        }

        [Route("api/Admin/Add")]
        [HttpPost]
        public void AddAdmin(AdminModel admin)
        {
            AdminService.AddAdmin(admin);
        }

        [Route("api/Admin/{username}/Delete")]
        [HttpPost]

        public void DeleteAdmin(string username)
        {
            AdminService.DeleteAdmin(username);
        }

        [Route("api/Admin/{username}/Edit")]
        [HttpPost]

        public void UpdateAdminDetails(AdminModel admin)
        {
            AdminService.UpdateAdminDetails(admin);
        }
    }
}
