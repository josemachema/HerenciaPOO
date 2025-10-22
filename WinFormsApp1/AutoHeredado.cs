using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class AutoHeredado:AutoPadre
    {
        public override string Arrancar()
        {
            return "Encendido por Boton";
        }

    }
}
