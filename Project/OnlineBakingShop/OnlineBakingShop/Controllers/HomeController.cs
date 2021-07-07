using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineBakingShop.Models;

namespace OnlineBakingShop.Controllers
{
    public class HomeController : Controller
    {
        OnlineBakingShopEntities context = new OnlineBakingShopEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Login(Login login)
        {
            var user = context.Logins.FirstOrDefault(uname => uname.LoginUsername == login.LoginUsername);
            var customer = context.Customers.FirstOrDefault(uname => uname.Username == login.LoginUsername);
            var courierInfo = context.Couriers.FirstOrDefault(uname => uname.Username == login.LoginUsername);

            if (user != null)
            {
                if (user.LoginPassword == login.LoginPassword)
                {
                    if (user.UserType == "Courier")
                    {
                        var courier = context.Couriers.FirstOrDefault(uname => uname.Username == login.LoginUsername);

                        if(courier.Registered == true)
                        {
                            Session["Username"] = user.LoginUsername;
                            Session["CustomerId"] = courierInfo.Id;
                            Session["UserType"] = user.UserType;
                            return RedirectToAction("Index", "Courier");
                        }

                        else
                        {
                            ViewBag.Message = "Admin has not approved your registration yet";
                            return View();
                        }

                    }

                    else if (user.UserType == "Customer")
                    {
                        Session["Username"] = user.LoginUsername;
                        Session["CustomerId"] = customer.Id;
                        Session["UserType"] = user.UserType;
                        return RedirectToAction("Index", "Customer");
                    }

                    else if (user.UserType == "Admin")
                    {
                        Session["Username"] = user.LoginUsername;
                        Session["UserType"] = user.UserType;
                        return RedirectToAction("Index", "Admin");
                    }
                }
                else
                {
                    ViewBag.ErrorMessage = "Wrong Credentials";
                    return View();
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Wrong Credentials";
                return View();
            }

            return RedirectToAction("Index");
        }

    }
}