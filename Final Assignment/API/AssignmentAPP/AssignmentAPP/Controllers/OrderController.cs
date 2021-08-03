using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL;
using BLL;

namespace AssignmentAPP.Controllers
{
    public class OrderController : ApiController
    {
        [Route("api/Order/GetAll")]
        [HttpGet]
        public List<OrderDetail> GetAllOrder()
        {
            return OrderService.GetAllOrder();
        }
        [Route("api/Order/Add")]
        [HttpPost]
        public void Add(OrderDetail ord)
        {
            OrderService.AddOrder(ord);
        }
    }
}
