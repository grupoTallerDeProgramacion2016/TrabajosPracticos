using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7
{
    public class EncriptadorCesar : Encriptador
    {
        private int iDesplazamiento;

        public EncriptadorCesar(int pDesplazamiento):base("Cesar")
        {
            iDesplazamiento = pDesplazamiento;
        }

        public override string Encriptar(string pCadena)
        {
            string encriptada = "";
            foreach (var letra in pCadena)
            {
                if (Char.IsLetter(letra))
                {
                    var ascii = Encoding.ASCII.GetBytes(letra.ToString())[0];
                    var enc = ascii + iDesplazamiento;
                    if ((enc > 90 & enc < 97) || enc > 122)
                    {
                        enc -= 26;
                    }
                    encriptada += (char) enc;
                }
                else
                {
                    encriptada += letra;
                }

            }
            return encriptada;
        }

        public override string Desencriptar(string pCadena)
        {
            string desencriptada = "";
            foreach (var letra in pCadena)
            {
                if (Char.IsLetter(letra))
                {
                    var ascii = Encoding.ASCII.GetBytes(letra.ToString())[0];
                    var enc = ascii - iDesplazamiento;
                    if ((enc > 90 & enc < 97) || enc < 65)
                    {
                        enc += 26;
                    }
                    desencriptada += (char) enc;
                }
                else
                {
                    desencriptada += letra;
                }

            }
            return desencriptada;
        }
    }
}
