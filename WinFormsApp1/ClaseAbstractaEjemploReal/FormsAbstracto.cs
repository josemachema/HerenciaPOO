using Microsoft.VisualBasic.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.ClaseAbstractaEjemploReal
{
    /*
    1.	Crea una clase abstracta llamada Vehiculo que tenga:
	•	Atributos comunes: marca, modelo, anio.
	•	Un método abstracto calcular_costo_mantenimiento().
	•	Un método concreto mostrar_informacion()
que imprima los datos básicos del vehículo.
2.	Crea clases hijas:
	•	Auto
	•	Camion
	•	Moto
3.	Cada clase debe implementar el método abstracto:
	•	Auto: el costo se calcula como costo_base + (0.05 * km_recorridos).
	•	Camion: costo_base + (0.1 * km_recorridos) + (peso_carga* 0.02).
	•	Moto: costo_base + (0.03 * km_recorridos).
4.	En el programa principal:
	•	Crea una lista con distintos vehículos.
	•	Usa polimorfismo para recorrerlos y
calcular el costo total de mantenimiento.
	•	Muestra los resultados en pantalla*/
    public partial class FormsAbstracto : Form
    {
        List<Auto> autos = new List<Auto>();
        public FormsAbstracto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            foreach (Auto auto in autos)
            {
                if (comboBox1.Text== auto.marca + " " + auto.modelo)
                {
                    
                    auto.km_recorridos = Convert.ToDouble(txtKmRecorridos.Text);
                    lblCosto.Text = auto.calcular_costo_mantenimiento().ToString();
                    lblMarca.Text = auto.marca;
                    lblModelo.Text = auto.modelo;
                    lblAnio.Text = auto.anio.ToString();
                }
            }

            // Vehiculo vehiculos = new Auto();

            //Auto auto   = new Auto();
            /////////////////////////Cargar Datos del auto///////////////////
            /*
            auto.marca="Toyota";
            auto.modelo = "Cambry";
            auto.anio = 2005;
            auto.km_recorridos = Convert.ToDouble(txtKmRecorridos.Text);*/
            /////////////////////////Finalizp la Carga de Datos del auto///////////////////
            /*
            lblCosto.Text= auto.calcular_costo_mantenimiento().ToString();
            lblMarca.Text= auto.marca;
            lblModelo.Text= auto.modelo;    
            lblAnio.Text=auto.anio.ToString();*/
        }

        private void FormsAbstracto_Load(object sender, EventArgs e)
        {
            autos.Add(new Auto("toyota", "Cambry", 2005));
            autos.Add(new Auto("Honda", "Acord", 2000));
            autos.Add(new Auto("Kia", "Soul", 2022));
            foreach (Auto auto in autos)
            {
                comboBox1.Items.Add(auto.marca + " "+auto.modelo);
            }
        }
    }
}
