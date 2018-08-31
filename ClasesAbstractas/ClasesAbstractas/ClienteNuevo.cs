using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public class ClienteNuevo : Clientes

    {
        public ClienteNuevo(){
            idCliente = 0;
            nombre = String.Empty;
            clave = String.Empty;
        }

        public ClienteNuevo(int id, string nombre, string clave) {
            this.idCliente = id;
            this.nombre = nombre;
            this.clave = clave;
        }
        public override int idCliente { get; set; }
        public override string nombre { get; set; }
        public override string clave { get; set; }
    }
}
