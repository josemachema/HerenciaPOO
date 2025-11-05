namespace WinFormsApp1.ClaseAbstractaEjemploReal
{
    partial class FormsAbstracto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            lblCosto = new Label();
            lblAnio = new Label();
            lblModelo = new Label();
            lblMarca = new Label();
            txtKmRecorridos = new TextBox();
            btnCalcular = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(lblCosto);
            groupBox1.Controls.Add(lblAnio);
            groupBox1.Controls.Add(lblModelo);
            groupBox1.Controls.Add(lblMarca);
            groupBox1.Controls.Add(txtKmRecorridos);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(224, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 235);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calcular Auto";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(18, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(177, 151);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(51, 15);
            lblCosto.TabIndex = 7;
            lblCosto.Text = "lblCosto";
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(177, 122);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(42, 15);
            lblAnio.TabIndex = 6;
            lblAnio.Text = "blAnio";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(177, 92);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(61, 15);
            lblModelo.TabIndex = 5;
            lblModelo.Text = "lblModelo";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(177, 67);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(53, 15);
            lblMarca.TabIndex = 4;
            lblMarca.Text = "lblMarca";
            // 
            // txtKmRecorridos
            // 
            txtKmRecorridos.Location = new Point(28, 74);
            txtKmRecorridos.Name = "txtKmRecorridos";
            txtKmRecorridos.Size = new Size(100, 23);
            txtKmRecorridos.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(38, 103);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 56);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "Km Recorridos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 37);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Datos ";
            label1.Click += label1_Click;
            // 
            // FormsAbstracto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FormsAbstracto";
            Text = "FormsAbstracto";
            Load += FormsAbstracto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtKmRecorridos;
        private Button btnCalcular;
        private Label label2;
        private Label lblAnio;
        private Label lblModelo;
        private Label lblMarca;
        private Label lblCosto;
        private ComboBox comboBox1;
    }
}