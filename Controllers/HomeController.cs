﻿using CitrineHomeHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CitrineHomeHealth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Team()
        {
            return View();
        }
        public ActionResult Careers()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Careers(Applicant applicant)
        {

            return Redirect("Index");
        }

        public ActionResult Contact()
        {
            return View();
        }

    }
}