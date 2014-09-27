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

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace ViajesTransparentes.Models
{
    /// <summary>
    /// Clase que representa el objeto Servidor Publico
    /// </summary>
    [Table("ServidoresPublicos")]
    public class ServidorPublico : Persona
    {
        /// <summary>
        /// Nombre de la instiución de la que forma parte
        /// </summary>
        [DisplayName("Institución")]
        [Required(ErrorMessage = "Campo requerido.")]
        [StringLength(500, ErrorMessage = "Máximo 500 caracteres.")]
        public string Institucion { get; set; }

        /// <summary>
        /// Tipo de persona (Actualmente campo abierto pero se recomendaria separarlo en una tabla nueva)
        /// </summary>
        [DisplayName("Tipo de personal")]
        [Required(ErrorMessage = "Campo requerido.")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string TipoDePersonal { get; set; }

        /// <summary>
        /// Nombre del cargo (Actualmente campo abirto pero se recomendaria separarlo en una tabla nueva)
        /// </summary>
        [DisplayName("Nombre del cargo")]
        [Required(ErrorMessage = "Campo requerido.")]
        [StringLength(200, ErrorMessage = "Máximo 200 caracteres.")]
        public string NombreDelCargo { get; set; }

        [DisplayName("Nombre del cargo superior")]
        [Required(ErrorMessage = "Campo requerido.")]
        [StringLength(200, ErrorMessage = "Máximo 200 caracteres.")]
        public string NombreDelCargoSuperior { get; set; }

        [DisplayName("Unidad administrativa")]
        [Required(ErrorMessage = "Campo requerido.")]
        [StringLength(200, ErrorMessage = "Máximo 200 caracteres.")]
        public string UnidadAdministrativa { get; set; }

        [DisplayName("Clave del puesto")]
        [Required(ErrorMessage = "Campo requerido.")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string ClaveDelPuesto { get; set; }

        [DisplayName("Nombre del puesto")]
        [Required(ErrorMessage = "Campo requerido.")]
        [StringLength(200, ErrorMessage = "Máximo 200 caracteres.")]
        public string NombreDelPuesto { get; set; }

        public virtual ICollection<Comision> Comisiones { get; set; }  
    }
}