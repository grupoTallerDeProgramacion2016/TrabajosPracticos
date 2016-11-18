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

        [TestMethod]
        public void ModificarEvento()
        {
            var evento = new Evento("primer evento", DateTime.Now, 2, Evento.Frecuencia.UnicaVez);

            var calendario = new Calendario("mi primer calendario", DateTime.Now);
            calendario.agregarEvento(evento);
            int id = evento.IdEvento;
            string tituloEsperado = "titulo modificado";
            evento.Titulo = tituloEsperado;
            calendario.modificarEvento(evento);
        }

        [TestMethod]
        [ExpectedException(typeof(IdNegativoException))]
        public void ExcepcionIdCalendario()
        {
            var calendario = new Calendario("mi primer calendario", DateTime.Now);
            calendario.ObtenerPorId(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(FechaIncorrectaException))]
        public void ExcepcionFechaIncorrecta()
        {
            var evento = new Evento("primer evento", new DateTime(1920, 1, 1), 2, Evento.Frecuencia.UnicaVez);

            var calendario = new Calendario("mi primer calendario", DateTime.Now);
            calendario.agregarEvento(evento);
        }

        [TestMethod]
        public void ObtenerEventosPorDiaSemana()
        {
            var evento = new Evento("primer evento", new DateTime(2016, 11, 19), 2, Evento.Frecuencia.Semanal);

            var calendario = new Calendario("mi primer calendario", DateTime.Now);
            calendario.agregarEvento(evento);

            var resultado = calendario.ObtenerPorDiaSemana((int)DayOfWeek.Saturday);

            CollectionAssert.Contains(resultado, evento);
        }
    }
}
