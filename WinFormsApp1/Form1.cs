namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Auto auto = new Auto();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            auto.ConfigurarModelo("Tesla");
            auto.EncenderAuto();
            auto.MostrarAuto();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AutoPadre autoPadre = new AutoPadre();
            AutoHeredado autoHeredado = new AutoHeredado();
            MessageBox.Show(autoHeredado.Arrancar());
            MessageBox.Show(autoPadre.Arrancar());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            
            if (comboBox1.Text=="16%")
            {
                IvaBase ivaBase = new IvaBase();
                MessageBox.Show((ivaBase.Iva(Convert.ToDouble(txtIVA.Text)).ToString()));
            }
            if (comboBox1.Text == "8%")
            {
                IvaHijo ivaHijo = new IvaHijo();
                MessageBox.Show((ivaHijo.Iva(Convert.ToDouble(txtIVA.Text)).ToString()));

            }
        }
    }
}
