using System;

namespace Ej2.DAL
{
    interface IUnitOfWork : IDisposable
    {
        void Complete();

        IAccountRepository AccountRepository { get; }
        IClientRepository ClientRepository { get; }
    }
}
