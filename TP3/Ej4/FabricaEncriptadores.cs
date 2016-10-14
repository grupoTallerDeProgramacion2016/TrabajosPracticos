using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
       public class FabricaEncriptadores
        {
            private static FabricaEncriptadores cInstancia;
            private static readonly Object Critico = new object();
            private Dictionary<String, IEncriptador> iEncriptadores;

            private FabricaEncriptadores()
            {
                Encriptador encriptador;
                this.iEncriptadores = new Dictionary<string, IEncriptador>();
                encriptador = new EncriptadorNulo();
                this.iEncriptadores.Add(encriptador.Nombre, encriptador);
                encriptador = new EncriptadorAES();
                this.iEncriptadores.Add(encriptador.Nombre, encriptador);
                encriptador = new EncriptadorCesar(3);
                this.iEncriptadores.Add(encriptador.Nombre, encriptador);
                encriptador = new InvertirCadena("");
                this.iEncriptadores.Add(encriptador.Nombre, encriptador);
            }

            public static FabricaEncriptadores Instancia
            {
                get
                {
                    if (cInstancia == null)
                    {
                        lock (Critico)
                            if (cInstancia == null)
                            {
                                cInstancia = new FabricaEncriptadores();
                            }

                    }
                    return cInstancia;
                }
            }

            public IEncriptador GetEncriptador(string pNombre)
            {
                IEncriptador Encriptador;
                if (!iEncriptadores.ContainsKey(pNombre))
                    Encriptador = new EncriptadorNulo();

                else
                    Encriptador = iEncriptadores[pNombre];
                return (Encriptador);
            }




        }
 }



