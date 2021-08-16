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
    public class LoginController : ApiController
    {
        [Route("api/Login/GetAll")]
        [HttpGet]
        public List<LoginModel> GetAllLoginDetails()
        {
            return LoginService.GetAllLoginDetails();
        }

        [Route("api/Login/Add")]
        [HttpPost]
        public void AddLogin(LoginModel login)
        {
            LoginService.AddLogin(login);
        }

        [Route("api/Login/{username}/Delete")]
        [HttpPost]

        public void DeleteLogin(string username)
        {
            LoginService.DeleteLogin(username);
        }

        [Route("api/Login/{username}/Edit")]
        [HttpPost]

        public void UpdateLoginDetails(LoginModel login)
        {
            LoginService.UpdateLoginDetails(login);
        }
    }
}
