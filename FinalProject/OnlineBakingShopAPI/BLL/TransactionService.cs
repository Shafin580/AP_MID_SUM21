using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BEL;
using BLL.MapperConfig;
using DAL;

namespace BLL
{
    public class TransactionService
    {
        public static List<TransactionModel> GetTransactionDetails(int id)
        {
            var data = TransactionRepo.GetTransactionDetails(id);
            var transactionDetails = AutoMapper.Mapper.Map<List<Transaction>, List<TransactionModel>>(data);
            return transactionDetails;
        }
        public static List<TransactionModel> GetAllTransactionDetails()
        {
            var data = TransactionRepo.GetAllTransactionDetails();
            var transactionsDetails = AutoMapper.Mapper.Map<List<Transaction>, List<TransactionModel>>(data);
            return transactionsDetails;
        }

        public static List<TransactionDetail> GetTransactionFullDetails(int id)
        {
            var data = TransactionRepo.GetTransactionDetails(id);
            var transactionDetail = AutoMapper.Mapper.Map<List<Transaction>, List<TransactionDetail>>(data);
            return transactionDetail;
        }

        public static List<TransactionDetail> GetAllTransactionFullDetails()
        {
            var data = TransactionRepo.GetAllTransactionDetails();
            var transactionDetails = AutoMapper.Mapper.Map<List<Transaction>, List<TransactionDetail>>(data);
            return transactionDetails;
        }
        public static void AddTransaction(TransactionModel data)
        {
            var transactionData = AutoMapper.Mapper.Map<TransactionModel, Transaction>(data);
            TransactionRepo.AddTransaction(transactionData);
        }

        public static void UpdateTransactionDetails(TransactionModel newData)
        {
            var transactionData = AutoMapper.Mapper.Map<TransactionModel, Transaction>(newData);
            TransactionRepo.UpdateTransactionDetails(transactionData);
        }
    }
}