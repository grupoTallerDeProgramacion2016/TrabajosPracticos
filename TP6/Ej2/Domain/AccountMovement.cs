using System;

namespace Ej2.Domain
{
    public class AccountMovement
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public String Description { get; set; }
        public double Amount { get; set; }

        public AccountMovement()
        {

        }

        public AccountMovement(DateTime pDate, String pDescription, double pAmount)
        {
            this.Date = pDate;
            this.Description = pDescription;
            this.Amount = pAmount;
        }
    }
}
