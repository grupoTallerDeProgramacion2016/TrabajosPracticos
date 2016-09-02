using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Program
    {
       static Cuentas clienteBanco = new Cuentas();
       static Cuenta cuenta1 = new Cuenta(5832, 1000);
       static Cuenta cuenta2 = new Cuenta(7666, 2500);

        static void Main(string[] args)
        {
            clienteBanco.CuentaCajaAhorro = cuenta1;
            clienteBanco.CuentaCorriente = cuenta2;

            byte opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("Banco Ballesteros");
                Console.WriteLine("Seleccion Tipo de Caja: ");
                Console.WriteLine("1: Cuenta corriente ");
                Console.WriteLine("2: Caja de ahorro");
                Console.WriteLine("3: Salir");

                opcion = Convert.ToByte(Console.ReadLine());

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

        public static void Menu(byte seleccionCuenta)
        {
            
            
            Cajero cajero = new Cajero();
            cajero.Cuentas = clienteBanco;
            cajero.SeleccionarCuenta(seleccionCuenta);
            Console.Clear();
            byte opcion = 0;
            do
            {

                Console.Clear();
                Console.WriteLine("1: Depositar");
                Console.WriteLine("2: Retirar");
                Console.WriteLine("3: Transferir");
                Console.WriteLine("4: Consultar saldo");
                Console.WriteLine("5: Atras");
                opcion = Convert.ToByte(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese la suma: ");
                        double saldo = Convert.ToDouble(Console.ReadLine());
                        cajero.AcreditarSaldo(saldo);
                        Console.WriteLine("Dinero acreditado");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("Ingrese la suma: ");
                        double retiro = Convert.ToDouble(Console.ReadLine());
                        if (cajero.DebitarSaldo(retiro))
                        {
                            Console.WriteLine("Retire su dinero");
                        }else
                        {
                            Console.WriteLine("No tiene saldo disponible");
                        }
                        Console.ReadKey();
                        
                        break;

                    case 3:
                        Console.WriteLine("Ingrese la suma a transferir: ");
                        double transferencia = Convert.ToDouble(Console.ReadLine());
                        if (cajero.Transferir(transferencia))
                        {
                            Console.WriteLine("Transferencia realizada con exito");
                        }
                        else
                        {
                            Console.WriteLine("No tiene saldo disponible");
                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("Su saldo es: " + cajero.ObtenerSaldo());
                        Console.ReadKey();

                        break;
                    case 5:
                        Console.WriteLine("Atras");
                        break;
                }
            } while (opcion != 5);
          }
    }
}
