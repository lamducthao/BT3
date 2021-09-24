using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BT3.Models;

namespace BT3.Controllers
{
    public class StudentController : Controller
    {
        LapTrinhQuanLyDBcontext db = new LapTrinhQuanLyDBcontext();
        // GET: Student
        public ActionResult Index()
        {
            var model = db.Students.ToList();
            return View(model);
        }
        //tạo action create tar về view cho phép người dung fnhaapj thông tin 
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student std)
        {
            if (ModelState.IsValid)
            {    
                    db.Students.Add(std);
                     db.SaveChanges();
                return RedirectToAction("index");
             }
            return View();
        }
    }
}