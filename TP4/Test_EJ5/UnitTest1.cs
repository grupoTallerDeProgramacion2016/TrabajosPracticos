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

            repositorio.Agregar(usuario);

            Assert.IsNotNull(repositorio.ObtenerTodos());
        }

        [TestMethod]
        public void Baja()
        {
            var usuario = new Usuario();
            usuario.NombreCompleto = "lucio rodriguez";
            usuario.CorreoElectronico = "utn@frcu.com";
            usuario.Codigo = "123";

            var repositorio = new Repositorio();

            repositorio.Agregar(usuario);

            usuario.CorreoElectronico = "lucio_rodriguez@gmail.com";
            repositorio.Actualizar(usuario);

            Assert.IsTrue(repositorio.ObtenerPorCodigo("123") == usuario);
        }
    }
}
