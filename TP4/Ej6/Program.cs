using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    class Program
    {
        static void Main(string[] args)
        {
            var rep = new RepositorioIList();

            var usr = new Usuario();
            usr.Codigo = "1";
            usr.NombreCompleto = "Cabezon";
            rep.Agregar(usr);
            usr = new Usuario();
            usr.Codigo = "2";
            usr.NombreCompleto = "Lautaro";
            rep.Agregar(usr);
            usr = new Usuario();
            usr.Codigo = "3";
            usr.NombreCompleto = "Balsan";
            rep.Agregar(usr);

            usr.NombreCompleto = "lucio";
            rep.Actualizar(usr);

            rep.Eliminar("1");

            Usuario res = rep.ObtenerPorCodigo("2");
        }
    }
}
