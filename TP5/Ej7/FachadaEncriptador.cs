using System.Collections.Generic;

namespace Ej7
{
    public class FachadaEncriptador
    {
        FabricaEncriptadores fabrica = FabricaEncriptadores.Instancia;

        /// <summary>
        /// Encripta el texto ingresado con el encriptador indicado con su nombre
        /// </summary>
        /// <param name="pNombreEncriptador"></param>
        /// <param name="pCadena"></param>
        /// <returns></returns>
        public string Encriptar(string pNombreEncriptador, string pCadena)
        {
            FabricaEncriptadores fEncriptador = FabricaEncriptadores.Instancia;
            var encriptador = fEncriptador.GetEncriptador(pNombreEncriptador);
            return encriptador.Encriptar(pCadena);
        }

        /// <summary>
        /// Encripta el texto ingresado con el encriptador indicado con su nombre
        /// </summary>
        /// <param name="pNombreEncriptador"></param>
        /// <param name="pCadena"></param>
        /// <returns></returns>
        public string Desencriptar(string pNombreEncriptador, string pCadena)
        {
            FabricaEncriptadores fEncriptador = FabricaEncriptadores.Instancia;
            var encriptador = fEncriptador.GetEncriptador(pNombreEncriptador);
            return encriptador.Desencriptar(pCadena);
        }

        /// <summary>
        /// Devuelve una lista de strings con los nombres de todos los encriptadores disponibles
        /// </summary>
        /// <returns></returns>
        public List<string> ObtenerEncriptadoresDisponibles()
        {
            return fabrica.ObtenerEncriptadoresDisponibles();
        }
    }
}
