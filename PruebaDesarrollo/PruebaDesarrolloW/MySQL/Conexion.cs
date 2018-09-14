using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


namespace PruebaDesarrolloW.MySQL
{
    public class Conexion
    {
        public MySqlConnection conexionDB() {
            MySqlConnection cnn = new MySqlConnection("server=localhost;port=3306;username=root; password=saidnm; database=examen");
            cnn.Open();
            return cnn;
        }        
    }
}