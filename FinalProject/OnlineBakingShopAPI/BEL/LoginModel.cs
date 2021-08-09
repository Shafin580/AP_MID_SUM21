using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BEL
{
    public class LoginModel
    {
        public int LoginId { get; set; }
        public string LoginUsername { get; set; }
        public string LoginEmail { get; set; }
        public string LoginPassword { get; set; }
        public string UserType { get; set; }
    }
}