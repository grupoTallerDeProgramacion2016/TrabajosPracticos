using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Palabra
    {
        private string iPalabra;

        public Palabra(string palabra)
        {
            iPalabra = palabra;
        }

        public string StrPalabra
        {
            get { return this.iPalabra; }
            set { this.iPalabra = value; }
        }

        public string PalabraActual(List<char> pLetrasCorrectas)
        {

            string cadena = "";
            for (int i = 0; i < this.iPalabra.Length; i++)
            {
                if (pLetrasCorrectas.Contains(this.iPalabra[i]))
                {
                    cadena += this.iPalabra[i];
                }
                else
                {
                    cadena += "_";
                }
            }

            return cadena;
        }


        public bool VerificarLetra(char letra)
        {
            return this.iPalabra.Contains(letra);
        }

        public bool EstaCompleta(List<char> pLetrasCorrectas)
        {
            bool completa = true;
            int contador = 0;
            // Se recorren todas las letras de la palabra y se revisa que cada una esté en el vector de jugadas
            while (contador < this.iPalabra.Length - 1 && completa)
            {
                // Si la letra no está en el vector de jugadas, entonces la palabra no está completa
                if (! pLetrasCorrectas.Contains(this.iPalabra[contador]))
                    completa = false;
                contador++;
            }
            return completa;
        }
    }
}
