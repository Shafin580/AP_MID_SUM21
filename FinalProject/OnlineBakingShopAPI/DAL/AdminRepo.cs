using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class AdminRepo
    {
        static OnlineBakingShopEntities context;
        static AdminRepo()
        {
            context = new OnlineBakingShopEntities();
        }

        public static Admin GetAdminDetails(string username)
        {
            var data = context.Admins.FirstOrDefault(e => e.Username == username);
            return data;
        }
        public static List<Admin> GetAllAdminDetails()
        {
            return context.Admins.ToList();
        }
        public static void AddAdmin(Admin data)
        {
            context.Admins.Add(data);
            context.SaveChanges();
        }

        public static void UpdateAdminDetails(Admin newData)
        {
            var oldData = context.Admins.FirstOrDefault(user => user.Username == newData.Username);
            context.Entry(oldData).CurrentValues.SetValues(newData);
            context.SaveChanges();
        }

        public static void DeleteAdmin(string username)
        {
            var AdminData = context.Admins.FirstOrDefault(data => data.Username == username);
            context.Admins.Remove(AdminData);
            context.SaveChanges();
        }
    }
}