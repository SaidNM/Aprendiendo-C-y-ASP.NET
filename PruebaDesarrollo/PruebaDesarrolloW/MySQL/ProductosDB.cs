using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace PruebaDesarrolloW.MySQL
{
    public class ProductosDB
    {
        public List<Producto> seleccionarTodo() {
            Conexion conexion = new Conexion();
            MySqlConnection cnn = conexion.conexionDB();
            string query = "select producto.nombre, producto.precio , producto.descripcion, producto.existencias, categoria.descripcion from producto,categoria where producto.idCategoria=categoria.idCategoria";
            MySqlCommand comando = new MySqlCommand(query, cnn);
            MySqlDataReader reader;
            List<Producto> resultadoProducto = new List<Producto>();
            reader = comando.ExecuteReader();
            if (reader.HasRows) {
                while (reader.Read()) {
                    Producto p = new Producto();
                    p.Nombre = reader.GetString(0);
                    p.Precio = reader.GetDouble(1);
                    p.Descripcion = reader.GetString(2);
                    p.Existencias = reader.GetInt32(3);
                    p.Categoria = reader.GetString(4);
                    resultadoProducto.Add(p);
                }
            }
            cnn.Close();
            return resultadoProducto;
        }
        public List<Producto> seleccionarNombreASC()
        {
            Conexion conexion = new Conexion();
            MySqlConnection cnn = conexion.conexionDB();
            string query = "select producto.nombre, producto.precio , producto.descripcion, producto.existencias, categoria.descripcion from producto,categoria where producto.idCategoria=categoria.idCategoria order by producto.nombre asc";
            MySqlCommand comando = new MySqlCommand(query, cnn);
            MySqlDataReader reader;
            List<Producto> resultadoProducto = new List<Producto>();
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Producto p = new Producto();
                    p.Nombre = reader.GetString(0);
                    p.Precio = reader.GetDouble(1);
                    p.Descripcion = reader.GetString(2);
                    p.Existencias = reader.GetInt32(3);
                    p.Categoria = reader.GetString(4);
                    resultadoProducto.Add(p);
                }
            }
            cnn.Close();
            return resultadoProducto;
        }
        public List<Producto> seleccionarNombreDesc()
        {
            Conexion conexion = new Conexion();
            MySqlConnection cnn = conexion.conexionDB();
            string query = "select producto.nombre, producto.precio , producto.descripcion, producto.existencias, categoria.descripcion from producto,categoria where producto.idCategoria=categoria.idCategoria order by producto.nombre desc";
            MySqlCommand comando = new MySqlCommand(query, cnn);
            MySqlDataReader reader;
            List<Producto> resultadoProducto = new List<Producto>();
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Producto p = new Producto();
                    p.Nombre = reader.GetString(0);
                    p.Precio = reader.GetDouble(1);
                    p.Descripcion = reader.GetString(2);
                    p.Existencias = reader.GetInt32(3);
                    p.Categoria = reader.GetString(4);
                    resultadoProducto.Add(p);
                }
            }
            cnn.Close();
            return resultadoProducto;
        }
        public List<Producto> seleccionarPrecioASC()
        {
            Conexion conexion = new Conexion();
            MySqlConnection cnn = conexion.conexionDB();
            string query = "select producto.nombre, producto.precio , producto.descripcion, producto.existencias, categoria.descripcion from producto,categoria where producto.idCategoria=categoria.idCategoria order by producto.precio asc";
            MySqlCommand comando = new MySqlCommand(query, cnn);
            MySqlDataReader reader;
            List<Producto> resultadoProducto = new List<Producto>();
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Producto p = new Producto();
                    p.Nombre = reader.GetString(0);
                    p.Precio = reader.GetDouble(1);
                    p.Descripcion = reader.GetString(2);
                    p.Existencias = reader.GetInt32(3);
                    p.Categoria = reader.GetString(4);
                    resultadoProducto.Add(p);
                }
            }
            cnn.Close();
            return resultadoProducto;
        }
        public List<Producto> seleccionarPrecioDesc()
        {
            Conexion conexion = new Conexion();
            MySqlConnection cnn = conexion.conexionDB();
            string query = "select producto.nombre, producto.precio , producto.descripcion, producto.existencias, categoria.descripcion from producto,categoria where producto.idCategoria=categoria.idCategoria order by producto.precio desc";
            MySqlCommand comando = new MySqlCommand(query, cnn);
            MySqlDataReader reader;
            List<Producto> resultadoProducto = new List<Producto>();
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Producto p = new Producto();
                    p.Nombre = reader.GetString(0);
                    p.Precio = reader.GetDouble(1);
                    p.Descripcion = reader.GetString(2);
                    p.Existencias = reader.GetInt32(3);
                    p.Categoria = reader.GetString(4);
                    resultadoProducto.Add(p);
                }
            }
            cnn.Close();
            return resultadoProducto;
        }
        public List<Producto> seleccionarExistenciaASC()
        {
            Conexion conexion = new Conexion();
            MySqlConnection cnn = conexion.conexionDB();
            string query = "select producto.nombre, producto.precio , producto.descripcion, producto.existencias, categoria.descripcion from producto,categoria where producto.idCategoria=categoria.idCategoria order by producto.existencias asc";
            MySqlCommand comando = new MySqlCommand(query, cnn);
            MySqlDataReader reader;
            List<Producto> resultadoProducto = new List<Producto>();
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Producto p = new Producto();
                    p.Nombre = reader.GetString(0);
                    p.Precio = reader.GetDouble(1);
                    p.Descripcion = reader.GetString(2);
                    p.Existencias = reader.GetInt32(3);
                    p.Categoria = reader.GetString(4);
                    resultadoProducto.Add(p);
                }
            }
            cnn.Close();
            return resultadoProducto;
        }
        public List<Producto> seleccionarExistenciaDesc()
        {
            Conexion conexion = new Conexion();
            MySqlConnection cnn = conexion.conexionDB();
            string query = "select producto.nombre, producto.precio , producto.descripcion, producto.existencias, categoria.descripcion from producto,categoria where producto.idCategoria=categoria.idCategoria order by producto.existencias desc";
            MySqlCommand comando = new MySqlCommand(query, cnn);
            MySqlDataReader reader;
            List<Producto> resultadoProducto = new List<Producto>();
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Producto p = new Producto();
                    p.Nombre = reader.GetString(0);
                    p.Precio = reader.GetDouble(1);
                    p.Descripcion = reader.GetString(2);
                    p.Existencias = reader.GetInt32(3);
                    p.Categoria = reader.GetString(4);
                    resultadoProducto.Add(p);
                }
            }
            cnn.Close();
            return resultadoProducto;
        }



    }
}