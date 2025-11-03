namespace WinFormsApp1.Polimorfimo
{
    partial class CalcularArea
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
            btnCalcular = new Button();
            cmbTipoArea = new ComboBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            lblP1 = new Label();
            lblP2 = new Label();
            txtP2 = new TextBox();
            txtP1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(83, 197);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // cmbTipoArea
            // 
            cmbTipoArea.FormattingEnabled = true;
            cmbTipoArea.Items.AddRange(new object[] { "Cuadrado", "Rectangulo" });
            cmbTipoArea.Location = new Point(67, 54);
            cmbTipoArea.Name = "cmbTipoArea";
            cmbTipoArea.Size = new Size(121, 23);
            cmbTipoArea.TabIndex = 1;
            cmbTipoArea.SelectedIndexChanged += cmbTipoArea_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblP1);
            groupBox1.Controls.Add(lblP2);
            groupBox1.Controls.Add(txtP2);
            groupBox1.Controls.Add(txtP1);
            groupBox1.Controls.Add(cmbTipoArea);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Location = new Point(134, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(259, 240);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calcular Areas";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 36);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 6;
            label3.Text = "Que quieres calcular?";
            // 
            // lblP1
            // 
            lblP1.AutoSize = true;
            lblP1.Location = new Point(67, 80);
            lblP1.Name = "lblP1";
            lblP1.Size = new Size(38, 15);
            lblP1.TabIndex = 5;
            lblP1.Text = "label2";
            // 
            // lblP2
            // 
            lblP2.AutoSize = true;
            lblP2.Location = new Point(67, 130);
            lblP2.Name = "lblP2";
            lblP2.Size = new Size(38, 15);
            lblP2.TabIndex = 4;
            lblP2.Text = "label1";
            // 
            // txtP2
            // 
            txtP2.Location = new Point(67, 148);
            txtP2.Name = "txtP2";
            txtP2.Size = new Size(100, 23);
            txtP2.TabIndex = 3;
            // 
            // txtP1
            // 
            txtP1.Location = new Point(67, 98);
            txtP1.Name = "txtP1";
            txtP1.Size = new Size(100, 23);
            txtP1.TabIndex = 2;
            txtP1.TextChanged += txtP1_TextChanged;
            // 
            // CalcularArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "CalcularArea";
            Text = "CalcularArea";
            Load += CalcularArea_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCalcular;
        private ComboBox cmbTipoArea;
        private GroupBox groupBox1;
        private Label lblP1;
        private Label lblP2;
        private TextBox txtP2;
        private TextBox txtP1;
        private Label label3;
    }
}