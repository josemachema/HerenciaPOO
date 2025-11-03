using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Problema1
{
    internal class EmpleadoPorHoras:Empleado
    {
        int horasTrabajadas { get; set;   }
        double PrecioHora {  get; set; }

        public override double calcular_salario()
        {

            return horasTrabajadas*PrecioHora;
        }
    }
}
