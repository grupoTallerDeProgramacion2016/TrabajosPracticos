using System.Collections.Generic;
using System.Linq;

namespace Ej6
{
    /// <summary>
    /// Clase que implementa la interfaz de repositorio de usuarios utilizando una lista
    /// </summary>
    public class RepositorioIList : IRepositorioUsuarios
    {

        IList<Usuario> usuarios = new List<Usuario>();

        /// <summary>
        /// Actualiza un usuario con otro
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Actualizar(Usuario pUsuario)
        {
            usuarios.Remove(pUsuario);
            usuarios.Add(pUsuario);
        }

        /// <summary>
        /// Agrega un usuario al repositorio
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Agregar(Usuario pUsuario)
        {
            usuarios.Add(pUsuario);
        }

        /// <summary>
        /// Elimina un usuario del repositorio por su codigo
        /// </summary>
        /// <param name="pCodigo"></param>
        public void Eliminar(string pCodigo)
        {
            usuarios.Remove(new Usuario(pCodigo, "", ""));
        }

        /// <summary>
        /// Obtiene todos los usuarios ordenados por un comparador 
        /// </summary>
        /// <param name="comparador"></param>
        /// <returns></returns>
        public List<Usuario> ObtenerOrdenadoPor(IComparer<Usuario> comparador)
        {
            var lista = usuarios.ToList();
            lista.Sort(comparador);
            return lista;
        }

        /// <summary>
        /// Obtiene un usuario por su codigo
        /// </summary>
        /// <param name="pCodigo"></param>
        /// <returns></returns>
        public Usuario ObtenerPorCodigo(string pCodigo)
        {

            int indice = usuarios.IndexOf(new Usuario(pCodigo, "", ""));
            if (indice >= 0)
            {
                return usuarios[indice];
            }
            return null;
        }

        /// <summary>
        /// Obtiene todos los usuarios del repositorio
        /// </summary>
        /// <returns></returns>
        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> lista = usuarios.ToList();
            return lista;
        }

        /// <summary>
        /// Devuelve una lista de usuarios cuyo nombre completo contenga la cadena ingresada
        /// </summary>
        /// <param name="pCadena"></param>
        /// <returns></returns>
        public List<Usuario> BuscarPorAproximacion(string pCadena)
        {
            var resultado = new List<Usuario>();
            foreach (var usuario in this.usuarios)
            {
                if (usuario.NombreCompleto.Contains(pCadena))
                {
                    resultado.Add(Clonar(usuario));
                }
            }
            return resultado;
        }

        /// <summary>
        /// Metodo auxiliar para clonar un usuario con el objetivo de implementar "defensive copy"
        /// </summary>
        /// <param name="pUsuarioOriginal"></param>
        /// <returns></returns>
        private static Usuario Clonar(Usuario pUsuarioOriginal)
        {
            var clon = new Usuario(pUsuarioOriginal.Codigo, pUsuarioOriginal.NombreCompleto, pUsuarioOriginal.CorreoElectronico);
            return clon;
        }

        /// <summary>
        /// Comparador que ordena a los usuarios por codigo ascendente
        /// </summary>
        public class OrdenCodigoAscendente : IComparer<Usuario>
        {
            public int Compare(Usuario x, Usuario y)
            {
                return x.Codigo.CompareTo(y.Codigo);
            }
        }

        /// <summary>
        /// Comparador que ordena a los usarios por codigo descendente
        /// </summary>
        public class OrdenCodigoDescendente : IComparer<Usuario>
        {
            public int Compare(Usuario x, Usuario y)
            {
                return y.Codigo.CompareTo(x.Codigo);
            }
        }

        /// <summary>
        /// Comparador que ordena a los usuarios por correo electronico en orden ascendente
        /// </summary>
        public class OrdenCorreoElectronico : IComparer<Usuario>
        {
            public int Compare(Usuario x, Usuario y)
            {
                return x.CorreoElectronico.CompareTo(y.CorreoElectronico);
            }
        }
    }
}
