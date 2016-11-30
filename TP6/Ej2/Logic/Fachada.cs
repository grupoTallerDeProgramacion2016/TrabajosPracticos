using Ej2.DAL.EntityFramework;
using Ej2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ej2.Logic
{
    class Fachada
    {
        public void CrearCuenta(Client pClient, String pName, double pOverdraftLimit)
        {
            using (var dbContext = new AccountManagerDbContext())
            {
                using (var uof = new UnitOfWork(dbContext))
                {
                    var cuenta = new Account
                    {
                        Client = pClient,
                        Name = pName,
                        OverdraftLimit = pOverdraftLimit
                    };

                    try
                    {
                        uof.AccountRepository.Add(cuenta);
                        uof.Complete();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }


        }

        public void EliminarCuenta(Account pAccount)
        {
            using (var dbContext = new AccountManagerDbContext())
            {
                using (var uof = new UnitOfWork(dbContext))
                {
                    try
                    {
                        uof.AccountRepository.Remove(pAccount);
                        uof.Complete();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }


        }

        public Account ObtenerCuenta(int pId)
        {
            using (var dbContext = new AccountManagerDbContext())
            {
                using (var uof = new UnitOfWork(dbContext))
                {
                    try
                    {
                        return uof.AccountRepository.Get(pId);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        public void ModificarCuenta(Account pAccount)
        {
            using (var dbContext = new AccountManagerDbContext())
            {
                using (var uof = new UnitOfWork(dbContext))
                {
                    try
                    {
                        var cuenta = uof.AccountRepository.Get(pAccount.Id);

                        cuenta.Client = pAccount.Client;
                        cuenta.Name = pAccount.Name;
                        cuenta.OverdraftLimit = pAccount.OverdraftLimit;
                        cuenta.Movements = pAccount.Movements;

                        uof.Complete();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }

        }

        public void RegistrarMovimiento(Account pAccount, String pDescription, double pAmount)
        {

        }

        public double ObtenerBalance(Account pAccount)
        {
            using (var dbContext = new AccountManagerDbContext())
            {
                using (var uof = new UnitOfWork(dbContext))
                {
                    try
                    {
                        return uof.AccountRepository.GetAccountBalance(pAccount);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }

        }

        public List<Account> ObtenerCuentasSobregiradas()
        {

            using (var dbContext = new AccountManagerDbContext())
            {
                using (var uof = new UnitOfWork(dbContext))
                {
                    try
                    {
                        return uof.AccountRepository.GetOverdrawnAccounts().ToList();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        public void CrearCliente(Client pCliente)
        {
            using (var dbContext = new AccountManagerDbContext())
            {
                using (var uof = new UnitOfWork(dbContext))
                {

                    try
                    {
                        uof.ClientRepository.Add(pCliente);
                        uof.Complete();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }


        }

        public void EliminarCliente(Client pClient)
        {
            using (var dbContext = new AccountManagerDbContext())
            {
                using (var uof = new UnitOfWork(dbContext))
                {
                    try
                    {
                        uof.ClientRepository.Remove(pClient);
                        uof.Complete();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }


        }

        public void ModificarCliente(Client pClient)
        {
            using (var dbContext = new AccountManagerDbContext())
            {
                using (var uof = new UnitOfWork(dbContext))
                {
                    try
                    {
                        var cliente = uof.ClientRepository.Get(pClient.Id);

                        cliente.Accounts = pClient.Accounts;
                        cliente.Document = pClient.Document;
                        cliente.FirstName = pClient.FirstName;
                        cliente.LastName = pClient.LastName;

                        uof.Complete();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        public Client ObtenerCliente(int pId)
        {
            using (var dbContext = new AccountManagerDbContext())
            {
                using (var uof = new UnitOfWork(dbContext))
                {
                    try
                    {
                        return uof.ClientRepository.Get(pId);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        public List<Client> ObtenerClientes()
        {
            using (var dbContext = new AccountManagerDbContext())
            {
                using (var uof = new UnitOfWork(dbContext))
                {
                    try
                    {
                        return uof.ClientRepository.GetAll().ToList();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }
    }
}
