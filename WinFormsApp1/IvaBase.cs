using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class IvaBase
    {
        public virtual double Iva(double costo)
        {
            return costo*0.16;   
        }

    }

    internal class IvaHijo:IvaBase
    {
        public override double Iva(double costo)
        {
            return costo * 0.8;
        }

    }
}
