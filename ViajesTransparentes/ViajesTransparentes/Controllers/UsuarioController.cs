/**
* Copyright 2014 Nicotina Estudio
* 
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
* 
*     http://www.apache.org/licenses/LICENSE-2.0
* 
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
**/

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
        private ViajesTransparentesEntities _db = new ViajesTransparentesEntities();

        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Viajes()
        {
            return View();
        }

        public ActionResult ServidoresPublicos()
        {
            var servidoresPublicos = _db.ServidoresPublicos;
            return View(servidoresPublicos.ToList());
        }

        public ActionResult ServidorPublicoDetalle(int id)
        {
            var servidorPublico = _db.ServidoresPublicos.Where(g => g.PersonaId == id).Single();
            return View(servidorPublico);
        }

        public ActionResult ComisionDetalle(int id)
        {
            var comicion = _db.Comisiones.Where(g => g.ComisionId == id).Single();
            return View(comicion);
        }
    }
}