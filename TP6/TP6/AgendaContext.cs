using System.Data.Entity;

namespace Ej1
{
    class AgendaContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }

        protected override void OnModelCreating(DbModelBuilder pModelBuilder)
        {
            pModelBuilder.Configurations.Add(new TelefonoMap());
            pModelBuilder.Configurations.Add(new PersonaMap());

            base.OnModelCreating(pModelBuilder);
        }
    }
}
