﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SharedMvcApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            ViewBag.Message = "Modified Message on server and zaghalilo  yama";
            ViewBag.Message = "Modified Message on server (Eid Modification) make conlict with eid branch (server)";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page for fetch by haytham.";

            string sss=string.Empty;
            string s;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //zaghalilo  yama
    }
}
