using System.Data.Entity.ModelConfiguration;

namespace Ej1
{
    class PersonaMap : EntityTypeConfiguration<Persona>
    {
        public PersonaMap()
        {
            this.ToTable("Personas");

            this.HasKey(pPersona => pPersona.PersonaId);

            this.Property(pPersona => pPersona.PersonaId)
                .IsRequired();

        }
    }
}
