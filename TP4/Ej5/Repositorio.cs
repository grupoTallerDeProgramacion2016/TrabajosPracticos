using System;
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
            throw new NotImplementedException();
        }

        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            return usuarios[pCodigo];
        }

        public List<Usuario> ObtenerTodos()
        {
            return null;
        }
    }
}
