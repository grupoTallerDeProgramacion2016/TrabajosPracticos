using System;

namespace Ej8
{
    public class Usuario : IComparable<Usuario>
    {
        string iCodigo;
        string iNombreCompleto;
        string iCorreoElectronico;

        public Usuario()
        {
        }

        public Usuario(string pCodigo, string pNombreCompleto, string pCorreoElectronico)
        {
            this.iCodigo = pCodigo;
            this.iNombreCompleto = pNombreCompleto;
            this.iCorreoElectronico = pCorreoElectronico;
        }

        public string Codigo { get { return this.iCodigo; } set { this.iCodigo = value; } }
        public string NombreCompleto { get { return this.iNombreCompleto; } set { this.iNombreCompleto = value; } }
        public string CorreoElectronico { get { return this.iCorreoElectronico; } set { this.iCorreoElectronico = value; } }

        public int CompareTo(Usuario other)
        {
            return String.Compare(other.iNombreCompleto, iNombreCompleto);
        }

        //Establece la igualdad por el codigo de los objetos
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return iCodigo == ((Usuario)obj).Codigo;
        }

        //Obtiene el hashcode transformando el codigo de string a un int32
        public override int GetHashCode()
        {
            return Convert.ToInt32(iCodigo);
        }
    }
}