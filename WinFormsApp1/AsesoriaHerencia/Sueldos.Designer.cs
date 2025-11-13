namespace WinFormsApp1.AsesoriaHerencia
{
    partial class Sueldos
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            txtht = new TextBox();
            label1 = new Label();
            txtPH = new TextBox();
            btnCalcular = new Button();
            tabPage2 = new TabPage();
            label3 = new Label();
            txtSF = new TextBox();
            label4 = new Label();
            txtDT = new TextBox();
            btnCalcularFijo = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(53, 17);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(641, 429);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtht);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtPH);
            tabPage1.Controls.Add(btnCalcular);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(633, 401);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Destajo";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 129);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 4;
            label2.Text = "Horas Trabajadas";
            // 
            // txtht
            // 
            txtht.Location = new Point(210, 121);
            txtht.Name = "txtht";
            txtht.Size = new Size(100, 23);
            txtht.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 89);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 2;
            label1.Text = "Precio X Hora:";
            // 
            // txtPH
            // 
            txtPH.Location = new Point(210, 81);
            txtPH.Name = "txtPH";
            txtPH.Size = new Size(100, 23);
            txtPH.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(235, 214);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtSF);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtDT);
            tabPage2.Controls.Add(btnCalcularFijo);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(633, 401);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Fijo";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 145);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 9;
            label3.Text = "Sueldo Fijo";
            // 
            // txtSF
            // 
            txtSF.Location = new Point(241, 137);
            txtSF.Name = "txtSF";
            txtSF.Size = new Size(100, 23);
            txtSF.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 105);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 7;
            label4.Text = "Dias Trabajados:";
            // 
            // txtDT
            // 
            txtDT.Location = new Point(248, 97);
            txtDT.Name = "txtDT";
            txtDT.Size = new Size(100, 23);
            txtDT.TabIndex = 6;
            // 
            // btnCalcularFijo
            // 
            btnCalcularFijo.Location = new Point(266, 230);
            btnCalcularFijo.Name = "btnCalcularFijo";
            btnCalcularFijo.Size = new Size(75, 23);
            btnCalcularFijo.TabIndex = 5;
            btnCalcularFijo.Text = "Calcular";
            btnCalcularFijo.UseVisualStyleBackColor = true;
            btnCalcularFijo.Click += btnCalcularFijo_Click;
            // 
            // Sueldos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Sueldos";
            Text = "Sueldos";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TextBox txtPH;
        private Button btnCalcular;
        private TabPage tabPage2;
        private Label label2;
        private TextBox txtht;
        private Label label3;
        private TextBox txtSF;
        private Label label4;
        private TextBox txtDT;
        private Button btnCalcularFijo;
    }
}