using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Problema1
{
    internal class Empleado
    {
        public string nombre {  get; set; }
        public int id_impleado { get; set; }
        public double salario_base { get; set; } = 500;

        public string mostrar_informacion()
        {
            return "Nombre: "+nombre + "Id Empleado: "+id_impleado.ToString() + "Salario Base: "+salario_base.ToString();
        }
        public virtual double calcular_salario()
        {
            return salario_base;
        }

    }
}
