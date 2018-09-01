using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arreglo unidimensional
            int[] arreglo = new int[4];
            for (int i=0;i<arreglo.Length;i++) {
                arreglo[i] = i + 1;
                Console.WriteLine(arreglo[i]);
            }
            Console.ReadKey();

            //Arreglo multidimensional
            Matrices matriz = new Matrices();
            matriz.inicializarMatriz();
            matriz.imprimirMatriz();
            Console.ReadKey();

            //ArrayList
            Arrays lista = new Arrays();
            lista.capturarDatos();
            lista.imprimir();
            Console.ReadKey();

            // Hash Map
            ClaseHashMap tabla = new ClaseHashMap();
            tabla.llenarTabla();
            tabla.imprimirTabla();


        }
    }
}
