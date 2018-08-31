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
            Imprimir imp = new Imprimir();
            try
            {
                imp.imprimir(cc);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            imp.imprimirContacto(cc);
            Console.ReadKey();
        }
        //Polimorfismo 
        //Se puede implementar un metodo a parti de declarar la super clase y asi todas las clases hijas podrán tener la funcionalidad. 
    }
}
