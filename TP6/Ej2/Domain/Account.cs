using System.Collections.Generic;

namespace Ej2.Domain
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double OverdraftLimit { get; set; }
        public virtual Client Client { get; set; }
        public virtual IList<AccountMovement> Movements { get; set; }
    }
}
