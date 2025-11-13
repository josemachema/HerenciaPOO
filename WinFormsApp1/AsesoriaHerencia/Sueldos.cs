using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.AsesoriaHerencia
{
    public partial class Sueldos : Form
    {
        public Sueldos()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Destajo destajo = new Destajo();
            destajo.horasTrabajadas = Convert.ToInt32(txtht.Text);
            destajo.precioHora = Convert.ToInt32(txtPH.Text);
            MessageBox.Show("Sueldo: " + destajo.calcularSueldo());
        }

        private void btnCalcularFijo_Click(object sender, EventArgs e)
        {
            fijo fijo = new fijo(); 
            fijo.sueldoDiario= Convert.ToInt32(txtSF.Text);
            fijo.diasTrabajados= Convert.ToInt32(txtDT.Text);
            double sueldo = fijo.calcularSueldo();
            if (sueldo == 0) MessageBox.Show("Estas agregando mas dias de la semana") ;
            else MessageBox.Show("Sueldo: " + sueldo);
        }
    }
}
