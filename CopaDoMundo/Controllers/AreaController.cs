using CopaDoMundo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CopaDoMundo.Controllers
{
    public class AreaController : Controller
    {
        CopaDoMundoEntities db = new CopaDoMundoEntities();

        public ActionResult Index() => View();
        public ActionResult TorcedorPorArea(int id) => View(db.TorcedorAlocado.Where(c => c.IDArea == id));
    }
}