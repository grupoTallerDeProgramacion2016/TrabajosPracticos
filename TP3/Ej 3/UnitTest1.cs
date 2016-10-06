using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej3;

namespace Ej_3
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void Test_Cliente_False()
        {            
            bool resultado = Isabel.EvaluarSolicitudPorCliente(22000.00, 32, 2);
         // bool resultadoEsperado = false;
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Test_Cliente_True()
        {            
            bool resultado = Isabel.EvaluarSolicitudPorCliente(110000.00, 32, 2);
            //bool resultadoEsperado = false;
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Test_NoCliente_False()
        {            
            bool resultado = Isabel.EvaluarSolicitudPorCliente(20000.00, 12, 1);
            //bool resultadoEsperado = false;
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Test_NoCliente_True()
        {          
            bool resultado = Isabel.EvaluarSolicitudPorCliente(22000.00, 12, 1);
            //bool resultadoEsperado = false;
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Test_ClienteGold_True()
        {           
            bool resultado = Isabel.EvaluarSolicitudPorCliente(150000.00, 60, 3);
            //bool resultadoEsperado = false;
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Test_ClienteGold_False()
        {            
            bool resultado = Isabel.EvaluarSolicitudPorCliente(200000.00, 60, 3);
            //bool resultadoEsperado = false;
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Test_ClientePremium_True()
        {
            bool resultado = Isabel.EvaluarSolicitudPorCliente(190000.00, 60, 4);
            //bool resultadoEsperado = false;
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Test_ClientePremium_False()
        {
            bool resultado = Isabel.EvaluarSolicitudPorCliente(210000.00, 60, 4);
            //bool resultadoEsperado = false;
            Assert.IsFalse(resultado);
        }


    }
}
