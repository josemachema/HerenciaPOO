using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Asesoria : Form
    {
        public Asesoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejemplo obj = new Ejemplo("Juan","Martinez");
            obj.Name = textBox1.Text;
            obj.MostrarNombre();
        }
    }
}
