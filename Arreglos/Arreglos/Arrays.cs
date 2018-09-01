using System;
using System.Collections;

namespace Arreglos
{
    public class Arrays
    {
        private ArrayList lista;

        public Arrays() {
            lista = new ArrayList();
        }

        public void capturarDatos() {
            string cadena = string.Empty;
            for (int i=0; i<3; i++) {
                cadena = Console.ReadLine();
                lista.Add(cadena);
            }
        }

        public void imprimir() {

            foreach (string dato in lista)
            {
                Console.WriteLine(dato);
            }
        }
    }
}
