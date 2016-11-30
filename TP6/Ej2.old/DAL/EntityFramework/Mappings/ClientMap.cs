using Ej2.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Ej2.DAL.EntityFramework.Mappings
{
    class ClientMap : EntityTypeConfiguration<Client>
    {

        public ClientMap()
        {

            // Se establece la columna obligatoria (NOT NULL) 'LastName', con una longitud máxima de 20 caracteres [varchar(20)].
            this.Property(pClient => pClient.LastName)
                .IsRequired()
                .HasMaxLength(20);

            // Se crea un índice único por tipo y número de documento.
            /*this.HasIndex("IX_Document",
                IndexOptions.Unique,
                pEntity => pEntity.Property(pClient => pClient.Document.Type),
                pEntity => pEntity.Property(pClient => pClient.Document.Number));*/

            // Se establece la relación de uno a muchos entre las entidades Client y Account, habilitando la 
            // navegación tanto desde la instancia de Client hacia sus instancias de Account, como de Account
            // hacia la instancia de Client a la que pertenece. Si se elimina la entidad Client, entonces se
            // eliminarán en cascada todas las entidades Account relacionadas. El nombre de la columna de
            // la FK se nombra 'ClientId'.
            this.HasMany<Account>(pClient => pClient.Accounts)
                .WithRequired(pAccount => pAccount.Client)
                .Map(pMapping => pMapping.MapKey("ClientId"))
                .WillCascadeOnDelete();

        }

    }
}
