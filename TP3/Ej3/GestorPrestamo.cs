using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class GestorPrestamo
    {
        private IDictionary<TipoCliente, IEvaluador> iEvaluadoresPorCliente = new Dictionary<TipoCliente,IEvaluador>();

        public GestorPrestamo()
        {
            //Evaluadores comunes para todos los clientes
            EvaluadorAntiguedadLaboral evalAntiguedadLab = new EvaluadorAntiguedadLaboral(6);
            EvaluadorEdad evalEdad = new EvaluadorEdad(18,75);
            EvaluadorSueldo evalSueldo = new EvaluadorSueldo(5000);
            
            //Evaluadores para no clientes
            var evalMonto = new EvaluadorMonto(20000);
            var evalCantCuotas = new EvaluadorCantidadCuotas(12);
            var evalNoCliente = new EvaluadorCompuesto();
            evalNoCliente.AgregarEvaluador(evalAntiguedadLab);
            evalNoCliente.AgregarEvaluador(evalEdad);
            evalNoCliente.AgregarEvaluador(evalSueldo);
            evalNoCliente.AgregarEvaluador(evalMonto);
            evalNoCliente.AgregarEvaluador(evalCantCuotas);
            iEvaluadoresPorCliente.Add(TipoCliente.NoCliente, evalNoCliente);

            //Evaluadores para clientes
            var evalMontoCliente = new EvaluadorMonto(100000);
            var evalCantCliente = new EvaluadorCantidadCuotas(32);
            var evalCliente = new EvaluadorCompuesto();
            evalCliente.AgregarEvaluador(evalAntiguedadLab);
            evalCliente.AgregarEvaluador(evalEdad);
            evalCliente.AgregarEvaluador(evalSueldo);
            evalCliente.AgregarEvaluador(evalMontoCliente);
            evalCliente.AgregarEvaluador(evalCantCliente);
            iEvaluadoresPorCliente.Add(TipoCliente.cliente, evalCliente);

            //Evaluadores para cliente gold
            var evalMontoGold = new EvaluadorMonto(20000);
            var evalCantGold = new EvaluadorCantidadCuotas(12);
            var evalGold = new EvaluadorCompuesto();
            evalGold.AgregarEvaluador(evalAntiguedadLab);
            evalGold.AgregarEvaluador(evalEdad);
            evalGold.AgregarEvaluador(evalSueldo);
            evalGold.AgregarEvaluador(evalMontoGold);
            evalGold.AgregarEvaluador(evalCantGold);
            iEvaluadoresPorCliente.Add(TipoCliente.ClienteGold, evalGold);

            //Evaluadores para cliente Premium
            var evalMontoPremium = new EvaluadorMonto(20000);
            var evalCantPremium = new EvaluadorCantidadCuotas(12);
            var evalPremium = new EvaluadorCompuesto();
            evalPremium.AgregarEvaluador(evalAntiguedadLab);
            evalPremium.AgregarEvaluador(evalEdad);
            evalPremium.AgregarEvaluador(evalSueldo);
            evalPremium.AgregarEvaluador(evalMontoPremium);
            evalPremium.AgregarEvaluador(evalCantPremium);
            iEvaluadoresPorCliente.Add(TipoCliente.ClientePlatinum, evalPremium);
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            var evaluador = iEvaluadoresPorCliente[pSolicitud.Cliente.TipoCliente];
            return evaluador.EsValida(pSolicitud);
         
        }
    }
}
