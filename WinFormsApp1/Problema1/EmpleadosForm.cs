using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Problema1
{
    public partial class EmpleadosForm : Form
    {
        Empleado empleado = new Empleado();
        Empleado empleadoCompleto = new EmpleadoTiempoCompleto();
        public EmpleadosForm()
        {
            InitializeComponent();
        }

        private void EmpleadosForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarInfo_Click(object sender, EventArgs e)
        {
            label1.Text = empleado.mostrar_informacion();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            label2.Text=empleadoCompleto.calcular_salario()
                .ToString();
        }
    }
}
