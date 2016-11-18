namespace Ej7
{
    /// <summary>
    /// Responde al ejercicio 5 del TP 4 (Encriptación invirtiendo cadena)
    /// </summary>
    public class InvertirCadena : Encriptador
    {
        public InvertirCadena() : base("InvertirCadena")
        {
        }

        public override string Encriptar(string pCadena)
        {
            string encriptada = "";
            for (int i = pCadena.Length - 1; i >= 0; i--)
            {
                encriptada += pCadena[i];
            }
            return encriptada;
        }

        public override string Desencriptar(string pCadena)
        {
            string desencriptada = "";
            for (int i = pCadena.Length - 1; i >= 0; i--)
            {
                desencriptada += pCadena[i];
            }
            return desencriptada;
        }


    }


}
