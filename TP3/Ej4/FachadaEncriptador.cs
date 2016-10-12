using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class FachadaEncriptador
    {
        FabricaEncriptadores fabrica = FabricaEncriptadores.Instancia;

        public IEncriptador Encriptador(string pNombre)
        {
            return fabrica.GetEncriptador(pNombre);
        }
    }
}
