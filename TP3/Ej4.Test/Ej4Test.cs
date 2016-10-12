using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej4;

namespace Ej4.Test
{
    [TestClass]
    public class Ej4Test
    {
        [TestMethod]
        public void Encriptar_normal()
        {
            var encriptadorCesar = new EncriptadorCesar(2);
            var resultado = encriptadorCesar.Encriptar("abcd");
            Assert.AreEqual(resultado, "cdef");
        }

        [TestMethod]
        public void Encriptar_VuelveAEmpezar()
        {
            var encriptadorCesar = new EncriptadorCesar(4);
            var resultado = encriptadorCesar.Encriptar("yzZW");
            Assert.AreEqual(resultado, "cdDA");
        }

        [TestMethod]
        public void Desencriptar_normal()
        {
            var encriptadorCesar = new EncriptadorCesar(2);
            var resultado = encriptadorCesar.Desencriptar("cdef");
            Assert.AreEqual(resultado, "abcd");
        }

        [TestMethod]
        public void Desencriptar_VuelveAEmpezar()
        {
            var encriptadorCesar = new EncriptadorCesar(5);
            var resultado = encriptadorCesar.Desencriptar("AbZc"); 
            Assert.AreEqual(resultado, "VwUx");
        }

        [TestMethod]
        public void EncriptarAes_normal()
        {
            var encriptadorAES = new EncriptadorAES();
            var resultado = encriptadorAES.Encriptar("cabezon se la come gay");
            var des = encriptadorAES.Desencriptar(resultado);
            Assert.AreEqual(resultado, "cdef");
        }
    }
}
