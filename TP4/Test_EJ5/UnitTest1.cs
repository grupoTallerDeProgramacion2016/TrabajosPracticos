using Ej5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_EJ5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Alta()
        {
            var usuario = new Usuario();
            var repositorio = new Repositorio();
            usuario.NombreCompleto = "lucio rodriguez";
            usuario.CorreoElectronico = "utn@frcu.com";
            usuario.Codigo = "123";
            repositorio.Agregar(usuario);

            CollectionAssert.Contains(repositorio.ObtenerTodos(), usuario);
        }

        [TestMethod]
        public void Eliminar()
        {
            var usuario = new Usuario();
            usuario.NombreCompleto = "lucio rodriguez";
            usuario.CorreoElectronico = "utn@frcu.com";
            usuario.Codigo = "123";

            var repositorio = new Repositorio();

            repositorio.Agregar(usuario);

            repositorio.Eliminar("123");

            CollectionAssert.DoesNotContain(repositorio.ObtenerTodos(), usuario);
        }

        [TestMethod]
        public void Actualizar()
        {
            var usuario = new Usuario();
            usuario.NombreCompleto = "lucio rodriguez";
            usuario.CorreoElectronico = "utn@frcu.com";
            usuario.Codigo = "124";

            var usuario2 = new Usuario();
            usuario2.Codigo = "123";
            usuario2.NombreCompleto = "lucio rodriguez";
            usuario.CorreoElectronico = "utn@frcu.com";

            var repositorio = new Repositorio();

            repositorio.Agregar(usuario);
            repositorio.Actualizar(usuario2);

            Assert.AreNotEqual(usuario2, usuario);

        }

        [TestMethod]
        public void ObtenerTodos()
        {
            var usuario = new Usuario();
            var usuario2 = new Usuario();
            usuario.NombreCompleto = "matias rodriguez";
            usuario.CorreoElectronico = "utn@frcu.com";
            usuario.Codigo = "113";

            usuario2.NombreCompleto = "lucio rodriguez";
            usuario2.CorreoElectronico = "utn@frcu.com";
            usuario2.Codigo = "123";

            var repositorio = new Repositorio();

            repositorio.Agregar(usuario);
            repositorio.Agregar(usuario2);

            Assert.AreEqual(repositorio.ObtenerTodos().Count, 2);
        }

        [TestMethod]
        public void ObtenerPorCodigo()
        {
            var usuario = new Usuario();

            usuario.NombreCompleto = "lucio rodriguez";
            usuario.CorreoElectronico = "utn@frcu.com";
            usuario.Codigo = "123";



            var repositorio = new Repositorio();

            repositorio.Agregar(usuario);


            Assert.IsNotNull(repositorio.ObtenerPorCodigo("123"));
        }

        [TestMethod]
        public void ObtenerOrdenadosPor()
        {
            var usuario = new Usuario();
            var usuario2 = new Usuario();
            var usuario3 = new Usuario();
            var comparador = new Repositorio.OrdenCorreoElectronico();

            usuario.NombreCompleto = "lucio rodriguez";
            usuario.CorreoElectronico = "btn@frcu.com";
            usuario.Codigo = "123";
            usuario2.NombreCompleto = "matias ballesteros";
            usuario2.CorreoElectronico = "atn1@frcu.com";
            usuario2.Codigo = "124";
            usuario3.NombreCompleto = "lautaro zapata";
            usuario3.CorreoElectronico = "ctn2@frcu.com";
            usuario3.Codigo = "125";



            var repositorio = new Repositorio();

            repositorio.Agregar(usuario);
            repositorio.Agregar(usuario2);
            repositorio.Agregar(usuario3);

            Assert.AreEqual(repositorio.ObtenerOrdenadoPor(comparador)[0], usuario2);
            Assert.AreEqual(repositorio.ObtenerOrdenadoPor(comparador)[1], usuario);
            Assert.AreEqual(repositorio.ObtenerOrdenadoPor(comparador)[2], usuario3);
        }
    }
}
