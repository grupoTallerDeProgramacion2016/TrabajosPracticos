using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class EvaluadorCompuesto
    {
        private List<IEvaluador> iEvaluadores;

        public EvaluadorCompuesto()
        {

        }

        public bool EsValida(SolicitudPrestamo pSolicitud) { return true; }

        public void AgregarEvaluador(IEvaluador pEvaluador)
        {
            iEvaluadores.Add(pEvaluador);
        } 
    }
}
