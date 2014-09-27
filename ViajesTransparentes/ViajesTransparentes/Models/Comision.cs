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
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace ViajesTransparentes.Models
{
    /// <summary>
    /// Clase que presesenta al objeto Comision
    /// </summary>
    [Bind(Exclude = "ComisionId")]
    [Table("Comisiones")]
    public class Comision
    {
        /// <summary>
        /// Id de la comisión auto incrementable
        /// </summary>
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int ComisionId { get; set; }

        /// <summary>
        /// Id del servidor público asignado
        /// </summary>
        [DisplayName("Servidor público comisionado")]
        public int PersonaId { get; set; }

        public virtual ServidorPublico ServidorPublico { get; set; }

        /// <summary>
        /// Fecha de alta
        /// </summary>
        [ScaffoldColumn(false)]
        [DisplayName("Alta")]
        [DataType(DataType.Date)]
        public DateTime FechaDeAlta { get; set; }

        /// <summary>
        /// Fecha de modificación
        /// </summary>
        [ScaffoldColumn(false)]
        [DisplayName("Modificación")]
        [DataType(DataType.Date)]
        public DateTime FechaDeMod { get; set; }

        /// <summary>
        /// Mecanismo que origina (Actualmente un enumerador pero se recomendaria separarlo en una tabla nueva)
        /// </summary>
        [DisplayName("Mecanismo que origina la comisión")]
        [Required(ErrorMessage = "Campo requerido.")]
        public MEC_ORIGEN MEC_ORIGEN { get; set; }

        /// <summary>
        /// Institucion que genera la invitación
        /// </summary>
        [DisplayName("Quien invita")]
        [StringLength(300, ErrorMessage = "Máximo 200 caracteres.")]
        public string INST_GENERA { get; set; }

        /// <summary>
        /// Unidad responsable
        /// </summary>
        [DisplayName("Unidad responsable")]
        [StringLength(300, ErrorMessage = "Máximo 200 caracteres.")]
        public string UR { get; set; }

        /// <summary>
        /// TIpo de representación requerida (Actualmente un enumerador pero se recomendaria separarlo en una tabla nueva)
        /// </summary>
        [DisplayName("Tipo de representación requerida")]
        [Required(ErrorMessage = "Campo requerido.")]
        public TIPO_REP TIPO_REP { get; set; }

        /// <summary>
        /// Número de comisión
        /// </summary>
        [DisplayName("Número de comisión")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string CONSECUTIVO { get; set; }

        //public string NOMBRE { get; set; }

        [DisplayName("Cargo")]
        [StringLength(100, ErrorMessage = "Máximo 200 caracteres.")]
        public string CARGO { get; set; }

        [DisplayName("Grupo jerárquico")]
        [StringLength(100, ErrorMessage = "Máximo 200 caracteres.")]
        public string GRUPO { get; set; }

        [DisplayName("No. de acuerdo de autorización del pleno")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string ACUERDO { get; set; }

        [DisplayName("No. de oficio de comisión")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string OFICIO { get; set; }

        public virtual ICollection<Viaje> Viajes { get; set; }  
        
    }

    public enum MEC_ORIGEN
    {
        Invitacion,
        Requerimiento
    }

    public enum TIPO_REP
    {
        Tecnico,
        AltoNivel
    }
}