﻿using Ej2.Domain;
using System.Collections.Generic;

namespace Ej2.DAL
{
    interface IAccountRepository : IRepository<Account>
    {
        double GetAccountBalance(Account pAccount);
        IEnumerable<Account> GetOverdrawnAccounts();
        IEnumerable<AccountMovement> GetLastMovements(Account pAccount, int pCount = 7);
    }
}
