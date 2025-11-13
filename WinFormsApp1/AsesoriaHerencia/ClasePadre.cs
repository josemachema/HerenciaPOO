using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.AsesoriaHerencia
{
    internal class ClasePadre
    {
        int id_Empleado {  get; set; }
        string nombre { get; set; }
        int telefono {  get; set; }

        public virtual double calcularSueldo()
        {
            return 5000;
        }
    }
}
