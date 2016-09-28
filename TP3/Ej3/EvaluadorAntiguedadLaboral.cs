using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class EvaluadorAntiguedadLaboral : IEvaluador
    {
        private int iAntiguedadMinima;

        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            iAntiguedadMinima = pAntiguedadMinima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            DateTime fecActual = new DateTime();
            var fechaeEmpleo = pSolicitud.Cliente.Empleo.FechaIngreso;
            int antiguedad = (fecActual.Month - fechaeEmpleo.Month) + (fecActual.Year - fechaeEmpleo.Year) * 12;
            return antiguedad >= iAntiguedadMinima;
        }
    }
}
