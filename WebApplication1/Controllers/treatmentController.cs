using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class treatmentController : Controller
    {
        // GET: treatment
        [HttpGet]
        public ActionResult Treatment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Treatment(Treatment Tr)
        {
            Tr.Insert(Tr);
            return View();
        }
    }
}