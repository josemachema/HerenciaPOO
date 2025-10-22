using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Auto:Vehiculo
    {
        public void EncenderAuto()
        {
            base.EncenderMotor();
            MessageBox.Show("Auto Encendiendo");
        }
        public void ConfigurarModelo(string model)
        {
           base.modelo=model;
        }
        public void MostrarAuto()
        {
            base.MostrarInfo(); 
        }

    }
}
