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

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
namespace ViajesTransparentes.Models
{
    /// <summary>
    /// Clase que representa el objeto Viaticos
    /// </summary>
    [Bind(Exclude = "ViaticoId")]
    [Table("Viaticos")]
    public class Viatico
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int ViaticoId { get; set; }

        public int GrupoJerarquicoId { get; set; }

        public virtual GrupoJerarquico GrupoJerarquico { get; set; }

        public TIPO_VIAJE TipoViaje { get; set; }

        public ZONA_DESTINO ZonaDestino { get; set; }

        public decimal TarifaDiariaViaticosMXP { get; set; }

        public decimal TarifaDiariaViaticosUSD { get; set; }
    }

    public enum ZONA_DESTINO
    {
        A,
        B
    }
}