namespace CreacionLineas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            cmbcolor = new ComboBox();
            textespaciado = new TextBox();
            textcantidad = new TextBox();
            areaDibujo = new Panel();
            label4 = new Label();
            label5 = new Label();
            textInicio = new TextBox();
            textFin = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 58);
            label1.Name = "label1";
            label1.Size = new Size(86, 18);
            label1.TabIndex = 0;
            label1.Text = "Cantidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 109);
            label2.Name = "label2";
            label2.Size = new Size(96, 18);
            label2.TabIndex = 1;
            label2.Text = "Espaciado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 157);
            label3.Name = "label3";
            label3.Size = new Size(54, 18);
            label3.TabIndex = 2;
            label3.Text = "Color";
            // 
            // button1
            // 
            button1.Location = new Point(39, 329);
            button1.Name = "button1";
            button1.Size = new Size(139, 55);
            button1.TabIndex = 3;
            button1.Text = "DIBUJAR LINEAS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += botonDibujar;
            // 
            // cmbcolor
            // 
            cmbcolor.FormattingEnabled = true;
            cmbcolor.Items.AddRange(new object[] { "amarillo", "rojo", "azul ", "negro" });
            cmbcolor.Location = new Point(166, 152);
            cmbcolor.Name = "cmbcolor";
            cmbcolor.Size = new Size(196, 23);
            cmbcolor.TabIndex = 4;
            // 
            // textespaciado
            // 
            textespaciado.Location = new Point(166, 109);
            textespaciado.Name = "textespaciado";
            textespaciado.Size = new Size(196, 23);
            textespaciado.TabIndex = 5;
            // 
            // textcantidad
            // 
            textcantidad.Location = new Point(166, 58);
            textcantidad.Name = "textcantidad";
            textcantidad.Size = new Size(196, 23);
            textcantidad.TabIndex = 6;
            // 
            // areaDibujo
            // 
            areaDibujo.BackColor = SystemColors.Info;
            areaDibujo.Location = new Point(378, 52);
            areaDibujo.Name = "areaDibujo";
            areaDibujo.Size = new Size(480, 385);
            areaDibujo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 201);
            label4.Name = "label4";
            label4.Size = new Size(123, 18);
            label4.TabIndex = 8;
            label4.Text = "Inicio Trazo: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 252);
            label5.Name = "label5";
            label5.Size = new Size(96, 18);
            label5.TabIndex = 9;
            label5.Text = "Fin Trazo:";
            // 
            // textInicio
            // 
            textInicio.Location = new Point(166, 196);
            textInicio.Name = "textInicio";
            textInicio.Size = new Size(193, 23);
            textInicio.TabIndex = 10;
            // 
            // textFin
            // 
            textFin.Location = new Point(166, 247);
            textFin.Name = "textFin";
            textFin.Size = new Size(193, 23);
            textFin.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(883, 483);
            Controls.Add(textFin);
            Controls.Add(textInicio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(areaDibujo);
            Controls.Add(textcantidad);
            Controls.Add(textespaciado);
            Controls.Add(cmbcolor);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private ComboBox cmbcolor;
        private TextBox textespaciado;
        private TextBox textcantidad;
        private Panel areaDibujo;
        private Label label4;
        private Label label5;
        private TextBox textInicio;
        private TextBox textFin;
    }
}
