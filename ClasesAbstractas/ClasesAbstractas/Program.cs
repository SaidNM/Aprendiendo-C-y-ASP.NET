using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteContacto cc = new ClienteContacto(1, "JUAN", "JN123", "4578963214", "1254789632", "ESCA", "45", "Rosales", "56608");
            Console.WriteLine("ID: " + cc.idCliente.ToString()+" nombre: "+cc.nombre);
            Console.WriteLine("Tel: "+ cc.Telefono +" CP:"+cc.Dir.cP);
            Console.ReadKey();
        }
        //Polimorfismo 
        //Se puede implementar un metodo a parti de declarar la super clase y asi todas las clases hijas podrán tener la funcionalidad. 
    }
}
