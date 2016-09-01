using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class JuegoAhorcado
    {
        private static string[] iPalabras = { "lindo", "amarillo", "computadora" };
        private static Partida[] iPartidas = { };
        public static int iErroresMaximo = 10;

        public static Partida IniciarPartida (string pJugador)
        {
            Random ran = new Random();
            int sel = ran.Next(0, iPalabras.Length-1); 
            Partida partida = new Partida(pJugador, iPalabras[sel]);
            //iPartidas.SetValue(partida, iPartidas.Length);
            return partida;

        }
    }
}
