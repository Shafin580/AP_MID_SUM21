using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class LoginRepo
    {
        static OnlineBakingShopEntities context;
        static LoginRepo()
        {
            context = new OnlineBakingShopEntities();
        }
        public static List<Login> GetAllLoginDetails()
        {
            return context.Logins.ToList();
        }

        public static Login GetLoginDetails(string username)
        {
            var data = context.Logins.FirstOrDefault(e => e.LoginUsername == username);
            return data;
        }
        public static void AddLogin(Login data)
        {
            context.Logins.Add(data);
            context.SaveChanges();
        }

        public static void DeleteLogin(string username)
        {
            var LoginData = context.Logins.FirstOrDefault(data => data.LoginUsername == username);
            context.Logins.Remove(LoginData);
            context.SaveChanges();
        }

        public static void UpdateLoginDetails(Login newData)
        {
            var oldData = context.Logins.FirstOrDefault(user => user.LoginUsername == newData.LoginUsername);
            context.Entry(oldData).CurrentValues.SetValues(newData);
            context.SaveChanges();
        }
    }
}