using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.ClaseAbstractaEjemploReal
{
    internal abstract class Vehiculo
    {
       public string marca {  get; set; }
        public string modelo { get; set; }
        public int anio { get; set; }
        public abstract double calcular_costo_mantenimiento();

        public string[] mostrar_informacion()
        {
            return [marca, modelo ,anio.ToString()];
        }
    }
}
