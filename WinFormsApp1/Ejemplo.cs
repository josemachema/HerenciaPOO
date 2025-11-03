using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Ejemplo
    {
        public string Name { get; set; }    
        public void MostrarNombre()
        {
            MessageBox.Show(Name);
        }
        public Ejemplo() { }
        public Ejemplo(string name) { 
        Name=name;
        }
        public Ejemplo(string name, string apellido)
        {
            Name = name;
        }
    }
}
