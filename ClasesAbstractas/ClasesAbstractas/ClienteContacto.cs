using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public class ClienteContacto : ClienteNuevo
    {
        public ClienteContacto() {
            _dir = new Direcciones();
        }
        public ClienteContacto(int pidCliente, string pNombre, string pClave, string telefono, string telefono1,
                                string pCalle,string pNoExterior, string pColonia, string pCP) {
            idCliente = pidCliente;
            nombre = pNombre;
            clave = pClave;
            Telefono = telefono;
            Telefono1 = telefono1;
            _dir = new Direcciones();
            Dir.calle = pCalle;
            Dir.colonia = pColonia;
            Dir.cP = pCP;
            Dir.numExterior = pNoExterior;



        }
        public string Telefono { get; set; }
        public string Telefono1 { get; set; }
        public Direcciones Dir { get => _dir; set => _dir = value; }

        private Direcciones _dir;

    }
}
