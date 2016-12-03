using AutoMapper;
using Ej2.DAL.EntityFramework;
using Ej2.Domain;
using Ej2.DTO;
using System;
using System.Collections.Generic;

namespace Ej2.Logic
{
    /// <summary>
    /// Aisla toda la funcionalidad de la entidad cliente
    /// </summary>
    public class OperacionesCliente
    {
        private UnitOfWork iUnitOfWork;

        public OperacionesCliente(UnitOfWork pUnitOfWork)
        {
            this.iUnitOfWork = pUnitOfWork;
        }

        /// <summary>
        /// Crea un cliente nuevo
        /// </summary>
        /// <param name="pClientDTO"></param>
        public void CrearCliente(ClientDTO pClientDTO)
        {
            if (pClientDTO.Id > -1)
            {
                throw new Exception("No debes introducir un id para el cliente!");
            }
            if (String.IsNullOrWhiteSpace(pClientDTO.FirstName))
            {
                throw new Exception("Debes introducir un nombre para el cliente!");
            }
            if (String.IsNullOrWhiteSpace(pClientDTO.LastName))
            {
                throw new Exception("Debes introducir un apellido para el cliente!");
            }
            if (String.IsNullOrWhiteSpace(pClientDTO.DocumentNumber))
            {
                throw new Exception("Debes introducir un documento para el cliente!");
            }
            if (pClientDTO.DocumentType < 0)
            {
                throw new Exception("Debes introducir un tipo de documento para el cliente!");
            }
            try
            {
                var cliente = Mapper.Map<Client>(pClientDTO);
                this.iUnitOfWork.ClientRepository.Add(cliente);
                this.iUnitOfWork.Complete();
            }
            catch (Exception)
            {
                throw new Exception("Se produjo un error al guardar el cliente :(");
            }
        }

        /// <summary>
        /// Modifica un cliente existente si este existe
        /// </summary>
        /// <param name="pClientDTO"></param>
        public void ModificarCliente(ClientDTO pClientDTO)
        {

            if (String.IsNullOrWhiteSpace(pClientDTO.FirstName))
            {
                throw new Exception("Debes introducir un nombre para el cliente!");
            }
            if (String.IsNullOrWhiteSpace(pClientDTO.LastName))
            {
                throw new Exception("Debes introducir un apellido para el cliente!");
            }
            if (String.IsNullOrWhiteSpace(pClientDTO.DocumentNumber))
            {
                throw new Exception("Debes introducir un documento para el cliente!");
            }
            if (pClientDTO.DocumentType < 0)
            {
                throw new Exception("Debes introducir un tipo de documento para el cliente!");
            }

            var cliente = this.iUnitOfWork.ClientRepository.Get(pClientDTO.Id);
            if (cliente == null)
            {
                throw new Exception("El cliente que desea modificar no se encuentra en la bd!");
            }

            cliente.FirstName = pClientDTO.FirstName;
            cliente.LastName = pClientDTO.LastName;
            cliente.Document = new Document
            {
                Number = pClientDTO.DocumentNumber,
                Type = (DocumentType)pClientDTO.DocumentType,
            };

            this.iUnitOfWork.Complete();
        }

        /// <summary>
        /// Elimina un cliente si este existe
        /// </summary>
        /// <param name="pClientDTO"></param>
        public void EliminarCliente(ClientDTO pClientDTO)
        {
            Client cliente;
            try
            {
                cliente = this.iUnitOfWork.ClientRepository.Get(pClientDTO.Id);
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar eliminar cliente");
            }
            //No se si esto va....Pero por las dudas
            if (cliente == null)
            {
                throw new Exception("No existe el cliente que quiere eliminar");
            }

            this.iUnitOfWork.ClientRepository.Remove(cliente);
            this.iUnitOfWork.Complete();
        }

        /// <summary>
        /// Obtiene un cliente por su id
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public ClientDTO ObtenerCliente(int pId)
        {
            var cliente = this.iUnitOfWork.ClientRepository.Get(pId);
            if (cliente == null)
            {
                throw new Exception("No existe el cliente que busca");
            }
            return Mapper.Map<ClientDTO>(cliente);
        }

        /// <summary>
        /// Obtiene todos los clientes que se encuentran en la base de datos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ClientDTO> ObtenerTodos()
        {
            IEnumerable<Client> lista;
            try
            {
                lista = this.iUnitOfWork.ClientRepository.GetAll();
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar obtener la lista");
            }

            return Mapper.Map<IEnumerable<ClientDTO>>(lista);
        }
    }
}
