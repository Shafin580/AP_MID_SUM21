using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class MenuRepo
    {
        static OnlineBakingShopEntities context;
        static MenuRepo()
        {
            context = new OnlineBakingShopEntities();
        }

        public static Menu GetMenuDetails(int id)
        {
            var data = context.Menus.FirstOrDefault(e => e.Id == id);
            return data;
        }
        public static List<Menu> GetAllMenuDetails()
        {
            return context.Menus.ToList();
        }
        public static void AddMenu(Menu data)
        {
            context.Menus.Add(data);
            context.SaveChanges();
        }

        public static void UpdateMenuDetails(Menu newData)
        {
            var oldData = context.Menus.FirstOrDefault(data => data.Id == newData.Id);
            context.Entry(oldData).CurrentValues.SetValues(newData);
            context.SaveChanges();
        }

        public static void DeleteMenu(int id)
        {
            var MenuData = context.Menus.FirstOrDefault(data => data.Id == id);
            context.Menus.Remove(MenuData);
            context.SaveChanges();
        }
    }
}