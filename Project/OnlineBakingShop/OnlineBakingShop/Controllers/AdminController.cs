using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineBakingShop.Models;

namespace OnlineBakingShop.Controllers
{
    public class AdminController : Controller
    {
        OnlineBakingShopEntities context = new OnlineBakingShopEntities();
        // GET: Admin
        public ActionResult Index()
        {
            if (Session["Username"] != null)
            {
                //if (Session["UserType"] == "Admin")
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

        public ActionResult InsertProductCategory()
        {
            if (Session["Username"] != null)
            {
                //if (Session["UserType"] == "Admin")
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

        [HttpPost]

        public ActionResult InsertProductCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Add(category);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult InsertProduct()
        {
            if (Session["Username"] != null)
            {
                //if (Session["UserType"] == "Admin")
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

        [HttpPost]

        public ActionResult InsertProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                context.Products.Add(product);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult InsertFlavour()
        {
            if (Session["Username"] != null)
            {
                //if (Session["UserType"] == "Admin")
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

        [HttpPost]

        public ActionResult InsertFlavour(Menu menu)
        {
            if (ModelState.IsValid)
            {
                context.Menus.Add(menu);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult EditProduct(int Id)
        {

            if (Session["Username"] != null)
            {
                //if (Session["UserType"] == "Admin")
                //{
                    var productDetails = context.Products.FirstOrDefault(product => product.Id == Id);
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

        [HttpPost]

        public ActionResult EditProduct(Product newData)
        {
            if (ModelState.IsValid)
            {
                var oldData = context.Products.FirstOrDefault(product => product.Id == newData.Id);
                context.Entry(oldData).CurrentValues.SetValues(newData);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult DeleteProduct(int Id)
        {
            if (Session["Username"] != null)
            {
                //if (Session["UserType"] == "Admin")
                //{
                    var product = context.Products.FirstOrDefault(p => p.Id == Id);
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

        [HttpPost]

        public ActionResult DeleteProduct(Product product, int Id)
        {
            var prod = context.Products.FirstOrDefault(p => p.Id == Id);
            context.Products.Remove(prod);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AddAdmin()
        {
            if (Session["Username"] != null)
            {
                //if (Session["UserType"] == "Admin")
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

        [HttpPost]

        public ActionResult AddAdmin(Admin admin, Login loginInfo)
        {
            loginInfo.LoginId = admin.Id;
            loginInfo.LoginUsername = admin.Username;
            loginInfo.LoginEmail = admin.Email;
            loginInfo.LoginPassword = admin.Password;
            loginInfo.UserType = "Admin";

            var user = context.Logins.FirstOrDefault(uname => uname.LoginUsername == loginInfo.LoginUsername);

            if (user == null)
            {
                //if (ModelState.IsValid)
                //{
                    context.Logins.Add(loginInfo);
                    context.Admins.Add(admin);
                    context.SaveChanges();
                    return RedirectToAction("Index");
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

        public ActionResult AddCourier()
        {
            if (Session["Username"] != null)
            {
                //if (Session["UserType"] == "Admin")
                //{
                    var courier = context.Couriers.Where(c => c.Registered == false).ToList();
                    return View(courier);
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

        public ActionResult ApproveCourier(int Id)
        {
            if (Session["Username"] != null)
            {
                //if (Session["UserType"] == "Admin")
                //{
                    var courier = context.Couriers.FirstOrDefault(courierInfo => courierInfo.Id == Id);
                    return View(courier);
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

        public ActionResult ApproveCourier(Courier newData)
        {
            var oldData = context.Couriers.FirstOrDefault(user => user.Id == newData.Id);
            context.Entry(oldData).CurrentValues.SetValues(newData);
            context.SaveChanges();
            return RedirectToAction("AddCourier");
        }

        public ActionResult DeleteCourier(int Id)
        {
            if(Session["Username"] != null)
            {
                var courier = context.Couriers.FirstOrDefault(c => c.Id == Id);
                return View(courier);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }

        [HttpPost]

        public ActionResult DeleteCourier(Courier courier, int Id)
        {
            var cour = context.Couriers.FirstOrDefault(c => c.Id == Id);
            context.Couriers.Remove(cour);
            context.SaveChanges();
            return RedirectToAction("AddCourier");
        }
    }
}