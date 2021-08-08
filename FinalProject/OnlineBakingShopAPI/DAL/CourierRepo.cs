using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class CourierRepo
    {
        static OnlineBakingShopEntities context;
        static CourierRepo()
        {
            context = new OnlineBakingShopEntities();
        }

        public static Courier GetCourierDetails(string username)
        {
            var data = context.Couriers.FirstOrDefault(e => e.Username == username);
            return data;
        }
        public static List<Courier> GetAllCourierDetails()
        {
            return context.Couriers.ToList();
        }
        public static void AddCourier(Courier data)
        {
            context.Couriers.Add(data);
            context.SaveChanges();
        }

        public static void UpdateCourierDetails(Courier newData)
        {
            var oldData = context.Couriers.FirstOrDefault(user => user.Username == newData.Username);
            context.Entry(oldData).CurrentValues.SetValues(newData);
            context.SaveChanges();
        }

        public static void DeleteCourier(string username)
        {
            var CourierData = context.Couriers.FirstOrDefault(data => data.Username == username);
            context.Couriers.Remove(CourierData);
            context.SaveChanges();
        }
    }
}