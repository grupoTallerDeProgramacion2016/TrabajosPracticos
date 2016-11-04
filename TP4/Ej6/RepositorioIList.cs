using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
   public class RepositorioIList : IRepositorioUsuarios
    {

        IList<Usuario> usuarios = new List<Usuario>();

        public void Actualizar(Usuario pUsuario)
        {
            usuarios.Remove(pUsuario);
            usuarios.Add(pUsuario);
        }

        public void Agregar(Usuario pUsuario)
        {
            usuarios.Add(pUsuario);
        }

        public void Eliminar(string pCodigo)
        {
            var usr = new Usuario();
            usr.Codigo = pCodigo;
            usuarios.Remove(usr);
        }

       public List<Usuario> ObtenerOrdenadoPor(IComparer<Usuario> comparador)
        {
            var lista = usuarios.ToList();
            lista.Sort(comparador);
            return lista;
        }

        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            var usr = new Usuario();
            usr.Codigo = pCodigo;
            int indice = usuarios.IndexOf(usr);
            if (indice >= 0)
            {
                return usuarios[indice];
            }
            return null;
        }

        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> lista = usuarios.ToList();
            lista.Sort();
            return lista;
        }
    }
} 
