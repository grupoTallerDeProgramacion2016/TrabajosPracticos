using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
/// <summary>
/// Responde al ejercicio 5 del TP 4 (Encriptación invirtiendo cadena)
/// </summary>
    class InvertirCadena : Encriptador
    {
        private string iCadena;    
        public InvertirCadena(string pCadena) : base("")
        {
            iCadena = pCadena;
        }

        public override string Encriptar(string pCadena)
        {
            string encriptada = "";
            for (int i = pCadena.Length - 1; i>= 0; i--)
            {
                encriptada += pCadena[i];
            }
            return encriptada;
        }

        public override string Desencriptar(string pCadena)
        {
            string desencriptada = "";
            for (int i = pCadena.Length - 1; i >= 0; i--)
            {
                desencriptada += pCadena[i];
            }
            return desencriptada;
        }

        
    }

    
}
