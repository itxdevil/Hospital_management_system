using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        [HttpGet]
        public ActionResult Patient()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Patient(Patient p)
        {
            return View();
            p.Insert(p);
        }
    }
}