﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineBakingShop.Models;

namespace OnlineBakingShop.Controllers
{
    public class CourierController : Controller
    {
        OnlineBakingShopEntities context = new OnlineBakingShopEntities();
        // GET: Courier
        public ActionResult Index()
        {
            if(Session["Username"] != null)
            {
                //if (Session["UserType"] == "Customer")
                //{
                    return View();
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

        public ActionResult Registration(Courier courierInfo, Login loginInfo)
        {
            loginInfo.LoginId = courierInfo.Id;
            loginInfo.LoginUsername = courierInfo.Username;
            loginInfo.LoginEmail = courierInfo.Email;
            loginInfo.LoginPassword = courierInfo.Password;
            loginInfo.UserType = "Courier";

            var user = context.Logins.FirstOrDefault(uname => uname.LoginUsername == loginInfo.LoginUsername);

            if (user == null)
            {
                context.Logins.Add(loginInfo);
                context.Couriers.Add(courierInfo);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Username or email already exist";
                return View();
            }
  
        }

        public ActionResult ShowProfile(String Username)
        {
            if (Session["Username"] != null)
            {
                //if (Session["UserType"] == "Customer")
                //{
                    var userDetails = context.Couriers.FirstOrDefault(user => user.Username == Username);
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
                    var userDetails = context.Couriers.FirstOrDefault(user => user.Id == Id);
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

        public ActionResult EditProfile(Courier newData)
        {
            var oldData = context.Couriers.FirstOrDefault(user => user.Id == newData.Id);
            context.Entry(oldData).CurrentValues.SetValues(newData);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}