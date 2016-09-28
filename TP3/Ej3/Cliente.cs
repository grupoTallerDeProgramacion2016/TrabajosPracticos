using System;

namespace Ej3
{
    class Cliente
    {
        private string iNombre;
        private string iApellido;
        private DateTime iFechaNacimiento;
        private Empleo iEmpleo;
        private TipoCliente iTipoCliente;

        public Cliente(string pNombre, string pApellido, DateTime pFechaNacimiento, Empleo pEmpleo)
        {
            iNombre = pNombre;
            iApellido = pApellido;
            iFechaNacimiento = pFechaNacimiento;
            iEmpleo = pEmpleo;
            iTipoCliente = TipoCliente.NoCliente;
        }


        public string Nombre { get { return this.iNombre;} }

        public string Apellido { get { return this.Apellido; } }

        public DateTime FechaNacimiento { get {return this.iFechaNacimiento;}}

        public Empleo Empleo { get {return this.iEmpleo; } }

        public TipoCliente TipoCliente { get { return this.iTipoCliente; } set {this.iTipoCliente = value; } }
    }
}
