using System;

namespace Ej2.DTO
{
    /// <summary>
    /// Clase DTO para comunicar la fachada con los WinForm
    /// </summary>
    public class AccountMovementDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public String Description { get; set; }
        public double Amount { get; set; }
    }
}
