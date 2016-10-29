﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaVista
    {
        public void Ejecutar()
        {
            try
            {
                CapaControlador capaCon = new CapaControlador();
                capaCon.Ejecutar();
            }
            catch(CapaAplicacionException ex)
            {

                Console.WriteLine(ex.InnerException);
                Console.ReadKey();

            }

        }
    }
}
