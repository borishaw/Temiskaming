﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Temiskaming.Models;

namespace Temiskaming.Controllers
{
    public class HomeController : Controller
    {
        navClass objNav = new navClass();

        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Admin()
        {
            ViewBag.Group = "Admin";
            return View();
        }

        public PartialViewResult Nav(string group)
        {
            var nav = objNav.getNav(group);
            return PartialView(nav);
        }

        public ActionResult Patients()
        {
            ViewBag.Group = "Patients";
            return View();
        }

        public ActionResult ProgramsServices()
        {
            ViewBag.Group = "ProgramsServices";
            return View();
        }

        public ActionResult AboutUs()
        {
            ViewBag.Group = "AboutUs";
            return View();
        }

        public ActionResult JoinOurTeam()
        {
            ViewBag.Group = "JoinOurTeam";
            return View();
        }


        public ActionResult ContactUs()
        {
            ViewBag.Group = "ContactUs";
            return View();
        }

    }
}
