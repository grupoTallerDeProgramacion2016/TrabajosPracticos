
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Ej4.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEsReal_Verdadero()
        {
            var complejo = new Complejo(2.0,0);
            bool resultado = complejo.EsReal();
            bool resultadoEsperado = true;
            Assert.AreEqual(resultadoEsperado, resultado);

        }
        
        [TestMethod]
        public void TestEsImaginario_Verdadero()
        {
            var complejo = new Complejo(2.0, 1);
            bool resultado = complejo.EsImaginario();
            bool resultadoEsperado = true;
            Assert.AreEqual(resultadoEsperado, resultado);

        }

        [TestMethod]
        public void TestArgumentoEnRadianes_Positivo()
        {
            var complejo = new Complejo(2.0, 1);
            double resultado = complejo.ArgumentoEnRadianes;
            double resultadoEsperado = 0.463;
            Assert.AreEqual(resultadoEsperado, resultado, 0.1);
        }

        [TestMethod]
        public void TestArgumentoEnGrados_Positivo_ConCalculadoraEnRadianes()
        {
            var complejo = new Complejo(2.0, 1);
            double resultado = complejo.ArgumentoEnGrados;
            double resultadoEsperado = 26.527;
            Assert.AreEqual(resultadoEsperado, resultado, 0.1);
        }

        [TestMethod]
        public void TestConjugado_Positivo()
        {
            var complejo = new Complejo(2.0, 1);
            Complejo resultado = complejo.Conjugado;
            Complejo resultadoEsperado = new Complejo(2.0,-1);
            Assert.AreEqual(resultadoEsperado.Imaginario, resultado.Imaginario);
        }


        [TestMethod]
        public void TestMagnitud_Positivo()
        {
            var complejo = new Complejo(3, 4);
            double resultado = complejo.Magnitud;
            double resultadoEsperado = 5;
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void EsIgual_DosParámetro_Positivo()
        {
            var complejo = new Complejo(3, 4);
            bool resultado = complejo.EsIgual(3,4);
            bool resultadoEsperado = true;
            Assert.AreEqual(resultadoEsperado, resultado);
        }

         [TestMethod]
        public void EsIgual_UnParámetro_Positivo()
        {
            var complejo = new Complejo(3, 4);
            bool resultado = complejo.EsIgual(new Complejo(3, 4));
            bool resultadoEsperado = true;
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Sumar_Positivo()
        {
            var complejo = new Complejo(3, 4);
            Complejo resultado = complejo.Sumar(new Complejo(3, 4));
            Complejo resultadoEsperado = new Complejo(6,8);
            Assert.ReferenceEquals(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Sumar_Negativo()
        {
            var complejo = new Complejo(-1, -1);
            Complejo resultado = complejo.Sumar(new Complejo(-2, -1));
            Complejo resultadoEsperado = new Complejo(-3, -2);
            Assert.ReferenceEquals(resultadoEsperado, resultado);
        }
                
        [TestMethod]
        public void Restar_Positivo()
        {
            var complejo = new Complejo(3, 4);
            Complejo resultado = complejo.Restar(new Complejo(2, 3));
            Complejo resultadoEsperado = new Complejo(1, 1);
            Assert.ReferenceEquals(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Restar_Negativo()
        {
            var complejo = new Complejo(-3, -4);
            Complejo resultado = complejo.Restar(new Complejo(-2, -3));
            Complejo resultadoEsperado = new Complejo(-1, -1);
            Assert.ReferenceEquals(resultadoEsperado, resultado);
        }


        [TestMethod]
        public void Multiplicar_2Positivo()
        {
            var complejo = new Complejo(1, 2);
            Complejo resultado = complejo.Multiplicar(new Complejo(2, 3));
            Complejo resultadoEsperado = new Complejo(1, 5);
            Assert.ReferenceEquals(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Multiplicar_2Negativo()
        {
            var complejo = new Complejo(-2, -1);
            Complejo resultado = complejo.Multiplicar(new Complejo(-1, -2));
            Complejo resultadoEsperado = new Complejo(-2, 5);
            Assert.ReferenceEquals(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Multiplicar_PositivoyNegativo()
        {
            var complejo = new Complejo(2, 1);
            Complejo resultado = complejo.Multiplicar(new Complejo(-1, -2));
            Complejo resultadoEsperado = new Complejo(-4, -2);
            Assert.ReferenceEquals(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Multiplicar_Null()
        {
            var complejo = new Complejo(2, 1);
            Complejo resultado = complejo.Multiplicar(new Complejo(0, 0));
            Complejo resultadoEsperado = new Complejo(0, 0);
            Assert.ReferenceEquals(resultadoEsperado, resultado);
        }

         [TestMethod]
         public void Dividir_Positivo()
         {
             var complejo = new Complejo(100, 100);
             Complejo numero = new Complejo(2, 1.2);
             Complejo resultado = complejo.Dividir(numero);
             Complejo resultadoEsperado =new Complejo(58.82 , 14.70);
             Assert.ReferenceEquals(resultadoEsperado, resultado);
         }

        [TestMethod]
        public void Dividir_Negativo()
        {
            var complejo = new Complejo(-100, -100);
            Complejo numero = new Complejo(-2, -1.2);
            Complejo resultado = complejo.Dividir(numero);
            Complejo resultadoEsperado = new Complejo(58.82, 14.70);
            Assert.ReferenceEquals(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Dividir_PositivoyNegativo()
        {
            var complejo = new Complejo(100, 100);
            Complejo numero = new Complejo(-2, -1.2);
            Complejo resultado = complejo.Dividir(numero);
            Complejo resultadoEsperado = new Complejo(-58.82, -14.70);
            Assert.ReferenceEquals(resultadoEsperado, resultado);
        }

        /*[TestMethod]
        public void Dividir_PositivoyNegativo()
        {
            var complejo = new Complejo(100, 100);
            Complejo numero = new Complejo(-2, -1.2);
            Complejo resultado = complejo.Dividir(numero);
            Complejo resultadoEsperado = new Complejo(-58.82, -14.70);
            Assert.ReferenceEquals(resultadoEsperado, resultado);
        }*/
    }
}
