using System;

namespace Ej2
{
    /// <summary>
    /// Clase fachada que expone la funcionalidad division de la clase matematica
    /// </summary>
    public class Division
    {
        /// <summary>
        /// Obtiene la division entre 2 numeros x, y.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double obtenerDivision(double x, double y)
        {
            try
            {
                return Matematica.Dividir(x, y);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Se produjo una excepción, en la división!");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return 0;

        }



    }
}

