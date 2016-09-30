using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class EncriptadorNulo : Encriptador
    {
        public EncriptadorNulo() : base("Null")
        {

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
