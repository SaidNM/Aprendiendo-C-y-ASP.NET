using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaDesarrolloW.MySQL
{
    public class Producto
    {
        private string _Nombre;
        private double _Precio;
        private string _Descripcion;
        private int _Existencias;
        private string _Categoria;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public double Precio { get => _Precio; set => _Precio = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int Existencias { get => _Existencias; set => _Existencias = value; }
        public string Categoria { get => _Categoria; set => _Categoria = value; }
    }
}