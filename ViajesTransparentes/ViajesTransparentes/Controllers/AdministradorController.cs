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
    /// <summary>
    /// Controlador para el adminsitrador
    /// </summary>
    public class AdministradorController : Controller
    {
        private ViajesTransparentesEntities _db = new ViajesTransparentesEntities();

        // GET: Administrador
        public ActionResult Index()
        {
            return View();
        }

        #region SERVIDORES PÚBLICOS

        // GET: Administrador/ServidorPublicoListar
        public ActionResult ServidorPublicoListar()
        {
            var servidoresPublicos = _db.ServidoresPublicos;

            return View(servidoresPublicos.ToList());
        }

        // GET: Administrador/ServidorPublicoNuevo
        public ActionResult ServidorPublicoNuevo()
        {
            return View();
        }

        // POST: Administrador/ServidorPublicoNuevo
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ServidorPublicoNuevo([Bind(
            Include = "Nombre, PrimerApellido, SegundoApellido, CorreoElectrónico, Institucion, TipoDePersonal, NombreDelCargo, NombreDelCargoSuperior, UnidadAdministrativa, ClaveDelPuesto, NombreDelPuesto"
            )] ServidorPublico servidorPublico)
        {
            if (ModelState.IsValid)
            {
                servidorPublico.FechaDeAlta = servidorPublico.FechaDeMod = DateTime.Now;
                servidorPublico.EsActivo = servidorPublico.EsCompleto = servidorPublico.EsVerificado = true;
                servidorPublico.NombreCompleto = servidorPublico.Nombre + " " + servidorPublico.PrimerApellido + " " + servidorPublico.SegundoApellido;

                _db.ServidoresPublicos.Add(servidorPublico);
                _db.SaveChanges();

                return RedirectToAction("ServidorPublicoListar");   
            }
            return View(servidorPublico);
        }

        #endregion SERVIDORES PÚBLICOS
    }
}