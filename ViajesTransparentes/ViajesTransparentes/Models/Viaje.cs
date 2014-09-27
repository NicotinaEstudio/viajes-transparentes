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
using System.Web.Mvc;

namespace ViajesTransparentes.Models
{
    /// <summary>
    /// Clase que representa el objeto Viaje
    /// </summary>
    public class Viaje
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int ViajeId { get; set; }

        public int ComisionId { get; set; }

        public virtual Comision Comision { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Alta")]
        [DataType(DataType.Date)]
        public DateTime FechaDeAlta { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Modificación")]
        [DataType(DataType.Date)]
        public DateTime FechaDeMod { get; set; }

        [DisplayName("Tipo de viaje")]
        [Required(ErrorMessage = "Campo requerido.")]
        public TIPO_VIAJE TIPO_VIAJE { get; set; }

        [DisplayName("Pais de origen")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string PAIS_ORIGEN { get; set; }

        [DisplayName("Estado de origen")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string ESTADO_ORIGEN { get; set; }

        [DisplayName("Ciudad de origen")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string CIUDAD_ORIGEN { get; set; }

        [DisplayName("País de destino")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string PAIS_DESTINO { get; set; }

        [DisplayName("Estado de destino")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string ESTADO_DESTINO { get; set; }

        [DisplayName("Ciudad de destino")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string CIUDAD_DESTINO { get; set; }

        [DisplayName("Tarifa diaria de viáticos por día")]
        [Required(ErrorMessage = "Campo requerido.")]
        public decimal TARIFA_DIARIA { get; set; }

        [DisplayName("Moneda")]
        [Required(ErrorMessage = "Campo requerido.")]
        public MONEDA MONEDA { get; set; }

        // Pendiente de aquí en adelante para cuando se acepte la propuesta
        public TEMA TEMA { get; set; }
        public TIPO_COM TIPO_COM { get; set; }
        public string EVENTO { get; set; }
        public string URL_EVENTO { get; set; }

        [DataType(DataType.Date)]
        public DateTime FECHAINICIO_PART { get; set; }

        [DataType(DataType.Date)]
        public DateTime FECHAFIN_PART { get; set; }
        public string MOTIVO { get; set; }
        public string ANTECEDENTE { get; set; }
        public string ACTIVIDAD { get; set; }
        public string RESULTADO { get; set; }
        public string CONTRIBUCION_IFAI { get; set; }
        public string URL_COMUNICADO { get; set; }
        public string CUBRE_PASAJE { get; set; }
        public TIPO_PASAJE TIPO_PASAJE { get; set; }
        public string LINEA_ORIGEN { get; set; }
        public string VUELO_ORIGEN { get; set; }
        public string LINEA_REGRESO { get; set; }
        public string VUELO_REGRESO { get; set; }

        [DataType(DataType.Date)]
        public DateTime FECHAINICIO_COM { get; set; }

        [DataType(DataType.Date)]
        public DateTime FECHAFIN_COM { get; set; }
        public decimal GASTO_PASAJE { get; set; }
        public decimal GASTO_VIATICO { get; set; }
        public string INST_HOSPEDAJE { get; set; }
        public string HOTEL { get; set; }
        public DateTime FECHAINICIO_HOTEL { get; set; }
        public DateTime FECHAFIN_HOTEL { get; set; }
        public decimal COSTO_HOTEL { get; set; }
        public decimal COMPROBADO { get; set; }
        public decimal SIN_COMPROBAR { get; set; }
        public decimal VIATICO_DEVUELTO { get; set; }
        public string OBSERVACIONES { get; set; }
    }

    public enum TIPO_VIAJE
    {
        Nacional,
        Internacional
    }

    public enum MONEDA
    {
        MXP,
        USD
    }

    public enum TEMA
    {
        [Display(Name = "Politicas de acceso a la información")]
        PoliticasDeAccesoALaInformacion,
        [Display(Name = "Asuntos internacionales")]
        AsuntosInternacionales,
        [Display(Name = "Normativa de acceso a la información")]
        NormativaDeAccesoALaInformacion,
        [Display(Name = "Capacitación y cultura de la transparencia")]
        CapacitacionYCulturaDeLaTransparencia,
        [Display(Name = "Gestión documental de archívos")]
        GestionDocumentalDeArchivos,
        [Display(Name = "Indicadores y evaluación")]
        IndicadoresYEvaluacion,
        [Display(Name = "Normatividad de datos personales")]
        NormatividadDeDatosPersonales,
        [Display(Name = "Supervisión, vigilancia, verificación y sanciones")]
        SupervisionVigilanciaVerificacionYSanciones,
        [Display(Name = "Tecnologias de la información")]
        TecnologiasDeLaInformacion,
        [Display(Name = "Gobierno abierto y transparencia")]
        GobiernoAbiertoYTransparencia,
        [Display(Name = "Vinculación con estados y municipios")]
        VinculacionConEstadosYMunicipios,
        [Display(Name = "Vinculación con nuevos sujetos obligados")]
        VinculacionConNuevosSujetosObligados,
        [Display(Name = "Vinculación y promocion del derecho")]
        VinculacionYPromocionDelDerecho
    }

    public enum TIPO_COM
    {
        RecibirCapacitacion,
        ImpartirCapacitacion,
        ParticipacionEnEventoPublico,
        Notificacion,
        Verificacion,
        Otro
    }

    public enum TIPO_PASAJE
    {
        Terrestre,
        Aereo,
        Maritimo
    }
}