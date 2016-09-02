using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class JuegoAhorcado
    {
        private string[] iPalabras = { "lindo", "amarillo", "computadora", "electromecanica", "sistemas",
                                        "petigay", "rojo"};
        private List<Partida> iPartidas;
        private int iIntentos = 10;
        private Partida iPartidaActual;
        private Palabra iPalabra;
        private List<char> iLetrasCorrectas = new List<char>();
        private List<char> iLetrasIncorrectas = new List<char>();

        enum Estado { Ganada, Perdida, EnCurso };

        internal Partida PartidaActual
        {
            get
            {
                return iPartidaActual;
            }

            set
            {
                iPartidaActual = value;
            }
        }

        public Partida IniciarPartida (string pJugador)
        {
            Random ran = new Random();
            int sel = ran.Next(0, this.iPalabras.Length-1); 
            Partida partida = new Partida(pJugador, this.iPalabras[sel], this.iIntentos);
            iPartidaActual = partida;
            iPartidaActual.Estado = EstadoPartida.EnCurso;
            iPalabra = new Palabra(this.iPalabras[sel]);
            return iPartidaActual;
        }

        public Partida InsertarLetra(char letra)
        {
            if (iPalabra.VerificarLetra(letra))
            {
                this.Agregar(iLetrasCorrectas, letra);
                iPartidaActual.PalabraActual = iPalabra.PalabraActual(iLetrasCorrectas);
                if (iPalabra.EstaCompleta(iLetrasCorrectas))
                {
                    iPartidaActual.Estado = EstadoPartida.Ganada;
                }
                return iPartidaActual;
            }
            else
            {
                if (!iLetrasIncorrectas.Contains(letra))
                {
                    iPartidaActual.Intentos = iPartidaActual.Intentos - 1;
                }

                this.Agregar(iLetrasIncorrectas, letra);
                iPartidaActual.Errores = this.Errores;
                
                if (iPartidaActual.Intentos == 0)
                {
                    iPartidaActual.Estado = EstadoPartida.Perdida;
                }
                return iPartidaActual;
            }
        }

        private void Agregar(List<char> lista, char letra)
        {
            if (!lista.Contains(letra))
            { lista.Add(letra); }
        }

        public void GuardarPartida()
        {
            iPartidas.Add(iPartidaActual);
        }

        public string Errores
        {
            get
            {
                string cadena = "- ";
                foreach (char letra in this.iLetrasIncorrectas)
                {
                    cadena += letra + " - ";
                }

                return cadena;
            }
        }

    }
}
