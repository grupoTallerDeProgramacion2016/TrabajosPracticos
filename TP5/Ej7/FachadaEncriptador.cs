﻿using System.Collections.Generic;

namespace Ej7
{
    public class FachadaEncriptador
    {
        FabricaEncriptadores fabrica = FabricaEncriptadores.Instancia;

        public IEncriptador obtenerCesar()
        {
            FabricaEncriptadores fEncriptador = FabricaEncriptadores.Instancia;
            return fEncriptador.GetEncriptador("cesar");
        }
        public IEncriptador obtenerNulo()
        {
            FabricaEncriptadores fEncriptador = FabricaEncriptadores.Instancia;
            return fEncriptador.GetEncriptador("nulo");
        }
        public IEncriptador obtenerAes()
        {
            FabricaEncriptadores fEncriptador = FabricaEncriptadores.Instancia;
            return fEncriptador.GetEncriptador("aes");
        }

        public IEncriptador obtenerInvertirCadena()
        {
            FabricaEncriptadores fEncriptador = FabricaEncriptadores.Instancia;
            return fEncriptador.GetEncriptador("InvertirCadena");
        }
        public IEncriptador Encriptador(string pNombre)
        {
            return fabrica.GetEncriptador(pNombre);
        }

        public List<string> ObtenerEncriptadoresDisponibles()
        {
            return fabrica.ObtenerEncriptadoresDisponibles();
        }
    }
}
