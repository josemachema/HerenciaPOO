using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Problema1
{
    internal class EmpleadoTiempoCompleto:Empleado
    {
        public override double calcular_salario()
        {
            return salario_base + (salario_base*.1) ;
        }

    }
}
