using System.Data.Entity.ModelConfiguration;

namespace Ej1
{
    class TelefonoMap : EntityTypeConfiguration<Telefono>
    {
        public TelefonoMap()
        {
            this.ToTable("Telefonos");

            this.HasKey(pTelefono => pTelefono.TelefonoId);

            this.Property(pTelefono => pTelefono.TelefonoId)
                .IsRequired();
        }
    }
}
