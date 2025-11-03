namespace WinFormsApp1.ProblemaEdad
{
    partial class EdadForm
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
            label1 = new Label();
            txtanoNacimiento = new TextBox();
            btlCalcular = new Button();
            txtMesNacimiento = new TextBox();
            label2 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 123);
            label1.Name = "label1";
            label1.Size = new Size(163, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingresa Tu año de nacimiento";
            // 
            // txtanoNacimiento
            // 
            txtanoNacimiento.Location = new Point(260, 115);
            txtanoNacimiento.Name = "txtanoNacimiento";
            txtanoNacimiento.Size = new Size(100, 23);
            txtanoNacimiento.TabIndex = 1;
            // 
            // btlCalcular
            // 
            btlCalcular.Location = new Point(366, 153);
            btlCalcular.Name = "btlCalcular";
            btlCalcular.Size = new Size(75, 23);
            btlCalcular.TabIndex = 2;
            btlCalcular.Text = "Calcular";
            btlCalcular.UseVisualStyleBackColor = true;
            btlCalcular.Click += btlCalcular_Click;
            // 
            // txtMesNacimiento
            // 
            txtMesNacimiento.Location = new Point(260, 149);
            txtMesNacimiento.Name = "txtMesNacimiento";
            txtMesNacimiento.Size = new Size(100, 23);
            txtMesNacimiento.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 157);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 3;
            label2.Text = "Ingresa Tu mes de nacimiento";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(358, 240);
            button1.Name = "button1";
            button1.Size = new Size(353, 143);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(537, 146);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // EdadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(txtMesNacimiento);
            Controls.Add(label2);
            Controls.Add(btlCalcular);
            Controls.Add(txtanoNacimiento);
            Controls.Add(label1);
            Name = "EdadForm";
            Text = "EdadForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtanoNacimiento;
        private Button btlCalcular;
        private TextBox txtMesNacimiento;
        private Label label2;
        private Button button1;
        private ComboBox comboBox1;
    }
}