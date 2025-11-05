using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.ClaseAbstractaEjemploReal
{
    internal class Auto: Vehiculo
    {
        //costo_base + (0.05 * km_recorridos).
        int costo_base = 1000;

        public double km_recorridos { get;  set; }
        public Auto(string marca, string modelo, int anio)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
        }
        public override double calcular_costo_mantenimiento()
        {

            return costo_base + (0.05 * km_recorridos);
        }
    }
}
