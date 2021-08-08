using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class TypeRepo
    {
        static OnlineBakingShopEntities context;
        static TypeRepo()
        {
            context = new OnlineBakingShopEntities();
        }

        public static Type GetTypeDetails(int id)
        {
            var data = context.Types.FirstOrDefault(e => e.Id == id);
            return data;
        }
        public static List<Type> GetAllTypeDetails()
        {
            return context.Types.ToList();
        }
        public static void AddType(Type data)
        {
            context.Types.Add(data);
            context.SaveChanges();
        }

        public static void UpdateTypeDetails(Type newData)
        {
            var oldData = context.Types.FirstOrDefault(data => data.Id == newData.Id);
            context.Entry(oldData).CurrentValues.SetValues(newData);
            context.SaveChanges();
        }

        public static void DeleteType(int id)
        {
            var TypeData = context.Types.FirstOrDefault(data => data.Id == id);
            context.Types.Remove(TypeData);
            context.SaveChanges();
        }
    }
}