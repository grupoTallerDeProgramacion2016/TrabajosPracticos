using System.Collections.Generic;
using System.Linq;

namespace Ej5
{
    public class Repositorio : IRepositorioUsuarios
    {

        Dictionary<string, Usuario> usuarios;

        public Repositorio()
        {
            usuarios = new Dictionary<string, Usuario>();
        }

        /// <summary>
        /// Actualizar un usuario con otro que es pasado como parametro
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Actualizar(Usuario pUsuario)
        {
            usuarios[pUsuario.Codigo] = pUsuario;
        }

        /// <summary>
        /// Agregar un objeto usuario al repositorio
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Agregar(Usuario pUsuario)
        {
            usuarios[pUsuario.Codigo] = pUsuario;
        }

        /// <summary>
        /// Eliminar un usuario por su codigo
        /// </summary>
        /// <param name="pCodigo"></param>
        public void Eliminar(string pCodigo)
        {
            usuarios.Remove(pCodigo);
        }

        /// <summary>
        /// Obtener una lista de todos los usuarios ordenados por un comparador
        /// </summary>
        /// <param name="comparador"></param>
        /// <returns></returns>
        public List<Usuario> ObtenerOrdenadoPor(IComparer<Usuario> comparador)
        {
            List<Usuario> lista = this.ObtenerTodos();
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
            return usuarios[pCodigo];
        }

        /// <summary>
        /// Obtiene todos los usuarios. Por defecto estan ordenados por codigo
        /// </summary>
        /// <returns></returns>
        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> lista = new List<Usuario>();
            lista = usuarios.Values.ToList();
            return lista;
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
