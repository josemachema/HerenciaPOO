using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.ProblemaEdad
{
    public partial class EdadForm : Form
    {
        public EdadForm()
        {
            InitializeComponent();
        }

        private void btlCalcular_Click(object sender, EventArgs e)
        {
            CalculadoraEdad edad = new CalculadoraEdad();
            edad.anoNacimiento = Convert.ToInt32(txtanoNacimiento.Text);
            edad.mesNacimiento = Convert.ToInt32(txtMesNacimiento.Text);

            MessageBox.Show(edad.CalcularEdad().ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
