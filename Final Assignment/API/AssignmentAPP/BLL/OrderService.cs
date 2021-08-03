using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using BLL.MapperConfig;
using DAL;
namespace BLL
{
    public class OrderService
    {
        public static void AddOrder(OrderDetail model)
        {
            var data = AutoMapper.Mapper.Map<OrderDetail, order>(model);
            OrderRepo.AddOrder(data);
        }

        public static List<OrderDetail> GetAllOrder()
        {
            var data = OrderRepo.GetAllOrders();
            var ord = AutoMapper.Mapper.Map<List<order>, List<OrderDetail>>(data);
            return ord;
        }
    }
}
