using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2.Models;
using Lab2.Models.Database;

namespace Lab2.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddStudent()
        {
            Student s = new Student();
            return View(s);
        }

        [HttpPost]
        public ActionResult AddStudent(Student s)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Students.Insert(s);
                return RedirectToAction("Index");
            }
            return View();

        }

        public ActionResult ShowAllStudent()
        {
            Database db = new Database();
            var students = db.Students.GetAll();
            return View(students);
            
        }

        public ActionResult StudentEdit(string id)
        {

            Database db = new Database();
            var s = db.Students.Get(id);

            return View(s);
        }
        [HttpPost]
        public ActionResult StudentEdit(Student s)
        {
            //update to db
            Database db = new Database();
            db.Students.Update(s);
            return RedirectToAction("Index");
        }

        public ActionResult StudentDelete(string id)
        {
            //update to db
            Database db = new Database();
            db.Students.Delete(id);
            return RedirectToAction("ShowAllStudent");
        }
    }
}