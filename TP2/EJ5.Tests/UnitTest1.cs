using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej5;

namespace EJ5.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AgregarMes_NoBisiesto()
        {
            var fecha = new Fecha(2015, 1, 1);
            var fechaResultado = fecha.AgregarMeses(4);
            Assert.IsTrue(fechaResultado.Anio == 2015 && fechaResultado.Mes == 5 && fechaResultado.Dia == 1);
        }

        [TestMethod]
        public void AgregarMes_Bisiesto()
        {
            var fecha = new Fecha(2016, 1, 1);
            var fechaResultado = fecha.AgregarMeses(4);
            Assert.IsTrue(fechaResultado.Anio == 2016 && fechaResultado.Mes == 5 && fechaResultado.Dia == 1);
        }

        [TestMethod]
        public void AgregarAnio_NoBisiesto()
        {
            var fecha = new Fecha(2013, 1, 1);
            var fechaResultado = fecha.AgregarAnios(2);
            Assert.IsTrue(fechaResultado.Anio == 2015 && fechaResultado.Mes == 5 && fechaResultado.Dia == 1);
        }

        [TestMethod]
        public void AgregarAnio_Bisiesto()
        {
            var fecha = new Fecha(2015, 1, 1);
            var fechaResultado = fecha.AgregarAnios(3);
            Assert.IsTrue(fechaResultado.Anio == 2018 && fechaResultado.Mes == 5 && fechaResultado.Dia == 1);
        }

        [TestMethod]
        public void AgregarDias_NoBisiesto()
        {
            var fecha = new Fecha(2013, 2, 27);
            var fechaResultado = fecha.AgregarDias(2);
            Assert.IsTrue(fechaResultado.Anio == 2013 && fechaResultado.Mes == 3 && fechaResultado.Dia == 1);
        }

        [TestMethod]
        public void AgregarDias_Bisiesto()
        {
            var fecha = new Fecha(2016, 2, 27);
            var fechaResultado = fecha.AgregarDias(2);
            Assert.IsTrue(fechaResultado.Anio == 2016 && fechaResultado.Mes == 2 && fechaResultado.Dia == 29);
        }
    }
}
