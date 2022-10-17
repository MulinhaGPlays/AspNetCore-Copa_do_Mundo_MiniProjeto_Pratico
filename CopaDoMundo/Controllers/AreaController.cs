using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CopaDoMundo.Controllers
{
    public class AreaController : Controller
    {
        public ActionResult Index() => View();
        public ActionResult Create() => View();
    }
}