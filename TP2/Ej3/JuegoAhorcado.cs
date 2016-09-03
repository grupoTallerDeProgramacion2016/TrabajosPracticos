using System;
using System.Collections.Generic;

namespace Ej3
{
    class JuegoAhorcado
    {
        private string[] iPalabras = { "lindo", "amarillo", "computadora", "electromecanica", "sistemas",
                                        "frasco", "termo", "mouse", "teclado", "monedero", "pokemon", "murcielago", "pizarron",
                                        "cable", "monitor", "enchufe", "tapon", "mesada", "ventana", "portal", "automovil", "perro",
                                        "gato", "armario", "carpeta", "papel", "yerba", "marcador", "banco"};
        private List<Partida> iPartidas;
        private int iIntentos = 10;
        private Partida iPartidaActual;
        private Palabra iPalabra;
        private List<char> iLetrasCorrectas = new List<char>();
        private List<char> iLetrasIncorrectas = new List<char>();

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

        /// <summary>
        /// Devuelve las letras incorrectas que han sido ingresadas
        /// </summary>
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

        /// <summary>
        /// Inicializa una nueva partida y la guarda como partida actual en la clase
        /// </summary>
        /// <param name="pJugador"> Nombre del jugador </param>
        /// <returns></returns>
        public Partida IniciarPartida(string pJugador)
        {
            Random ran = new Random();
            int sel = ran.Next(0, this.iPalabras.Length - 1);
            Partida partida = new Partida(pJugador, this.iPalabras[sel], this.iIntentos);
            iPartidaActual = partida;
            iPartidaActual.Estado = EstadoPartida.EnCurso;
            iPalabra = new Palabra(this.iPalabras[sel]);
            return iPartidaActual;
        }

        /// <summary>
        /// Toma como entrada una letra y se encarga de modificar el estado
        /// del juego de acuerdo a si es correcta o no
        /// </summary>
        /// <param name="letra"> Letra que ingreso el jugador </param>
        /// <returns>Devuelve un objeto partida que contiene los datos de la partida actual</returns>
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

        /// <summary>
        /// Agrega una letra a cualquiera de las listas y se encarga de 
        /// verificar que no exista una letra igual ya ingresada
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="letra"></param>
        private void Agregar(List<char> lista, char letra)
        {
            if (!lista.Contains(letra))
            { lista.Add(letra); }
        }

        /// <summary>
        /// Guarda la partida actual en la lista iPartidas
        /// </summary>
        public void GuardarPartida()
        {
            iPartidas.Add(iPartidaActual);
        }

    }
}
