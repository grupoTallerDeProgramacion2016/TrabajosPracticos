﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    public class DividirPorCeroException : Exception
    {
        
        public DividirPorCeroException(): base ("Error en la division entre 0")
        {

        }
    }
}
