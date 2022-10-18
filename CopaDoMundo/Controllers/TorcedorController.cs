using CopaDoMundo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CopaDoMundo.Controllers
{
    public class TorcedorController : Controller
    {

        [HttpGet] public ActionResult Index() => View();
        [HttpGet] public ActionResult ListaTorcedor() => View();
        [HttpGet] public ActionResult Create() => View();

        [HttpPost]
        public ActionResult Create(string Nome, int Idade) {
            return View();
        }
    }
}