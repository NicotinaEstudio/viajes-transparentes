using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace ViajesTransparentes.Models
{
    [Bind(Exclude = "ServidorPublicoIFAIId")]
    [Table("ServidorPublicoIFAI")]
    public class ServidorPublicoIFAI
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int ServidorPublicoIFAIId { get; set; }

        [DisplayName("Institución")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string Institucion { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string Nombre { get; set; }

        [DisplayName("Primer apellido")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string PrimerApellido { get; set; }

        [DisplayName("Segundo apellido")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string SegundoApellido { get; set; }

        [DisplayName("Nombre completo")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string NombreCompleto { get; set; }

        [DisplayName("Tipo de personal")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string TipoDePersonal { get; set; }

        [DisplayName("Nombre del cargo")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string NombreDelCargo { get; set; }

        [DisplayName("Nombre del cargo superior")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string NombreDelCargoSuperior { get; set; }

        [DisplayName("Unidad administrativa")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string UnidadAdministrativa { get; set; }

        [DisplayName("Clave del puesto")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string ClaveDelPuesto { get; set; }

        [DisplayName("Nombre del puesto")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string NombreDelPuesto { get; set; }

        [DisplayName("Correo electrónico")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string CorreoElectrónico { get; set; }
    }
}