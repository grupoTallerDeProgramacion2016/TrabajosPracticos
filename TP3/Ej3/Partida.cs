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
        private bool iGanada = false;
        private EstadoPartida estado;

        public Partida(string pJugador, string pPalabra)
        {
            //Constructor: inicializa una partida con un nombre de jugadro y una palabra al azar asignada
            iJugador = pJugador;
            iFecha = DateTime.Today;
            iHoraInicio = (DateTime.Now.Hour * 60) + DateTime.Now.Minute;
            iGanada = false;
            estado.Palabra = pPalabra;
        }

        //Propiedades
        public string Palabra { get { return this.iPalabra; } }
        public int Errores { get { return this.iErrores; } }
        public string PalabraActual
        {
            get
            {
                string cadena = "";
                for (int i = 0; i < this.iPalabra.Length - 1; i++)
                {
                    if (this.iLetrasCorrectas.Contains(this.iPalabra[i]))
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
        }

        public bool VerificarLetra(char pLetra)
        {
            if (this.iPalabra.Contains(pLetra))//si la letra se encuentra en iPalabra devuelve true
            {
                iLetrasCorrectas.Add(pLetra);

            }
            else
            {
                this.iErrores++;
                iLetrasIncorrectas.Add(pLetra);
                if (this.iErrores == JuegoAhorcado.iErroresMaximo)
                {
                    this.iGanada = false;
                    return false;
                }
            }
            return true;
        }
    }
}
