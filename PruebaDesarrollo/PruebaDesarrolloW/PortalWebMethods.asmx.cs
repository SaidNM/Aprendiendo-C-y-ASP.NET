using PruebaDesarrolloW.MySQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace PruebaDesarrolloW
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class PortalWebMethods : System.Web.Services.WebService
    {
        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public List<string> cargarTodo(int tipo,int ord) {
            Console.WriteLine(tipo);
            string res = String.Empty;
            ProductoNegocio prodNeg = new ProductoNegocio();
            List<Producto> productos;
            if (tipo == 1)
            {
                if (ord == 1)
                {
                    productos = prodNeg.obtenerTodoByNombreASC();
                }
                else {
                    productos = prodNeg.obtenerTodoByNombreDESC();
                }
            }
            else if (tipo == 2)
            {
                if (ord == 1)
                {
                    productos = prodNeg.obtenerTodoByPrecioASC();
                }
                else
                {
                    productos = prodNeg.obtenerTodoByPrecioDesc();
                }
            }
            else {
                if (ord == 1)
                {
                    productos = prodNeg.obtenerTodoByExistenciaASC();
                }
                else
                {
                    productos = prodNeg.obtenerTodoByExistenciaDesc();
                }
            }

            List<string> resultados = new List<string>();
            foreach (var p in productos)
            {
                res = p.Nombre + "," + p.Precio.ToString() + "," + p.Descripcion + "," + p.Existencias.ToString() + "," + p.Categoria;
                resultados.Add(res);
                res = String.Empty;
            }
            return resultados;
        }



    }
}
