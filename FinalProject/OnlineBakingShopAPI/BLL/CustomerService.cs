using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BEL;
using BLL.MapperConfig;
using DAL;

namespace BLL
{
    public class CustomerService
    {
        public static CustomerModel GetCustomerDetails(string username)
        {
            var data = CustomerRepo.GetCustomerDetails(username);
            var customerDetails = AutoMapper.Mapper.Map<Customer, CustomerModel>(data);
            return customerDetails;
        }
        public static List<CustomerModel> GetAllCustomerDetails()
        {
            var data = CustomerRepo.GetAllCustomerDetails();
            var customersDetails = AutoMapper.Mapper.Map<List<Customer>, List<CustomerModel>>(data);
            return customersDetails;
        }
        public static void AddCustomer(CustomerModel data)
        {
            var customerData = AutoMapper.Mapper.Map<CustomerModel, Customer>(data);
            CustomerRepo.AddCustomer(customerData);
        }

        public static void UpdateCustomerDetails(CustomerModel newData)
        {
            var customerData = AutoMapper.Mapper.Map<CustomerModel, Customer>(newData);
            CustomerRepo.UpdateCustomerDetails(customerData);
        }

        public static void DeleteCustomer(string username)
        {
            CustomerRepo.DeleteCustomer(username);
        }
    }
}