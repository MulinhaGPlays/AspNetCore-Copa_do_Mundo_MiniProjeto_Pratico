using CopaDoMundo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CopaDoMundo.Controllers
{
   

    public class AlocacaoController : Controller
    {
        CopaDoMundoEntities db = new CopaDoMundoEntities();
        // GET: Alocacao
        public ActionResult Index() => View();

        public ActionResult VagasTotais() => View(db.AreaAlocacao.ToList()); 
    }
}