using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Vehiculo
    {

        protected string modelo;
        public void EncenderMotor()
        {
            MessageBox.Show("Motor Encendiendo");
        }
        public void MostrarInfo()
        {
            MessageBox.Show("Modelo: " + modelo);
        }
    }
}
