using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Objetos
{
    public class Empleados
    {
        
        private string _Nombre;
        private decimal _SueldoMensual;
        private int _Edad;

        //Esto es encapsulamiento 
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public decimal SueldoMensual { get => _SueldoMensual; set => _SueldoMensual = value; }
        public int Edad { get => _Edad; set => _Edad = value; }
        //--------
        
        public Empleados(string nombre, decimal sueldoMensual, int edad)
        {
            this._Nombre = nombre;
            this.SueldoMensual = sueldoMensual;
            this.Edad = edad;
        }
        public Empleados() { }

        public decimal calculaSalario(int numeroDias) {
            return SueldoMensual*numeroDias;
        }

    }
}
