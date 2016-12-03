namespace Ej2.DTO
{
    /// <summary>
    /// Clase DTO para comunicar la fachada con los WinForm
    /// </summary>
    public class AccountDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double OverdraftLimit { get; set; }
        public int ClientId { get; set; }

        public AccountDTO()
        {
            this.Id = -1;
            this.Name = "";
            this.OverdraftLimit = 500;
        }
    }
}
