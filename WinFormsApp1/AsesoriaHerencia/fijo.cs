using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.AsesoriaHerencia
{
    internal class fijo : ClasePadre
    {
        public int sueldoDiario { get; set; }
        public int diasTrabajados { get; set; }
        public override double calcularSueldo()
        {
            if (diasTrabajados >= 7) return 0;
            else return sueldoDiario * diasTrabajados; ;


        }
    }
}
