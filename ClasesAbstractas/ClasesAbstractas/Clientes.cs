using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Clientes
    {
        public abstract int  idCliente{ get; set; }
        public abstract string nombre { get; set; }
        public abstract string  clave{ get; set; }

    }
}
