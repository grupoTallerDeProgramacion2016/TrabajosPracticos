using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class EncriptadorCesar : Encriptador
    {
        private int iDesplazamiento;

        public EncriptadorCesar(int pDesplazamiento):base("Cesar")
        {
            iDesplazamiento = pDesplazamiento;
        }

        public override string Encriptar(string pCadena)
        {
            throw new NotImplementedException();
        }

        public override string Desencriptar(string pCadena)
        {
            throw new NotImplementedException();
        }
    }
}
