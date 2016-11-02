using Ej7;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_EJ7
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AgregarCalendario()
        {
            var agenda = new Agenda();
            var calendario = new Calendario("mi primer calendario", DateTime.Now);

            CollectionAssert.Contains(agenda.ObtenerTodos(), calendario);
        }

        [TestMethod]
        public void AgregarEvento()
        {
            var calendario = new Calendario("mi primer calendario", DateTime.Now);
            var evento = new Evento("primer evento", DateTime.Now, "", "", "");

            CollectionAssert.Contains(calendario.ObtenerTodos(), evento);
        }
    }
}
