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
    public class MenuController : ApiController
    {
        [Route("api/Menu/GetAll")]
        [HttpGet]
        public List<MenuModel> GetAllMenuDetails()
        {
            return MenuService.GetAllMenuDetails();
        }

        [Route("api/Menu/{id}")]
        [HttpGet]
        public MenuModel GetMenuDetails(int id)
        {
            return MenuService.GetMenuDetails(id);
        }

        [Route("api/Menu/All/Details")]
        [HttpGet]
        public List<MenuDetail> GetAllMenuFullDetails()
        {
            return MenuService.GetAllMenuFullDetails();
        }
        [Route("api/Menu/{id}/Details")]
        [HttpGet]
        public MenuDetail GetMenuFullDetails(int id)
        {
            return MenuService.GetMenuFullDetails(id);
        }

        [Route("api/Menu/Add")]
        [HttpPost]
        public void AddMenu(MenuModel menu)
        {
            MenuService.AddMenu(menu);
        }

        [Route("api/Menu/{id}/Delete")]
        [HttpPost]

        public void DeleteMenu(int id)
        {
            MenuService.DeleteMenu(id);
        }

        [Route("api/Menu/{id}/Edit")]
        [HttpPost]

        public void UpdateMenuDetails(MenuModel menu)
        {
            MenuService.UpdateMenuDetails(menu);
        }
    }
}
