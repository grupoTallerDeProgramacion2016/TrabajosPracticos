using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class GestorPrestamo
    {
        private Dictionary<TipoCliente, IEvaluador> iEvaluadoresPorCliente;

        public GestorPrestamo()
        {

        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        { return true; }
    }
}
