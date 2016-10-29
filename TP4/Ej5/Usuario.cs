﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    public class Usuario : IComparable<Usuario>
    {
        string iCodigo;
        string iNombreCompleto;
        string iCorreoElectronico;

        public string Codigo { get {return this.iCodigo; } set {this.iCodigo = value; } }
        public string NombreCompleto { get { return this.iNombreCompleto; } set { this.iNombreCompleto = value; } }
        public string CorreoElectronico { get { return this.iCorreoElectronico; } set { this.iCorreoElectronico = value; } }

        public int CompareTo(Usuario other)
        {
            return String.Compare(other.iNombreCompleto, iNombreCompleto);      
        }
    }
}
