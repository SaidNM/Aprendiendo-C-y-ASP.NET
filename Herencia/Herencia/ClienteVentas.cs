using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class ClienteVentas : Cliente // De esta manera se indica la herencia
    {
        private string _RFC;
        private string _Callle;
        private string _Colonia;
        private string _Municipio;
        private bool _EsCreadito;

        public string RFC { get => _RFC; set => _RFC = value; }
        public string Callle { get => _Callle; set => _Callle = value; }
        public string Colonia { get => _Colonia; set => _Colonia = value; }
        public string Municipio { get => _Municipio; set => _Municipio = value; }
        public bool EsCreadito { get => _EsCreadito; set => _EsCreadito = value; }
    }
}
