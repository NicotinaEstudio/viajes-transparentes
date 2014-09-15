using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViajesTransparentes.Controllers
{
    public class ServidorPublicoController : Controller
    {
        // GET: ServidorPublicoIFAI
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViajeNuevo()
        {
            return View();
        }
    }
}