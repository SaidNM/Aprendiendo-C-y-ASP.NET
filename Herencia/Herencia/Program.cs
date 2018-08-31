using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program 
    {
        static void Main(string[] args)
        {
            ClienteVentas cliente = new ClienteVentas();
            cliente.IdCliente = 1;
            cliente.Nombre = "Juan";
            cliente.ApellidoPaterno = "Bana";
            cliente.ApellidoMaterno = "na";
            cliente.Callle = "Canela 610";
            cliente.Colonia = "Mexico";
            cliente.Municipio = "Iztacalco";
            cliente.RFC = "JBNB0554";
            cliente.EsCreadito = true;
            Console.WriteLine(cliente.Nombre+" "+cliente.ApellidoPaterno+" "+cliente.ApellidoMaterno);
            Console.WriteLine(cliente.RFC);
            Console.ReadKey();

       

        }
    }
}
