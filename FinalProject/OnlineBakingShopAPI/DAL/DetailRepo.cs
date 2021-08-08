using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class DetailRepo
    {
        static OnlineBakingShopEntities context;
        static DetailRepo()
        {
            context = new OnlineBakingShopEntities();
        }

        public static Detail GetDetailDetails(int id)
        {
            var data = context.Details.FirstOrDefault(e => e.Id == id);
            return data;
        }
        public static List<Detail> GetAllDetailDetails()
        {
            return context.Details.ToList();
        }
        public static void AddDetail(Detail data)
        {
            context.Details.Add(data);
            context.SaveChanges();
        }

        public static void UpdateDetailDetails(Detail newData)
        {
            var oldData = context.Details.FirstOrDefault(data => data.Id == newData.Id);
            context.Entry(oldData).CurrentValues.SetValues(newData);
            context.SaveChanges();
        }

        public static void DeleteDetail(int id)
        {
            var DetailData = context.Details.FirstOrDefault(data => data.Id == id);
            context.Details.Remove(DetailData);
            context.SaveChanges();
        }
    }
}