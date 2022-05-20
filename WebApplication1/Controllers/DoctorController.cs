using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DoctorController : Controller
    {

        public ActionResult Main()
        {
            return View();
        }
        public ActionResult Select()
        {
            Doctor B = new Doctor();
            return View(B.Select());
        }
        public ActionResult Delete(int id)
        {
            Doctor B = new Doctor();
            B.Delete(id);
            return RedirectToAction("Select");
        }

        // GET: Doctor

        [HttpGet]
        public ActionResult Doctor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Doctor(Doctor d)
        {
            d.Insert(d);
            return View();
        }
    }
}