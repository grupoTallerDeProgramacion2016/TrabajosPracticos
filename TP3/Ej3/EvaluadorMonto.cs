using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class EvaluadorMonto : IEvaluador
    {
        private int iMontoMaximo;

        public EvaluadorMonto(int pMontoMaximo)
        {
            iMontoMaximo = pMontoMaximo;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return iMontoMaximo >= pSolicitud.Monto;
        }
    }
}
