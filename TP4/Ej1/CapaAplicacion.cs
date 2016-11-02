using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaAplicacion
    {
        public void Ejecutar()
        {
            try
            {
                CapaDominio capaDom = new CapaDominio();
                capaDom.Ejecutar();

            }
            catch (ErrorPuntualException ex)
            {
                 
                throw new CapaAplicacionException("Error en la capa de Aplicacion", ex);

            }
            
        }
    }
}
