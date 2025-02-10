namespace targetasadmitidas
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
            TextBoxNombre = new TextBox();
            panel1 = new Panel();
            groupBox4 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox3 = new GroupBox();
            opcion2 = new RadioButton();
            opcion1 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            buttonLimpiar = new Button();
            buttonSolicitar = new Button();
            panel2 = new Panel();
            label22 = new Label();
            label19 = new Label();
            textBoxDeudas = new TextBox();
            label18 = new Label();
            textBoxSalarioMensual = new TextBox();
            label16 = new Label();
            comboBoxAntiguedad = new ComboBox();
            label15 = new Label();
            numericUpDownVehiculos = new NumericUpDown();
            comboBoxVehiculos = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            comboBox3Casa = new ComboBox();
            label11 = new Label();
            numericUpDown1Hijos = new NumericUpDown();
            label9 = new Label();
            comboBoxEstudios = new ComboBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            textBoxEdad = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVehiculos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1Hijos).BeginInit();
            SuspendLayout();
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Location = new Point(169, 37);
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(462, 27);
            TextBoxNombre.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(buttonLimpiar);
            panel1.Controls.Add(buttonSolicitar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label22);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(textBoxDeudas);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(textBoxSalarioMensual);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(comboBoxAntiguedad);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(numericUpDownVehiculos);
            panel1.Controls.Add(comboBoxVehiculos);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(comboBox3Casa);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(numericUpDown1Hijos);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(comboBoxEstudios);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxEdad);
            panel1.Controls.Add(TextBoxNombre);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(47, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(1263, 649);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButton2);
            groupBox4.Controls.Add(radioButton1);
            groupBox4.Location = new Point(167, 204);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(184, 42);
            groupBox4.TabIndex = 54;
            groupBox4.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(109, 13);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(68, 24);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mujer";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(9, 13);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 24);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Hombre";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(opcion2);
            groupBox3.Controls.Add(opcion1);
            groupBox3.Location = new Point(169, 61);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(197, 46);
            groupBox3.TabIndex = 53;
            groupBox3.TabStop = false;
            // 
            // opcion2
            // 
            opcion2.AutoSize = true;
            opcion2.Location = new Point(107, 17);
            opcion2.Name = "opcion2";
            opcion2.Size = new Size(84, 24);
            opcion2.TabIndex = 47;
            opcion2.TabStop = true;
            opcion2.Text = "Foraneo";
            opcion2.UseVisualStyleBackColor = true;
            opcion2.CheckedChanged += opcion2_CheckedChanged;
            // 
            // opcion1
            // 
            opcion1.AutoSize = true;
            opcion1.Location = new Point(7, 17);
            opcion1.Name = "opcion1";
            opcion1.Size = new Size(72, 24);
            opcion1.TabIndex = 46;
            opcion1.TabStop = true;
            opcion1.Text = "CDMX";
            opcion1.UseVisualStyleBackColor = true;
            opcion1.CheckedChanged += radioButton8_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(171, 314);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(214, 45);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(118, 17);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(79, 24);
            radioButton3.TabIndex = 16;
            radioButton3.TabStop = true;
            radioButton3.Text = "Privada";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(18, 17);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(78, 24);
            radioButton4.TabIndex = 15;
            radioButton4.TabStop = true;
            radioButton4.Text = "Publica";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.Black;
            buttonLimpiar.Location = new Point(909, 255);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(94, 29);
            buttonLimpiar.TabIndex = 50;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonSolicitar
            // 
            buttonSolicitar.BackColor = Color.Black;
            buttonSolicitar.Location = new Point(852, 212);
            buttonSolicitar.Name = "buttonSolicitar";
            buttonSolicitar.Size = new Size(206, 29);
            buttonSolicitar.TabIndex = 49;
            buttonSolicitar.Text = "Solicitar Tarjeta";
            buttonSolicitar.UseVisualStyleBackColor = false;
            buttonSolicitar.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(653, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 648);
            panel2.TabIndex = 39;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(29, 80);
            label22.Name = "label22";
            label22.Size = new Size(127, 20);
            label22.TabIndex = 48;
            label22.Text = "Tipo de Aspirante";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(683, 70);
            label19.Name = "label19";
            label19.Size = new Size(236, 20);
            label19.TabIndex = 40;
            label19.Text = "deducciones mensuales (adeudos)";
            // 
            // textBoxDeudas
            // 
            textBoxDeudas.Location = new Point(925, 67);
            textBoxDeudas.Name = "textBoxDeudas";
            textBoxDeudas.Size = new Size(125, 27);
            textBoxDeudas.TabIndex = 39;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(705, 37);
            label18.Name = "label18";
            label18.Size = new Size(214, 20);
            label18.TabIndex = 38;
            label18.Text = "salario mensual (percepciones)";
            // 
            // textBoxSalarioMensual
            // 
            textBoxSalarioMensual.Location = new Point(925, 34);
            textBoxSalarioMensual.Name = "textBoxSalarioMensual";
            textBoxSalarioMensual.Size = new Size(125, 27);
            textBoxSalarioMensual.TabIndex = 37;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(25, 551);
            label16.Name = "label16";
            label16.Size = new Size(138, 20);
            label16.TabIndex = 34;
            label16.Text = "Antiguedad laboral";
            // 
            // comboBoxAntiguedad
            // 
            comboBoxAntiguedad.FormattingEnabled = true;
            comboBoxAntiguedad.Location = new Point(169, 548);
            comboBoxAntiguedad.Name = "comboBoxAntiguedad";
            comboBoxAntiguedad.Size = new Size(78, 28);
            comboBoxAntiguedad.TabIndex = 33;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(315, 514);
            label15.Name = "label15";
            label15.Size = new Size(106, 20);
            label15.TabIndex = 32;
            label15.Text = "Num.Vehiculos";
            // 
            // numericUpDownVehiculos
            // 
            numericUpDownVehiculos.Location = new Point(427, 510);
            numericUpDownVehiculos.Name = "numericUpDownVehiculos";
            numericUpDownVehiculos.Size = new Size(64, 27);
            numericUpDownVehiculos.TabIndex = 31;
            // 
            // comboBoxVehiculos
            // 
            comboBoxVehiculos.FormattingEnabled = true;
            comboBoxVehiculos.Location = new Point(169, 514);
            comboBoxVehiculos.Name = "comboBoxVehiculos";
            comboBoxVehiculos.Size = new Size(78, 28);
            comboBoxVehiculos.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(85, 517);
            label13.Name = "label13";
            label13.Size = new Size(71, 20);
            label13.TabIndex = 29;
            label13.Text = "Vehiculos";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(75, 481);
            label12.Name = "label12";
            label12.Size = new Size(88, 20);
            label12.TabIndex = 25;
            label12.Text = "Casa propia";
            // 
            // comboBox3Casa
            // 
            comboBox3Casa.FormattingEnabled = true;
            comboBox3Casa.Location = new Point(169, 478);
            comboBox3Casa.Name = "comboBox3Casa";
            comboBox3Casa.Size = new Size(78, 28);
            comboBox3Casa.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(85, 438);
            label11.Name = "label11";
            label11.Size = new Size(78, 20);
            label11.TabIndex = 23;
            label11.Text = "Num.Hijos";
            // 
            // numericUpDown1Hijos
            // 
            numericUpDown1Hijos.Location = new Point(169, 436);
            numericUpDown1Hijos.Name = "numericUpDown1Hijos";
            numericUpDown1Hijos.Size = new Size(64, 27);
            numericUpDown1Hijos.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(40, 371);
            label9.Name = "label9";
            label9.Size = new Size(123, 20);
            label9.TabIndex = 19;
            label9.Text = "Nivel de estudios";
            // 
            // comboBoxEstudios
            // 
            comboBoxEstudios.FormattingEnabled = true;
            comboBoxEstudios.Location = new Point(169, 368);
            comboBoxEstudios.Name = "comboBoxEstudios";
            comboBoxEstudios.Size = new Size(151, 28);
            comboBoxEstudios.TabIndex = 18;
            comboBoxEstudios.SelectedIndexChanged += comboBoxEstudios_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 329);
            label8.Name = "label8";
            label8.Size = new Size(107, 20);
            label8.TabIndex = 17;
            label8.Text = "La empresa es ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 212);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 12;
            label5.Text = "Sexo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 182);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 11;
            label4.Text = "Edad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 40);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 7;
            label1.Text = "Nombre Completo";
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(169, 179);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(125, 27);
            textBoxEdad.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(909, 301);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 55;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 729);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVehiculos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1Hijos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TextBoxNombre;
        private Panel panel1;
        private Label label1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBoxEdad;
        private Label label5;
        private Label label4;
        private Label label8;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label11;
        private NumericUpDown numericUpDown1Hijos;
        private Label label9;
        private ComboBox comboBoxEstudios;
        private Label label12;
        private ComboBox comboBox3Casa;
        private Label label18;
        private TextBox textBoxSalarioMensual;
        private Label label16;
        private ComboBox comboBoxAntiguedad;
        private Label label15;
        private NumericUpDown numericUpDownVehiculos;
        private ComboBox comboBoxVehiculos;
        private Label label13;
        private Label label19;
        private TextBox textBoxDeudas;
        private Panel panel2;
        private Label label22;
        private RadioButton opcion2;
        private RadioButton opcion1;
        private Button buttonLimpiar;
        private Button buttonSolicitar;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button button1;
    }
}
