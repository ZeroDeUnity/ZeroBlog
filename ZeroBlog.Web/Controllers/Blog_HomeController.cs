using Abp.Web.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZeroBlog.Web.Controllers
{
    public class Blog_HomeController : AbpController
    {
        public Blog_HomeController
            (

            )
        {

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult single()
        {
            return View();
        }

        public ActionResult Tste1()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
