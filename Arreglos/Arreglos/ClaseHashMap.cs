using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arreglos
{
    public class ClaseHashMap
    {
        Hashtable tabla;

        public ClaseHashMap() {
            tabla = new Hashtable();
        }

        public void llenarTabla() {
            tabla.Add("01", "Producto de cocina");
            tabla.Add("02", "Producto de Linea blanca");
            tabla.Add("03","Producto de electronica");
        }

        public void imprimirTabla() {
            Console.WriteLine("DAme la clave del producto");
            string clave = Console.ReadLine();
            Console.WriteLine(tabla[clave]);
            Console.ReadKey();
        }

    }
}
