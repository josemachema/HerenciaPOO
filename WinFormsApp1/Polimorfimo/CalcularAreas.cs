using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Polimorfimo
{
    internal class CalcularAreas:ClaseAbstracta
    {
        public override double CalcularArea(double Lado)
        {
            return Lado * Lado;

        }
        public double CalcularArea(double LadoRect, double altRect)
        {
            return LadoRect * altRect;

        }

    }
}
