using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BEL;
using BLL.MapperConfig;
using DAL;

namespace BLL
{
    public class MenuService
    {
        public static MenuModel GetMenuDetails(int id)
        {
            var data = MenuRepo.GetMenuDetails(id);
            var menuDetails = AutoMapper.Mapper.Map<Menu, MenuModel>(data);
            return menuDetails;
        }
        public static List<MenuModel> GetAllMenuDetails()
        {
            var data = MenuRepo.GetAllMenuDetails();
            var menusDetails = AutoMapper.Mapper.Map<List<Menu>, List<MenuModel>>(data);
            return menusDetails;
        }

        public static MenuDetail GetMenuFullDetails(int id)
        {
            var data = MenuRepo.GetMenuDetails(id);
            var menuDetail = AutoMapper.Mapper.Map<Menu, MenuDetail>(data);
            return menuDetail;
        }

        public static List<MenuDetail> GetAllMenuFullDetails()
        {
            var data = MenuRepo.GetAllMenuDetails();
            var menuDetails = AutoMapper.Mapper.Map<List<Menu>, List<MenuDetail>>(data);
            return menuDetails;
        }
        public static void AddMenu(MenuModel data)
        {
            var menuData = AutoMapper.Mapper.Map<MenuModel, Menu>(data);
            MenuRepo.AddMenu(menuData);
        }

        public static void UpdateMenuDetails(MenuModel newData)
        {
            var menuData = AutoMapper.Mapper.Map<MenuModel, Menu>(newData);
            MenuRepo.UpdateMenuDetails(menuData);
        }

        public static void DeleteMenu(int id)
        {
            MenuRepo.DeleteMenu(id);
        }
    }
}