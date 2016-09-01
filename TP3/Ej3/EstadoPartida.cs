using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class EstadoPartida
    {
        private string iPalabra;
        private int iErrores = 0;
        private List<char> iLetrasCorrectas = new List<char>();
        private List<char> iLetrasIncorrectas = new List<char>();

        public string Palabra
        {
            get { return this.iPalabra; }
            set { this.iPalabra = value; }
        }

        public int Errores
        {
            get { return this.iErrores; }
        }
    }
}
