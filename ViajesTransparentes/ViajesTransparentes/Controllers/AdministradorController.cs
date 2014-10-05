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
        #region GRUPO JERARQUICO
        // GET: Administrador/ViaticosListar
        public ActionResult GrupoJerarquicoListar()
        {
            var grupo = _db.GruposJerarquicos;

            return View(grupo.ToList());
        }
        #endregion

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
            ViewBag.GrupoJerarquicoId = new SelectList(_db.GruposJerarquicos, "GrupoJerarquicoId", "Codigo");
            return View();
        }

        // POST: Administrador/ServidorPublicoNuevo
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ServidorPublicoNuevo([Bind(
            Include = "Nombre, PrimerApellido, SegundoApellido, CorreoElectronico, GrupoJerarquicoId, Institucion, TipoDePersonal, NombreDelCargo, NombreDelCargoSuperior, UnidadAdministrativa, NombreDelPuesto"
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

        #region VIATICOS
        // GET: Administrador/ViaticosListar
        public ActionResult ViaticosListar()
        {
            var viaticos = _db.Viaticos;

            return View(viaticos.ToList());
        }

        // GET: Administrador/ViaticosNuevo
        public ActionResult ViaticosNuevo()
        {
            ViewBag.GrupoJerarquicoId = new SelectList(_db.GruposJerarquicos, "GrupoJerarquicoId", "Codigo");

            return View();
        }

        // POST: Administrador/ViaticosNuevo
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ViaticosNuevo([Bind(
            Include = "GrupoJerarquicoId, TipoViaje, ZonaDestino, TarifaDiariaViaticosMXP, TarifaDiariaViaticosUSD"
            )] Viatico viatico)
        {
            if (ModelState.IsValid)
            {
                _db.Viaticos.Add(viatico);
                _db.SaveChanges();

                return RedirectToAction("ViaticosListar");
            }
            return View(viatico);
        }
        #endregion
    }
}