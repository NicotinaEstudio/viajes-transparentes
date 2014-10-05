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
    [Bind(Exclude = "ComprobanteId")]
    [Table("Comprobantes")]
    public class Comprobante
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int ComprobanteId { get; set; }

        [DisplayName("Comisión")]
        public int ComisionId { get; set; }

        public virtual Comision Comision { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Alta")]
        [DataType(DataType.Date)]
        public DateTime FechaDeAlta { get; set; }

        [DisplayName("Concepto")]
        public string Concepto { get; set; }

        public decimal Importe { get; set; }

        public CLAVE_JUSTIFICACION ClaveDeJustificacion { get; set; }
    }

    public enum CLAVE_JUSTIFICACION
    {
        [Display(Name = "El proveedor del servicio de alimentos es pequeño contribuyente y solo expide comprobantes en operaciones superiores a $100.00 pesos M.N.")]
        ALimentosPequenoContibuyente,
        [Display(Name = "En la localidad, no existen prestadores de servicios de hospedaje que expidan comprobantes fiscales.")]
        SinProveedorContribuyente,
        [Display(Name = "El prestador de servicios de transporte local (taxi, camión, combi) es pequeño contribuyente no expide compobantes.")]
        TransportePequenoContibuyente
    }
}