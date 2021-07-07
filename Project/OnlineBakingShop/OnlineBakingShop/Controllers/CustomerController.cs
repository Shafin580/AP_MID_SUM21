using OnlineBakingShop.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBakingShop.Controllers
{
    public class CustomerController : Controller
    {
        OnlineBakingShopEntities context = new OnlineBakingShopEntities();
        // GET: Customer
        public ActionResult Index()
        {
            if (Session["Username"] != null)
            {
                //if (Session["UserType"] == "Customer")
                //{
                    var product = context.Products.ToList();
                    return View(product);
                //}
                //else
                //{
                    //return RedirectToAction("Index", "Home");
                //}
                
            }

            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        public ActionResult Registration()
        {
                return View();           
        }

        [HttpPost]

        public ActionResult Registration(Customer customerInfo, Login loginInfo)
        {
            loginInfo.LoginId = customerInfo.Id;
            loginInfo.LoginUsername = customerInfo.Username;
            loginInfo.LoginEmail = customerInfo.Email;
            loginInfo.LoginPassword = customerInfo.Password;
            loginInfo.UserType = "Customer";

            var user = context.Logins.FirstOrDefault(uname => uname.LoginUsername == loginInfo.LoginUsername);

            if (user == null)
            {
                //if (ModelState.IsValid)
                //{ 
                        context.Logins.Add(loginInfo);
                        context.Customers.Add(customerInfo);
                        context.SaveChanges();
                        return RedirectToAction("Index", "Home");  
                //}
                //else
                //{
                    //return View();
                //}
                
            }
            else
            {
                ViewBag.Error = "Username or email already exist";
                return View();
            }

            
        }

        public ActionResult ProductDetails(int Id)
        {
            if (Session["Username"] != null)
            {
                //if (Session["UserType"] == "Customer")
                //{
                    var productDetails = context.Products.FirstOrDefault(details => details.Id == Id);
                    return View(productDetails);
                //}
                //else
                //{
                    //return RedirectToAction("Index", "Home");
                //}
                
            }

            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        public ActionResult ShowProfile(String Username)
        {
            if (Session["Username"] != null)
            {
                //if (Session["UserType"] == "Customer")
                //{
                    var userDetails = context.Customers.FirstOrDefault(user => user.Username == Username);
                    return View(userDetails);
                //}
                //else
                //{
                    //return RedirectToAction("Index", "Home");
                //}
                
            }

            else
            {
                return RedirectToAction("Index", "Home");
            }

            
        }

        public ActionResult EditProfile(int Id)
        {

            if (Session["Username"] != null)
            {
                //if (Session["UserType"] == "Customer")
                //{
                    var userDetails = context.Customers.FirstOrDefault(user => user.Id == Id);
                    return View(userDetails);
                //}
                //else
                //{
                    //return RedirectToAction("Index", "Home");
                //}
                
            }

            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        [HttpPost]

        public ActionResult EditProfile(Customer newData)
        {
            var oldData = context.Customers.FirstOrDefault(user => user.Id == newData.Id);
            if (ModelState.IsValid)
            {
                context.Entry(oldData).CurrentValues.SetValues(newData);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult BuyProduct(int Id)
        {

            if (Session["Username"] != null)
            {
                //if (Session["UserType"] == "Customer")
                //{
                    var productDetails = context.Products.FirstOrDefault(details => details.Id == Id);
                    ViewBag.Product = productDetails;
                    ViewBag.CustomerId = Session["CustomerId"];
                    ViewBag.TotalPrice = (productDetails.ProductPrice) + 60;
                    return View(ViewBag);
                //}
                //else
                //{
                    //return RedirectToAction("Index", "Home");
                //}
                
            }

            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        [HttpPost]

        public ActionResult BuyProduct(Transaction details)
        {
            context.Transactions.Add(details);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult TransactionHistory(int Id)
        {
            if (Session["Username"] != null)
            {
                //if (Session["UserType"] == "Customer")
                //{
                    var transactionDetails = context.Transactions.Where(t => t.CustomerId == Id).ToList();
                    return View(transactionDetails);
                //}
                //else
                //{
                    //return RedirectToAction("Index", "Home");
                //}
                
            }

            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}