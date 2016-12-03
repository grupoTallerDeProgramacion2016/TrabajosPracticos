using AutoMapper;
using Ej2.DAL.EntityFramework;
using Ej2.Domain;
using Ej2.DTO;
using System;
using System.Collections.Generic;

namespace Ej2.Logic
{
    /// <summary>
    /// Aisla toda la funcionalidad de la entidad cuenta
    /// </summary>
    public class OperacionesCuenta
    {
        private UnitOfWork iUnitOfWork;

        public OperacionesCuenta(UnitOfWork pUnitOfWork)
        {
            this.iUnitOfWork = pUnitOfWork;
        }

        /// <summary>
        /// Crea una nueva cuenta
        /// </summary>
        /// <param name="pAccountDTO"></param>
        public void CrearCuenta(AccountDTO pAccountDTO)
        {
            if (pAccountDTO.Id > -1)
            {
                throw new Exception("No debes introducir un id para la cuenta!");
            }
            if (String.IsNullOrWhiteSpace(pAccountDTO.Name))
            {
                throw new Exception("Debes introducir un nombre para la cuenta!");
            }
            //aca seria el control dependiendo de los limites del banco, por ahora 500 de minimo
            if (pAccountDTO.OverdraftLimit < 500)
            {
                throw new Exception("El descubierto no respeta las reglas del banco!");
            }
            var cliente = this.iUnitOfWork.ClientRepository.Get(pAccountDTO.ClientId);
            if (cliente == null)
            {
                throw new Exception("El cliente ingresado no se encuentra en el sistema");
            }
            try
            {
                var cuenta = Mapper.Map<Account>(pAccountDTO);
                cuenta.Movements = new List<AccountMovement>();
                cuenta.Client = cliente;
                this.iUnitOfWork.AccountRepository.Add(cuenta);
                this.iUnitOfWork.Complete();
            }
            catch (Exception)
            {
                throw new Exception("Se produjo un error al guardar la cuenta :(");
            }
        }

        /// <summary>
        /// Modifica una cuenta existente
        /// </summary>
        /// <param name="pAccountDTO"></param>
        public void ModificarCuenta(AccountDTO pAccountDTO)
        {

            if (pAccountDTO.Id < 0)
            {
                throw new Exception("Hay un error con el id de la cuenta");
            }
            if (String.IsNullOrWhiteSpace(pAccountDTO.Name))
            {
                throw new Exception("Debes introducir un nombre para la cuenta!");
            }
            //aca seria el control dependiendo de los limites del banco, por ahora 500 de minimo
            if (pAccountDTO.OverdraftLimit < 500)
            {
                throw new Exception("El descubierto no respeta las reglas del banco!");
            }
            var cliente = this.iUnitOfWork.ClientRepository.Get(pAccountDTO.ClientId);
            if (cliente == null)
            {
                throw new Exception("El cliente ingresado no se encuentra en el sistema");
            }
            var cuenta = this.iUnitOfWork.AccountRepository.Get(pAccountDTO.Id);
            if (cuenta == null)
            {
                throw new Exception("La cuenta que desea modificar no existe en el sistema");
            }
            cuenta.Name = pAccountDTO.Name;
            cuenta.OverdraftLimit = pAccountDTO.OverdraftLimit;
            cuenta.Client = cliente;

            this.iUnitOfWork.Complete();
        }

        /// <summary>
        /// Elimina una cuenta existente
        /// </summary>
        /// <param name="pAccountDTO"></param>
        public void EliminarCuenta(AccountDTO pAccountDTO)
        {
            Account cuenta;
            try
            {
                cuenta = this.iUnitOfWork.AccountRepository.Get(pAccountDTO.Id);
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar eliminar la cuenta");
            }
            //No se si esto va....Pero por las dudas
            if (cuenta == null)
            {
                throw new Exception("No existe la cuenta que quiere eliminar");
            }

            this.iUnitOfWork.AccountRepository.Remove(cuenta);
            this.iUnitOfWork.Complete();
        }

        /// <summary>
        /// Obtiene una ceunta por su id
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public AccountDTO ObtenerCuenta(int pId)
        {
            var cuenta = this.iUnitOfWork.AccountRepository.Get(pId);
            if (cuenta == null)
            {
                throw new Exception("No existe la cuenta que busca");
            }
            return Mapper.Map<AccountDTO>(cuenta);
        }

        /// <summary>
        /// Registra un movimiento en la cuenta
        /// </summary>
        /// <param name="pAccountDTO"></param>
        /// <param name="pDescripcion"></param>
        /// <param name="pAmount"></param>
        public void RegistrarMovimiento(AccountDTO pAccountDTO, String pDescripcion, double pAmount)
        {
            var cuenta = this.iUnitOfWork.AccountRepository.Get(pAccountDTO.Id);
            if (cuenta == null)
            {
                throw new Exception("No se encuentra la cuenta en la bd");
            }
            cuenta.Movements.Add(new AccountMovement(DateTime.Now, pDescripcion, pAmount));
            this.iUnitOfWork.Complete();
        }

        /// <summary>
        /// Obtiene todas las cuentas registradas en el sistema
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AccountDTO> ObtenerTodas()
        {
            IEnumerable<Account> lista;
            try
            {
                lista = this.iUnitOfWork.AccountRepository.GetAll();
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar obtener la lista");
            }

            return Mapper.Map<IEnumerable<AccountDTO>>(lista);
        }

        /// <summary>
        /// Obtiene las cuentas sobregiradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AccountDTO> ObtenerCuentasSobregiradas()
        {
            IEnumerable<Account> lista;
            try
            {
                lista = this.iUnitOfWork.AccountRepository.GetOverdrawnAccounts();
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar obtener la lista de cuentas sobregiradas");
            }

            return Mapper.Map<IEnumerable<AccountDTO>>(lista);
        }

        /// <summary>
        /// Obtiene el balance de una ceunta
        /// </summary>
        /// <param name="pAccountDTO"></param>
        /// <returns></returns>
        public double ObtenerBalance(AccountDTO pAccountDTO)
        {
            var cuenta = this.iUnitOfWork.AccountRepository.Get(pAccountDTO.Id);
            if (cuenta == null)
            {
                throw new Exception("No se puede obtener la cuenta");
            }
            try
            {
                return this.iUnitOfWork.AccountRepository.GetAccountBalance(cuenta);
            }
            catch (Exception)
            {
                throw new Exception("Error al obtener el balance de la cuenta");
            }
        }

        /// <summary>
        /// Obtiene los ultimos movimietos de la cuenta, por defecto: 7
        /// </summary>
        /// <param name="pAccountDTO"></param>
        /// <param name="pCantidad"></param>
        /// <returns></returns>
        public IEnumerable<AccountMovementDTO> ObtenerUltimosMovimientos(AccountDTO pAccountDTO, int pCantidad = 0)
        {
            IEnumerable<AccountMovement> lista;
            var cuenta = this.iUnitOfWork.AccountRepository.Get(pAccountDTO.Id);
            if (cuenta == null)
            {
                throw new Exception("No se encuentra la cuenta en la bd");
            }
            try
            {
                if (pCantidad > 0)
                {
                    lista = this.iUnitOfWork.AccountRepository.GetLastMovements(cuenta, pCantidad);
                }
                else
                {
                    lista = this.iUnitOfWork.AccountRepository.GetLastMovements(cuenta);
                }
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar obtener la lista de ultimos movimientos");
            }

            return Mapper.Map<IEnumerable<AccountMovementDTO>>(lista);
        }
    }
}
