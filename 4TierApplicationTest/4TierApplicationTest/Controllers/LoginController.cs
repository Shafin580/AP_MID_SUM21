using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLogicLayer;

namespace _4TierApplicationTest.Controllers
{
    public class LoginController : ApiController
    {
        [Route("api/Login/Names")]
        [HttpGet]
        public List<String> GetNames()
        {
            return LoginService.GetLoginNames();
        }
    }
}
