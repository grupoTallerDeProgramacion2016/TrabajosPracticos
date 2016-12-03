using Ej2.Domain;
using System;

namespace Ej2.DTO
{
    /// <summary>
    /// Clase DTO para comunicar la fachada con los WinForm
    /// </summary>
    public class ClientDTO
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String DocumentNumber { get; set; }
        public DocumentType DocumentType { get; set; }

        public ClientDTO()
        {
            this.Id = -1;
            this.FirstName = "";
            this.LastName = "";
        }
    }
}
