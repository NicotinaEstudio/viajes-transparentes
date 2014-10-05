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

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace ViajesTransparentes.Models
{
    /// <summary>
    /// Clase que representa el grupo jerárquico
    /// </summary>
    [Bind(Exclude = "GrupoJerarquicoId")]
    [Table("GruposJerarquicos")]
    public class GrupoJerarquico
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int GrupoJerarquicoId { get; set; }

        /// <summary>
        /// Código del grupo jerárquico de máximo 5 caracteres
        /// </summary>
        [DisplayName("Código")]
        [Required(ErrorMessage = "Campo requerido.")]
        [StringLength(5, ErrorMessage = "Máximo 5 caracteres.")]
        public string Codigo { get; set; }
    }
}