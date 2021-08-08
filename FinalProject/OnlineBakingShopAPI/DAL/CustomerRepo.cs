using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class CustomerRepo
    {
        static OnlineBakingShopEntities context;
        static CustomerRepo()
        {
            context = new OnlineBakingShopEntities();
        }

        public static Customer GetCustomerDetails(string username)
        {
            var data = context.Customers.FirstOrDefault(e => e.Username == username);
            return data;
        }
        public static List<Customer> GetAllCustomerDetails()
        {
            return context.Customers.ToList();
        }
        public static void AddCustomer(Customer data)
        {
            context.Customers.Add(data);
            context.SaveChanges();
        }

        public static void UpdateCustomerDetails(Customer newData)
        {
            var oldData = context.Customers.FirstOrDefault(user => user.Username == newData.Username);
            context.Entry(oldData).CurrentValues.SetValues(newData);
            context.SaveChanges();
        }

        public static void DeleteCustomer(string username)
        {
            var CustomerData = context.Customers.FirstOrDefault(data => data.Username == username);
            context.Customers.Remove(CustomerData);
            context.SaveChanges();
        }
    }
}