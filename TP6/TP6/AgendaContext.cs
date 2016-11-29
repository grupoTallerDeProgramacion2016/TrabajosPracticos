using System.Data.Entity;

namespace Ej1
{
    class AgendaContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
    }
}
