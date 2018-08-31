using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public class Imprimir : Interface1
    {
        public void imprimir(Clientes cliente)
        {
            Console.WriteLine("ID: " + cliente.idCliente.ToString() + " nombre: " + cliente.nombre);
            // Asi creo archivos.
            bool stop = true;
            int i =0;
            while (stop)
            {

                try
                {
                    StreamWriter ar = new StreamWriter("C:/Users/saidn/Desktop/Aprendiendo-C-y-ASP.NET/Bitacora.log", true); // El true nos permite seguir escribiendo en el archivo
                    ar.WriteLine("ID: " + cliente.idCliente.ToString() + " nombre: " + cliente.nombre);
                    ar.Close();
                    stop = false;
                }
                catch (Exception e)
                {
                    i++;
                    if (i>20) {
                        stop = false;
                        throw e;
                    }
                }
            }
        }

        public void imprimirContacto(ClienteContacto cliente)
        {
            Console.WriteLine("Tel: " + cliente.Telefono + " CP:" + cliente.Dir.cP);
        }
    }
}
