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
    public class ServidorPublicoController : Controller
    {
        private ViajesTransparentesEntities _db = new ViajesTransparentesEntities();

        // GET: ServidorPublico
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ComisionListar()
        {
            var comisiones = _db.Comisiones.Where(g => g.PersonaId == 2);

            return View(comisiones.ToList());
        }

        public ActionResult ComisionNueva()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ComisionNueva([Bind(
            Include = "MEC_ORIGEN, INST_GENERA, UR, TIPO_REP, CONSECUTIVO, CARGO, GRUPO, ACUERDO, OFICIO"
            )] Comision comision)
        {
            if (ModelState.IsValid)
            {
                comision.FechaDeAlta = comision.FechaDeMod = DateTime.Now;
                comision.PersonaId = 2;

                _db.Comisiones.Add(comision);
                _db.SaveChanges();

                return RedirectToAction("ComisionListar");
            }
            return View(comision);
        }
    }
}