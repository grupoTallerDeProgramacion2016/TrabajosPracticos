using AutoMapper;
using Ej2.Domain;
using Ej2.DTO;
using Ej2.UI;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Realiza el mapeo de los objetos con los DTO
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Client, ClientDTO>()
                    .ForMember(dest => dest.DocumentNumber, opt => opt.MapFrom(src => src.Document.Number))
                    .ForMember(dest => dest.DocumentType, opt => opt.MapFrom(src => src.Document.Type));

                cfg.CreateMap<ClientDTO, Client>()
                    .ForMember(dest => dest.Document, opt => opt.MapFrom(src => new Document
                    {
                        Number = src.DocumentNumber,
                        Type = (DocumentType)src.DocumentType
                    }
                    ));

                cfg.CreateMap<Account, AccountDTO>()
                    .ForMember(dest => dest.ClientId, opt => opt.MapFrom(src => src.Client.Id));

                cfg.CreateMap<AccountDTO, Account>();

                cfg.CreateMap<AccountMovement, AccountMovementDTO>();
                cfg.CreateMap<AccountMovementDTO, AccountMovement>();
            }
            );

            ///Inicia la aplicacion
            var app = new MenuAdmin();
            app.ShowDialog();
        }
    }
}
