using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderRepo
    {
        static PMSEntities context;
        static OrderRepo()
        {
            context = new PMSEntities();
        }
        public static void AddOrder(order model)
        {
            context.orders.Add(model);
            context.SaveChanges();
        }
        public static List<order> GetAllOrders()
        {
            var data = context.orders.ToList();
            return data;
        }
    }
}
