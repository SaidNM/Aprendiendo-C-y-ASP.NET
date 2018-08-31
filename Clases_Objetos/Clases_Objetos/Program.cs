using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleados empleado = new Empleados();
            empleado.Nombre = "Karina";
            empleado.Edad = 21;
            empleado.SueldoMensual = 20;
            
            Console.WriteLine("El salario del empleado "+empleado.Nombre +" es: "+empleado.calculaSalario(3).ToString());
            Console.ReadKey();
        }
    }
}
