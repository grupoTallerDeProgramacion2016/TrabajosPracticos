using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Program
    {
        //se declara static para poder accederla desde el menu y realizar las pruebas
        private static Cuentas cuentas = new Cuentas();

        static void Main(string[] args)
        {

            byte opcion = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("Banco Ballesteros");
                Console.WriteLine();
                Console.WriteLine("Seleccion Tipo de Caja: ");
                Console.WriteLine("1: Cuenta corriente ");
                Console.WriteLine("2: Caja de ahorro");
                Console.WriteLine("3: Salir");


                //verifica que la opcion sea un byte y evita que el programa salga inesperadamente
                try
                {
                    opcion = Convert.ToByte(Console.ReadLine());
                }
                catch (Exception e)
                {
                    //si el valor ingresado es incorrecto se muestra un mensaje al usuario y se continua el ciclo hasta que sea correctos
                    MensajeError("ingrese un numero del 1 al 3", e.ToString());
                    continue;
                }

                if (opcion == 1 || opcion == 2)
                {
                    Menu(opcion);

                }
                else
                {
                    if (opcion != 3) { Console.WriteLine("Ingreso una opcion incorrecta"); }
                }
                Console.ReadLine();

            } while (opcion != 3);

            Console.WriteLine("Saliendo del cajero.....");
            Console.ReadLine();

        }

        private static void Menu(byte seleccionCuenta)
        {

            //se inicializan las variables para realizar la prueba
            Cajero cajero = new Cajero();
            cajero.Cuentas = cuentas;
            cajero.SeleccionarCuenta(seleccionCuenta);

            byte opcion = 0;
            do
            {

                Console.Clear();
                Console.WriteLine("1: Depositar");
                Console.WriteLine("2: Retirar");
                Console.WriteLine("3: Transferir");
                Console.WriteLine("4: Consultar saldo");
                Console.WriteLine("5: Atras");

                //verifica que la opcion sea un byte y evita que el programa salga inesperadamente
                try
                {
                    opcion = Convert.ToByte(Console.ReadLine());
                }
                catch (Exception e)
                {
                    //si el valor ingresado es incorrecto se muestra un mensaje al usuario y se continua el ciclo hasta que sea correctos
                    MensajeError("ingrese un numero del 1 al 5", e.ToString());
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        double saldo;

                        Console.Clear();
                        Console.WriteLine("DEPOSITO");
                        Console.WriteLine("Ingrese la suma: ");
                        //verifica que la opcion sea un double y evita que el programa salga inesperadamente
                        try
                        {
                            saldo = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            //si el valor ingresado es incorrecto se muestra un mensaje al usuario y se vuelve al menu de operaciones
                            MensajeError("ingrese un numero con formato double", e.ToString());
                            continue;
                        }

                        try
                        {
                            cajero.AcreditarSaldo(saldo);
                            Console.WriteLine("Dinero acreditado");
                        }
                        catch (CuentaException ex)
                        {
                            Console.Clear();
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.GetType());
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                        double retiro;

                        Console.Clear();
                        Console.WriteLine("RETIRO");
                        Console.WriteLine("Ingrese la suma: ");

                        //verifica que la opcion sea un double y evita que el programa salga inesperadamente
                        try
                        {
                            retiro = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            //si el valor ingresado es incorrecto se muestra un mensaje al usuario y se vuelve al menu de operaciones
                            MensajeError("ingrese un numero con formato double", e.ToString());
                            continue;
                        }
                        try
                        {
                            cajero.DebitarSaldo(retiro);
                        }
                        catch (CuentaException ex)
                        {
                            Console.Clear();
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.GetType());
                        }
                        Console.ReadKey();

                        break;

                    case 3:
                        double transferencia;

                        Console.Clear();
                        Console.WriteLine("TRANSFERENCIA");
                        Console.WriteLine("Ingrese la suma a transferir: ");

                        //verifica que la opcion sea un double y evita que el programa salga inesperadamente
                        try
                        {
                            transferencia = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            //si el valor ingresado es incorrecto se muestra un mensaje al usuario y se vuelve al menu de operaciones
                            MensajeError("ingrese un numero con formato double", e.ToString());
                            continue;
                        }

                        try
                        {
                            cajero.Transferir(transferencia);
                            Console.WriteLine("transferencia realizada con exito!!");
                        }
                        catch (CuentaException ex)
                        {
                            Console.Clear();
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.GetType());
                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("CONSULTA DE SALDO");
                        Console.WriteLine("Su saldo es: " + cajero.ObtenerSaldo());
                        Console.ReadKey();

                        break;
                    case 5:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion incorrecta");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 5);
        }

        /// <summary>
        /// Imprime un mensaje de error al usuario con una sugerencia y el codigo del error
        /// </summary>
        /// <param name="sugerencia"></param>
        /// <param name="err"></param>
        private static void MensajeError(string sugerencia, string error)
        {
            Console.Clear();
            Console.WriteLine("Opcion ingresada incorrectamente");
            Console.WriteLine(" * " + sugerencia);
            Console.WriteLine();
            Console.WriteLine("Mensaje de error: " + error);
            Console.ReadLine();
        }
    }
}

