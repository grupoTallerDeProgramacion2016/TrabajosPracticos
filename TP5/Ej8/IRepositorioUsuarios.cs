using System.Collections.Generic;

namespace Ej8
{
    public   interface IRepositorioUsuarios
    {
        /// <summary>
        /// Agrega un usuario al repositorio
        /// </summary>
        /// <param name="pUsuario"></param>
        void Agregar(Usuario pUsuario);

        /// <summary>
        /// Actualiza el usuario que se pasa como parametro
        /// </summary>
        /// <param name="pUsuario"></param>
        void Actualizar(Usuario pUsuario);

        /// <summary>
        /// Elimina el usuario con el codigo indicado
        /// </summary>
        /// <param name="pCodigo"></param>
        void Eliminar(string pCodigo);

        /// <summary>
        /// Retorna una lista con todos los usuarios del repositorio
        /// </summary>
        /// <returns></returns>
        List<Usuario> ObtenerTodos();

        /// <summary>
        /// Retorna el usuario con el codigo indicado
        /// </summary>
        /// <param name="pCodigo"></param>
        /// <returns></returns>
        Usuario ObtenerPorCodigo(string pCodigo);

        /// <summary>
        /// Obtiene una lista con todos los usuarios del repositorio ordenados
        /// por un criterio especificado
        /// </summary>
        /// <param name="comparador"></param>
        /// <returns></returns>
        List<Usuario> ObtenerOrdenadoPor(IComparer<Usuario> comparador);
    }
}
