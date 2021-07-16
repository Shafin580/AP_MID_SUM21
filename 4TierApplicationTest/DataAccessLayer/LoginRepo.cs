using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class LoginRepo
    {
        static OnlineBakingShopEntities context;

        static LoginRepo()
        {
            context = new OnlineBakingShopEntities();
        }

        public static List<String> GetLoginNames()
        {
            var data = context.Logins.Select(e => e.LoginUsername).ToList();
            return data;
        }
    }
}
