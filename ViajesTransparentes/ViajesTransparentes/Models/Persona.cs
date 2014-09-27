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
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace ViajesTransparentes.Models
{
    /// <summary>
    /// Clase que representa el objeto Persona
    /// </summary>
    [Bind(Exclude = "PersonaId")]
    [Table("Personas")]
    public class Persona
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int PersonaId { get; set; }

        [DisplayName("Activo")]
        public bool EsActivo { get; set; }

        [DisplayName("Verificado")]
        public bool EsVerificado { get; set; }

        [DisplayName("Completo")]
        public bool EsCompleto { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Alta")]
        [DataType(DataType.Date)]
        public DateTime FechaDeAlta { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Modificación")]
        [DataType(DataType.Date)]
        public DateTime FechaDeMod { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Campo requerido.")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string Nombre { get; set; }

        [DisplayName("Primer apellido")]
        [Required(ErrorMessage = "Campo requerido.")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string PrimerApellido { get; set; }

        [DisplayName("Segundo apellido")]
        [Required(ErrorMessage = "Campo requerido.")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string SegundoApellido { get; set; }

        [ScaffoldColumn(false)]
        [StringLength(500, ErrorMessage = "Máximo 500 caracteres.")]
        public string NombreCompleto { get; set; }

        [DisplayName("Correo electrónico")]
        [Required(ErrorMessage = "Campo requerido.")]
        [EmailAddress(ErrorMessage = "Dirección de correo electrónico inválido.")]
        public string CorreoElectrónico { get; set; }
    }
}