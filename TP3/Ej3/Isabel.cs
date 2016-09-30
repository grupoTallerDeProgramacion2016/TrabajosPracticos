using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Isabel
    {
        static IDictionary<int, Cliente> Cliente;
        static Isabel()
        {
            Cliente cli;
            Cliente cli2;
            Cliente cli3;
            Cliente cli4;

            Cliente = new Dictionary<int,Cliente>();
            cli = new Cliente("Juan", "Aguilar", Convert.ToDateTime("27/06/1988"), new Empleo(15000.0, Convert.ToDateTime("15/08/2008")));
            cli.TipoCliente = TipoCliente.NoCliente;
            Cliente.Add(1,cli);

            cli2 = new Cliente("Matias", "Ballesteros", Convert.ToDateTime("10/02/1994"), new Empleo(25000.0, Convert.ToDateTime("30/06/2016")));
            cli2.TipoCliente = TipoCliente.cliente;
            Cliente.Add(2, cli2);

            cli3 = new Cliente("Lautaro", "Zapata", Convert.ToDateTime("27/06/1988"), new Empleo(1000.0, Convert.ToDateTime("30/06/2002")));
            cli3.TipoCliente = TipoCliente.ClienteGold;
            Cliente.Add(3,cli3);

            cli4 = new Cliente("Lucio", "Rodriguez", Convert.ToDateTime("3/12/1968"), new Empleo(3000.0, Convert.ToDateTime("12/01/2010")));
            cli4.TipoCliente = TipoCliente.ClientePlatinum;
            Cliente.Add(4,cli4);
        }
        
                
        public static bool EvaluarSolicitudPorCliente(double Monto, int CantCuotas, int pIdCliente)
        {
            GestorPrestamo gestor = new GestorPrestamo();
            Cliente mCliente = Cliente[pIdCliente]; 
            SolicitudPrestamo solicitud = new SolicitudPrestamo(mCliente, Monto, CantCuotas);
            if (gestor.EsValida(solicitud)){
                return true;
                
            }else
            {
                return false;
                
            }
            
        }
        
    }
}
