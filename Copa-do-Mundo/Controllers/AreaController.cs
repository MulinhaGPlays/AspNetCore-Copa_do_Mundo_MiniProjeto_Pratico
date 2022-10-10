using System;
using System.Collections.Generic;
using Copa_do_Mundo.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace Copa_do_Mundo.Controllers
{
    public class AreaController : Controller
    {
        CopaDoMundoEntities db = new CopaDoMundoEntities();

        [HttpGet]
        public ActionResult Index() => View(db.AreaQtd.ToList());
    }
}