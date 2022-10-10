using Copa_do_Mundo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Copa_do_Mundo.Controllers
{
    public class AlocacaoController : Controller
    {
        CopaDoMundoEntities db = new CopaDoMundoEntities();

        [HttpGet]
        public ActionResult ListarPorArea(int idarea)
        {
            ViewBag.Alocacao = db.Alocacao.ToList().Where(x => x.IDArea == idarea);
            return View();
        } 
    }
}