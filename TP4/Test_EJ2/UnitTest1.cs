using Ej2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_EJ2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SinExcepcion()
        {
            double num1 = 0;
            double num2 = 4;
            var division = new Division();
            double resultado = division.obtenerDivision(num1, num2);
            double resultadoEsperado = 0;
            Assert.AreEqual(resultado, resultadoEsperado);

        }

        [TestMethod]

        public void ConExcepcion()
        {

            double num1 = 4;
            double num2 = 0;
            Division division = new Division();

            try
            {

                double resultado = division.obtenerDivision(num1, num2);
            }
            catch (DividirPorCeroException)
            {
                Assert.IsTrue(true);
            }

        }
    }
}
