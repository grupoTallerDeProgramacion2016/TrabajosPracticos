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
            FachadaEncriptador fFachada = new FachadaEncriptador();
            IEncriptador cesar = fFachada.obtenerCesar();
            string resultado = cesar.Encriptar("abcd");
            string resultadoEsperado = "defg";
            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [TestMethod]
        public void Encriptar_VuelveAEmpezar()
        {
            FachadaEncriptador fFachada = new FachadaEncriptador();
            IEncriptador cesar = fFachada.obtenerCesar();
            string resultado = cesar.Encriptar("hola");
            string resultadoEsperado = ("hola");
            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [TestMethod]
        public void Desencriptar_normal()
        {
            FachadaEncriptador fFachada = new FachadaEncriptador();
            IEncriptador cesar = fFachada.obtenerCesar();
            string resultado = cesar.Desencriptar("Hola");
            string resultadoEsperado = "abcd";
            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [TestMethod]
        public void Desencriptar_VuelveAEmpezar()
        {
            FachadaEncriptador fFachada = new FachadaEncriptador();
            IEncriptador cesar = fFachada.obtenerCesar();
            string resultado = cesar.Desencriptar("AbZc");
            string resultadoEsperado = "vwUx";
            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [TestMethod]
        public void EncriptarAes_normal()
        {
            FachadaEncriptador fFachada = new FachadaEncriptador();
            IEncriptador aes = fFachada.obtenerAes();
            string resultado = aes.Encriptar("hola");
            string resultadoEsperado = "cdef";
            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [TestMethod]
        public void EncriptarAes_VuelveAEmpezar()
        {
            FachadaEncriptador fFachada = new FachadaEncriptador();
            IEncriptador aes = fFachada.obtenerAes();
            string resultado = aes.Encriptar("hola");
            string resultadoEsperado = ("hola");
            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [TestMethod]
        public void DesencriptarAes_normal()
        {
            FachadaEncriptador fFachada = new FachadaEncriptador();
            IEncriptador aes = fFachada.obtenerAes();
            string resultado = aes.Desencriptar("Hola");
            string resultadoEsperado = "abcd";
            Assert.AreEqual(resultado, resultadoEsperado);
        }


        [TestMethod]
        public void DesencriptarAes_VuelveAEmpezar()
        {
            FachadaEncriptador fFachada = new FachadaEncriptador();
            IEncriptador aes = fFachada.obtenerAes();
            string resultado = aes.Desencriptar("AbZc");
            string resultadoEsperado = "vwUx";
            Assert.AreEqual(resultado, resultadoEsperado);
        }

        
        [TestMethod]
        public void EncriptarNulo_Normal()
        {
            FachadaEncriptador fFachada = new FachadaEncriptador();
            IEncriptador nulo = fFachada.obtenerNulo();
            string resultado = nulo.Encriptar("hola");
            string resultadoEsperado = "cdef";
            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [TestMethod]
        public void EncriptarNulo_VuelveAEmpezar()
        {
            FachadaEncriptador fFachada = new FachadaEncriptador();
            IEncriptador nulo = fFachada.obtenerNulo();
            string resultado = nulo.Encriptar("hola");
            string resultadoEsperado = ("hola");
            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [TestMethod]
        public void DesencriptarNulo_normal()
        {
            FachadaEncriptador fFachada = new FachadaEncriptador();
            IEncriptador nulo = fFachada.obtenerNulo();
            string resultado = nulo.Desencriptar("Hola");
            string resultadoEsperado = "abcd";
            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [TestMethod]
        public void DesencriptarNulo_VuelveAEmpezar()
        {
            FachadaEncriptador fFachada = new FachadaEncriptador();
            IEncriptador nulo = fFachada.obtenerNulo();
            string resultado = nulo.Desencriptar("AbZc");
            string resultadoEsperado = "vwUx";
            Assert.AreEqual(resultado, resultadoEsperado);
        }


    }
}
