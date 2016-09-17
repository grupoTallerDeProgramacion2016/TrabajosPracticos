using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class SolicitudPrestamo
    {
        private Cliente iCliente;
        private double iMonto;
        private int iCantidadCuotas;

        public SolicitudPrestamo(Cliente pCliente, double pMonto, int pCantidadCuotas)
        {
            iCliente = pCliente;
            iMonto = pMonto;
            iCantidadCuotas = pCantidadCuotas;
        }

        public double Monto { get {return this.iMonto; } }

        public int CantidadCuotas { get {return this.iCantidadCuotas; } }

        public Cliente Cliente { get {return this.iCliente; } }
    }
}
