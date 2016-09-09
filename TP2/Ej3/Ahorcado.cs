using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Ahorcado
    {
        JuegoAhorcado juego1 = null;
        Partida partida1 = null;

        public List<Partida> MejoresCinco
        {
            set { this.MejoresCinco = value; }
        }
       
        public Partida IniciarPartida(string pJugador)
        {
            return juego1.IniciarPartida(pJugador);
        }

        public Partida InsertarLetra(char letra)
        {
            return juego1.InsertarLetra(letra);
        }

        public string NombreJugador
        {
            set { this.NombreJugador = value; }
        }

        public int Intentos
        {
            set { this.Intentos = value; }
        }









    }
}
