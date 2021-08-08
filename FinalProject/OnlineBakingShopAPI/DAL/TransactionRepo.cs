using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class TransactionRepo
    {
        static OnlineBakingShopEntities context;
        static TransactionRepo()
        {
            context = new OnlineBakingShopEntities();
        }

        public static List<Transaction> GetTransactionDetails(int id)
        {
            var data = context.Transactions.Where(t => t.CustomerId == id).ToList();
            return data;
        }
        public static List<Transaction> GetAllTransactionDetails()
        {
            return context.Transactions.ToList();
        }
        public static void AddTransaction(Transaction data)
        {
            context.Transactions.Add(data);
            context.SaveChanges();
        }

        public static void UpdateTransactionDetails(Transaction newData)
        {
            var oldData = context.Transactions.FirstOrDefault(data => data.Id == newData.Id);
            context.Entry(oldData).CurrentValues.SetValues(newData);
            context.SaveChanges();
        }
    }
}