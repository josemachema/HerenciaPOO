using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.ProblemaEdad
{
    internal class CalculadoraEdad
    {
        public int anoNacimiento {  get; set; }
        public int mesNacimiento {  get; set; }
       
        public int resta()
        {
            return 2025 - anoNacimiento;
        }

        public int CalcularEdad()
        {
            int mesActual = DateTime.Now.Month;
            int edad = resta();
            if (mesActual >= mesNacimiento) return edad;
            else return edad-1;
        }

    }
}
