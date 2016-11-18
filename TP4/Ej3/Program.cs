using System;
using System.IO;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingresar el path del archivo: ");
            string path = Console.ReadLine();
            Console.WriteLine();
            StreamReader streamReader = null;

            try
            {
                //Al instanciar el objecto stream reader se pueden producir las excepciones
                streamReader = new StreamReader(path);
                string contenido = streamReader.ReadToEnd();
                Console.WriteLine(contenido);
                Console.ReadKey();
                //Alternativa 2: cerrar el Stream reader dentro del try, garantizano
                //que el streamReader se abrio, si no llega a esta instruccion entonces
                //no es necesario cerralo ya que el objeto sera null

                //streamReader.close();
            }

            //Realizamos el catch para cada los tipos de excepcion que se piden capturar 
            catch (ArgumentNullException)
            {
                Console.WriteLine("Upss! Se ha producido un error al intentar abrir el archivo :'(");
                Console.WriteLine("No se ingreso ninguna ruta del archivo");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Upss! Se ha producido un error al intentar abrir el archivo :'(");
                Console.WriteLine("La ruta del archivo ingresada no tiene un formato valido");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Upss! Se ha producido un error al intentar abrir el archivo :'(");
                Console.WriteLine("No se encuentra ningun archivo en la ruta especificada");
            }
            //Si utilizamos la alternativa 2 no incluimos el bloque finally
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }

        }
    }
}
