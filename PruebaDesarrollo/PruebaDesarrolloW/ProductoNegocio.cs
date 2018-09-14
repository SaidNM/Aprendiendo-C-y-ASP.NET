using PruebaDesarrolloW.MySQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaDesarrolloW
{
    public class ProductoNegocio
    {
        public List<Producto> obtenerTodo() {
            return new ProductosDB().seleccionarTodo();
        }
        public List<Producto> obtenerTodoByNombreASC() {
            return new ProductosDB().seleccionarNombreASC();
        }
        public List<Producto> obtenerTodoByNombreDESC()
        {
            return new ProductosDB().seleccionarNombreDesc();
        }
        public List<Producto> obtenerTodoByPrecioASC() {
            return new ProductosDB().seleccionarPrecioASC();
        }
        public List<Producto> obtenerTodoByPrecioDesc()
        {
            return new ProductosDB().seleccionarPrecioDesc();
        }
        public List<Producto> obtenerTodoByExistenciaASC()
        {
            return new ProductosDB().seleccionarExistenciaASC();
        }
        public List<Producto> obtenerTodoByExistenciaDesc()
        {
            return new ProductosDB().seleccionarExistenciaDesc();
        }
    }
}