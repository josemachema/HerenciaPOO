using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.AsesoriaHerencia
{
    internal class Destajo: ClasePadre
    {
       public int precioHora {  get; set; }
       public int horasTrabajadas { get; set; }
        public override double calcularSueldo( )
        {
            
            return precioHora*horasTrabajadas;

        }

    }
}
