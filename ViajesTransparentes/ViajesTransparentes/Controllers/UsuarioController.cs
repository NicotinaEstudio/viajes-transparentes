using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViajesTransparentes.Models;

namespace ViajesTransparentes.Controllers
{
    public class UsuarioController : Controller
    {
        private ViajesTransparentesEntities db = new ViajesTransparentesEntities();

        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Viajes()
        {
            return View();
        }

        public ActionResult ServidoresPublicosIFAI()
        {
            var servidores = db.ServidorPublicoIFAI;
            return View(servidores.ToList());
        }
    }
}