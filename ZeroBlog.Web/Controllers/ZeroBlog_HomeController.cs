﻿using Abp.Web.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZeroBlog.Web.Controllers
{
    public class ZeroBlog_HomeController : AbpController
    {
        public ZeroBlog_HomeController
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

    }
}
