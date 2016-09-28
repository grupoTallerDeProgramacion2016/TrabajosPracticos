using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Ahorcado
    {
        JuegoAhorcado juego1 = new JuegoAhorcado();
        
        /// <summary>
        /// listar las 5 mejores partidas de ahorcado
        /// </summary>
        public List<Partida> MejoresCinco
        {
            set { this.MejoresCinco = value; }
        }
       
        /// <summary>
        /// Iniciar una partida para poder jugar
        /// </summary>
        /// <param name="pJugador"> Nombre del jugador que inicio la partida</param>
        /// <returns> nueva PARTIDA iniciada</returns>
        public Partida IniciarPartida(string pJugador)
        {
            return juego1.IniciarPartida(pJugador);
        }

        /// <summary>
        /// Inserta una letra en el juego
        /// </summary>
        /// <param name="letra"> letra que se inserta por parte del usuario</param>
        /// <returns>  </returns>
        public Partida InsertarLetra(char letra)
        {
            return juego1.InsertarLetra(letra);
        }

      /*  public string NombreJugador
        {
            set { this.NombreJugador = value; }
        }

        public int Intentos
        {
            set { this.Intentos = value; }
        }
        */








    }
}
