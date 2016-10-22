using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                streamReader = new StreamReader(path);
                string contenido = streamReader.ReadToEnd();
                Console.WriteLine(contenido);
                Console.ReadKey();
            }
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
