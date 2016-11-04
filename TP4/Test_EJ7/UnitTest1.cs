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
            agenda.AgregarCalendario(calendario);

            CollectionAssert.Contains(agenda.ObtenerTodos(), calendario);
        }

        [TestMethod]
        public void EliminarCalendario()
        {
            var agenda = new Agenda();

            var calendario = new Calendario("mi primer calendario", DateTime.Now);
            agenda.AgregarCalendario(calendario);
            agenda.EliminarCalendario(calendario);

            CollectionAssert.DoesNotContain(agenda.ObtenerTodos(), calendario);
        }

        [TestMethod]
        public void ModificarCalendario()
        {
            var agenda = new Agenda();

            var calendario = new Calendario("mi primer calendario", DateTime.Now);
            agenda.AgregarCalendario(calendario);
            int id = calendario.IdCalendario;
            string tituloEsperado = "titulo modificado";
            calendario.Titulo = tituloEsperado;
            agenda.ModificarCalendario(calendario);

            Assert.AreEqual(agenda.);
        }

        [TestMethod]
        public void AgregarEvento()
        {
            var calendario = new Calendario("mi primer calendario", DateTime.Now);
            var evento = new Evento("primer evento", DateTime.Now, 1, Evento.Frecuencia.UnicaVez);

            calendario.agregarEvento(evento);

            CollectionAssert.Contains(calendario.ObtenerTodos(), evento);
        }

        [TestMethod]
        public void EliminarEvento()
        {
            var calendario = new Calendario("mi primer calendario", DateTime.Now);
            var evento = new Evento("primer evento", DateTime.Now, 1, Evento.Frecuencia.UnicaVez);

            calendario.agregarEvento(evento);

            CollectionAssert.Contains(calendario.ObtenerTodos(), evento);
        }
    }
}
