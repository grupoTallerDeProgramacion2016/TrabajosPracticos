using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Partida
    {
        private string iJugador;
        private DateTime iFecha;
        private int iHoraInicio;
        private int iHoraFin;
        private EstadoPartida iEstado;
        private string iPalabra;
        private string iPalabraActual;
        private string iErrores;
        private int iIntentos;


        public Partida(string pJugador, string pPalabra, int pIntentos)
        {
            //Constructor: inicializa una partida con un nombre de jugadro y una palabra al azar asignada
            iJugador = pJugador;
            iFecha = DateTime.Today;
            iHoraInicio = DateTime.Now.Minute*60 + DateTime.Now.Second;
            iPalabra = pPalabra;
            iIntentos = pIntentos;
        }

        //Propiedades
        public EstadoPartida Estado { get { return this.iEstado; } set { iEstado = value; } }

        public string Palabra
        {
            get
            {
                return iPalabra;
            }

        }

        public string PalabraActual
        {
            get
            {
                return iPalabraActual;
            }

            set
            {
                iPalabraActual = value;
            }
        }

        public string Errores
        {
            get
            {
                return iErrores;
            }

            set
            {
                iErrores = value;
            }
        }

        public int Intentos
        {
            get
            {
                return iIntentos;
            }

            set
            {
                iIntentos = value;
            }
        }

        public string Duracion
        {
            get
            {
                int duracion = DateTime.Now.Minute * 60 + DateTime.Now.Second - iHoraInicio;
                return duracion/60 + ":" + duracion%60;
            }

        }
    }
}
