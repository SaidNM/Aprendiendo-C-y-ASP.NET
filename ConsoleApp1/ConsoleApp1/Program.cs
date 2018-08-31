using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Este es un Hola mundo en C#, se parece a JAVA xD
            Console.WriteLine("Hola mundo");
            Console.ReadKey();
            // Tipos de Datos 
            int numeroEntero = 0;
            decimal numeroDecimal = 0.0m; //La m indica que es de tipo decimal
            float numerito = 0.0f; // La f indica que es float
            double numeritoGrande = 0.0d; // la d indica que es double
            string cadena = "Hola Mundo";
            bool bandera = true;
            DateTime fecha = DateTime.Today;
            Console.WriteLine("El valor de entero es: {0}", numeroEntero);// Lo que esta entre las llaves es el elemento y el 0 es el tipo de dato, las variables van separadas por comas.
            Console.WriteLine("El valor de lo demas es: {0:C}", numeroDecimal);// La :C indica que es un tipo de formato de moneda
            Console.WriteLine("Otro valor es: {0:f2} {0:f4}", numerito,numeritoGrande);
            Console.WriteLine("Ahora tenemos una cadena que dice: " + cadena);
            Console.WriteLine("Este es un boolean: " + bandera.ToString());
            Console.WriteLine("Este es un tipo date" + fecha.ToShortDateString());
            Console.ReadKey();
            //Conversiones de Tipo
            int i = 10;
            decimal x = 12.2m;
            bool bandera1=true;
            string cadena1 = string.Empty;
            i = Convert.ToInt32(x);
            DateTime fecha1 = DateTime.MaxValue;
            Console.WriteLine("Aqui empieza otra seccion del curso de C#");
            Console.WriteLine(i);
            Console.WriteLine(x);
            Console.WriteLine(bandera1.ToString());
            Console.WriteLine(fecha1.ToShortDateString());
            Console.ReadKey();
            // Condicionales 
            int valor1 = 0, valor2 = 0;
            string dato;
            Console.WriteLine("Dame un valor: ");
            dato = Console.ReadLine();
            valor1 = Convert.ToInt32(dato);
            Console.WriteLine("Dame un valor: ");
            dato = Console.ReadLine();
            valor2 = Convert.ToInt32(dato);
            if (valor1 < valor2) {
                Console.WriteLine("El valor 1 es menor");
            } else if (valor2 < valor1) {
                Console.WriteLine("El valor 2 es menor");
            }else {
                Console.WriteLine("Son iguales");
            }
            Console.ReadKey();
            







        }
    }
}
