using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Polimorfimo
{
    public partial class CalcularArea : Form
    {
        public CalcularArea()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularAreas calcularAreas = new CalcularAreas();  
            if (cmbTipoArea.Text=="Cuadrado")
            {
                double resultado = calcularAreas.CalcularArea(Convert.ToDouble(txtP1.Text));
                MessageBox.Show("El resultado del area del cuadrado es: "+resultado.ToString());
            }
        }

        private void cmbTipoArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoArea.Text == "Rectangulo")
            {
                txtP1.Visible = true;
                txtP2.Visible = true;
                lblP1.Text = "Base";
                lblP2.Text = "Altura";
                lblP1.Visible = true;
                lblP2.Visible = true;
                btnCalcular.Visible = false;
            }
            if (cmbTipoArea.Text == "Cuadrado")
            {
                txtP1.Visible = true;
                txtP2.Visible = false;
                lblP1.Text = "Lado";
                //lblP2.Text = "Altura";
                lblP1.Visible = true;
                lblP2.Visible = false;
                btnCalcular.Visible = false;
            }
        }

        private void CalcularArea_Load(object sender, EventArgs e)
        {
            txtP1.Visible = false;
            txtP2.Visible = false;
            lblP1.Visible = false;
            lblP2.Visible = false;
            btnCalcular.Visible = false;
        }

        private void txtP1_TextChanged(object sender, EventArgs e)
        {
            btnCalcular.Visible = true;
        }
    }
}
