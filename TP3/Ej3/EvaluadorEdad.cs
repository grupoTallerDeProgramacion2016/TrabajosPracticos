using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class EvaluadorEdad : IEvaluador
    {
        private int iEdadMinima;
        private int iEdadMaxima;

        public EvaluadorEdad(int pEdadMinima, int  pEdadMaxima)
        {
            iEdadMinima = pEdadMinima;
            iEdadMaxima = pEdadMaxima;
        }
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            DateTime fecActual = new DateTime();
            var fechaNac = pSolicitud.Cliente.FechaNacimiento;
            int anos = fecActual.Year - fechaNac.Year;
            return anos <= this.iEdadMaxima && anos >= this.iEdadMinima;
        }
    }
}
