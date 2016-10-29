using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class Repositorio : IRepositorioUsuarios
    {

        Dictionary<string, Usuario> usuarios;

        public Repositorio()
        {

        }

        public void Actualizar(Usuario pUsuario)
        {
            usuarios[pUsuario.Codigo] = pUsuario;
        }

        public void Agregar(Usuario pUsuario)
        {
            usuarios[pUsuario.Codigo] = pUsuario;
        }

        public void Eliminar(string pCodigo)
        {
            usuarios.Remove(pCodigo);
        }

        public List<Usuario> ObtenerOrdenadoPor(IComparer<Usuario> comparador)
        {
            List<Usuario> lista = this.ObtenerTodos();
            lista.Sort(comparador);
            return lista;
        }

        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            return usuarios[pCodigo];
        }

        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> lista = new List<Usuario>();
            lista = usuarios.Values.ToList();
            lista.Sort();
            return lista;
        }
    }

    public class OrdenCodigoAscendente : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return x.Codigo.CompareTo(y.Codigo);
        }
    }

    public class OrdenCodigoDescendente : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return y.Codigo.CompareTo(x.Codigo);
        }
    }

    public class OrdenCorreoElectronico : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return x.CorreoElectronico.CompareTo(y.CorreoElectronico);
        }
    }

    
}
