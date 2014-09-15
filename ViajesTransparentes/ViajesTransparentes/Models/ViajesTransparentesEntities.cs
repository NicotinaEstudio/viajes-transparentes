using System.Data.Entity;

namespace ViajesTransparentes.Models
{
    public class ViajesTransparentesEntities :DbContext
    {
        public DbSet<Viaje> Viajes { get; set; }
        public DbSet<ServidorPublico> ServidoresPublicos { get; set; }
    }
}