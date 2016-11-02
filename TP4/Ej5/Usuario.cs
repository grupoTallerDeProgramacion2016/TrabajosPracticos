using System;

namespace Ej5
{
    public class Usuario
    {
        string iCodigo;
        string iNombreCompleto;
        string iCorreoElectronico;

        public string Codigo { get { return this.iCodigo; } set { this.iCodigo = value; } }
        public string NombreCompleto { get { return this.iNombreCompleto; } set { this.iNombreCompleto = value; } }
        public string CorreoElectronico { get { return this.iCorreoElectronico; } set { this.iCorreoElectronico = value; } }

        /// <summary>
        /// Metodo de comparacion del objeto que determina el orden por defecto
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Usuario other)
        {
            return String.Compare(other.iNombreCompleto, iNombreCompleto);
        }
    }
}
