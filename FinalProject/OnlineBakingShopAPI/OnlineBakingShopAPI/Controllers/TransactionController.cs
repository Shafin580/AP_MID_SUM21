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
    public class TransactionController : ApiController
    {
        [Route("api/Transaction/GetAll")]
        [HttpGet]
        public List<TransactionModel> GetAllTransactionDetails()
        {
            return TransactionService.GetAllTransactionDetails();
        }

        [Route("api/Transaction/{id}")]
        [HttpGet]
        public List<TransactionModel> GetTransactionDetails(int id)
        {
            return TransactionService.GetTransactionDetails(id);
        }

        [Route("api/Transaction/All/Details")]
        [HttpGet]
        public List<TransactionDetail> GetAllTransactionFullDetails()
        {
            return TransactionService.GetAllTransactionFullDetails();
        }
        [Route("api/Transaction/{id}/Details")]
        [HttpGet]
        public List<TransactionDetail> GetTransactionFullDetails(int id)
        {
            return TransactionService.GetTransactionFullDetails(id);
        }

        [Route("api/Transaction/Add")]
        [HttpPost]
        public void AddTransaction(TransactionModel transaction)
        {
            TransactionService.AddTransaction(transaction);
        }

        [Route("api/Transaction/{id}/Edit")]
        [HttpPost]

        public void UpdateTransactionDetails(TransactionModel transaction)
        {
            TransactionService.UpdateTransactionDetails(transaction);
        }
    }
}
