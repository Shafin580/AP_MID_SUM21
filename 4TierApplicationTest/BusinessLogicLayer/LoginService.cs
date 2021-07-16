using BusinessEntityLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class LoginService
    {
        public static List<String> GetLoginNames()
        {
            return LoginRepo.GetLoginNames();
        }

        /*public static List<LoginModel> GetLogin()
        {
            return null;
        }*/
    }
}
