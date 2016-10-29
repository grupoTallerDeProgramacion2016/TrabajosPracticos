using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaPersistencia
    {


        public CapaPersistencia(){

            this.Ejecutar(); 
        }

        public void Ejecutar()
        {
            //Se lanza una excepcion en la capa de persistencia con un mensaje que contiene la hora
            throw new ErrorPuntualException( "Se produjo un excepcion puntual en la capa persistencia" + " A las:" + ((string)DateTime.Now.ToString().Split(' ')[1]));
        }
    }
}
