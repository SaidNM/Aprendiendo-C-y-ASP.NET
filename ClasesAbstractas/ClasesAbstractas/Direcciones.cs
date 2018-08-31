using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public class Direcciones
    {
        public Direcciones() {
            calle = String.Empty;
            numExterior = String.Empty;
            colonia = String.Empty;
            cP = String.Empty;
        }


        public string calle { get; set; }
        public string numExterior { get; set; }
        public string colonia { get; set; }
        public string cP { get; set; }
    }
}
