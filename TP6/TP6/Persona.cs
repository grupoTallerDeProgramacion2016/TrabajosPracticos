using System.Collections.Generic;

namespace Ej1
{
    class Persona
    {
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public IList<Telefono> Telefonos { get; set; }
    }
}
