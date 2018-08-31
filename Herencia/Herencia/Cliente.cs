using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Cliente
    {
        private string _Nombre;
        private int _IdCliente;
        private string _ApellidoPaterno;
        private string _ApellidoMaterno;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public string ApellidoPaterno { get => _ApellidoPaterno; set => _ApellidoPaterno = value; }
        public string ApellidoMaterno { get => _ApellidoMaterno; set => _ApellidoMaterno = value; }
    }
}
