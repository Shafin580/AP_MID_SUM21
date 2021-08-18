using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace OnlineBakingShopAPI.Controllers
{
    [EnableCors("*", "*", "*")]
    public class CustomerController : ApiController
    {
        [Route("api/Customer/GetAll")]
        [HttpGet]
        public List<CustomerModel> GetAllCustomerDetails()
        {
            return CustomerService.GetAllCustomerDetails();
        }

        [Route("api/Customer/{username}")]
        [HttpGet]
        public CustomerModel GetCustomerDetails(string username)
        {
            return CustomerService.GetCustomerDetails(username);
        }

        [Route("api/Customer/Add")]
        [HttpPost]
        public void AddCustomer(CustomerModel customer)
        {
            CustomerService.AddCustomer(customer);
        }

        [Route("api/Customer/{username}/Delete")]
        [HttpPost]

        public void DeleteCustomer(string username)
        {
            CustomerService.DeleteCustomer(username);
        }

        [Route("api/Customer/{username}/Edit")]
        [HttpPost]

        public void UpdateCustomerDetails(CustomerModel customer)
        {
            CustomerService.UpdateCustomerDetails(customer);
        }
    }
}
