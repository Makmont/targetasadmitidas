using System.Diagnostics.Contracts;

namespace targetasadmitidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxEstudios.Items.Add("carrera trunca");
            comboBoxEstudios.Items.Add("Profesional");

            comboBox3Casa.Items.Add("SI");
            comboBox3Casa.Items.Add("NO");

            comboBoxVehiculos.Items.Add("SI");
            comboBoxVehiculos.Items.Add("NO");

            comboBoxAntiguedad.Items.Add("3 a�os");
            comboBoxAntiguedad.Items.Add("8 a�os");
            comboBoxAntiguedad.Items.Add("5 a�os");
            comboBoxAntiguedad.Items.Add("10 a�os");

        }
        int totalEvaluados = 0;
        int totalDeclinados = 0;
        int totalCDMX = 0;
        int totalForaneos = 0;
        int cdmxOro = 0;
        int cdmxPlatinum = 0;
        int cdmxAmericanExpress = 0;
        int foraneosOro = 0;
        int foraneosPlatinum = 0;
        int foraneosAmericanExpress = 0;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

    

            totalEvaluados++;

            string nombre = TextBoxNombre.Text;
            string aspirante = "";
            int edad = int.Parse(textBoxEdad.Text);
            string sexo = "";
            string tipoEmpresa = "";
            string estudios = comboBoxEstudios.SelectedItem.ToString();
            decimal hijos = numericUpDown1Hijos.Value;
            string casaPropia = comboBox3Casa.SelectedItem.ToString();
            string vehiculos = comboBoxVehiculos.SelectedItem.ToString();
            decimal numVehiculos = numericUpDownVehiculos.Value;
            string antiguedadLaboral = comboBoxAntiguedad.SelectedItem.ToString();
            int salarioMensual = int.Parse(textBoxSalarioMensual.Text);
            int deudas = int.Parse(textBoxDeudas.Text);
            string tipoDeTargeta = "";






            if (opcion1.Checked)
            {
                aspirante = "CDMX";
            }
            else if (opcion2.Checked)
            {
                aspirante = "Foraneo";
            }



            if (radioButton1.Checked)
            {
                sexo = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                sexo = radioButton2.Text;
            }



            if (radioButton4.Checked)
            {
                tipoEmpresa = publica;
            }
            else if (radioButton3.Checked)
            {
                tipoEmpresa = privada;
            }



            if ((tipoEmpresa == "privada" || tipoEmpresa == "publica") && aspirante == "CDMX" && sexo != "" && edad >= 25 && edad <= 50 && salarioMensual >= 12000 && estudios == "carrera trunca" && hijos == 1 && casaPropia == "SI" && deudas <= 5000 && antiguedadLaboral == "3 a�os")
            {
                tipoDeTargeta = "Oro para CDMX";
                cdmxOro++;
                totalCDMX++;
            }
            else if ((tipoEmpresa == "privada" || tipoEmpresa == "publica") && aspirante == "CDMX" && sexo != "" && edad >= 30 && edad <= 50 && salarioMensual >= 20000 && estudios == "Profesional" && hijos <= 2 && casaPropia == "SI" && deudas <= 10000 && antiguedadLaboral == "3 a�os")
            {
                tipoDeTargeta = "Platinum para CDMX";
                cdmxPlatinum++;
                totalCDMX++;
            }
            else if ((tipoEmpresa == "privada" || tipoEmpresa == "publica") && aspirante == "CDMX" && sexo != "" && edad >= 30 && edad <= 50 && salarioMensual >= 30000 && estudios == "Profesional" && hijos <= 4 && casaPropia == "SI" && deudas <= 20000 && antiguedadLaboral == "8 a�os" && numVehiculos == 4)
            {
                tipoDeTargeta = "American Express para CDMX";
                cdmxAmericanExpress++;
                totalCDMX++;
            }
            else if (tipoEmpresa == "publica" && aspirante == "Foraneo" && sexo != "" && edad >= 25 && edad <= 50 && salarioMensual >= 12000 && estudios == "carrera trunca" && hijos == 1 && casaPropia == "SI" && deudas <= 5000 && antiguedadLaboral == "3 a�os")
            {
                tipoDeTargeta = "Oro para For�neos";
                foraneosOro++;
                totalForaneos++;
            }
            else if (tipoEmpresa == "publica" && aspirante == "Foraneo" && sexo != "" && edad >= 30 && edad <= 50 && salarioMensual >= 20000 && estudios == "Profesional" && hijos <= 2 && casaPropia == "SI" && deudas <= 10000 && antiguedadLaboral == "3 a�os" && (vehiculos == "1" || vehiculos == "2"))
            {
                tipoDeTargeta = "Platinum para For�neos";
                foraneosPlatinum++;
                totalForaneos++;
            }
            else if ((tipoEmpresa == "privada" || tipoEmpresa == "publica") && aspirante == "Foraneo" && sexo != "" && edad >= 30 && edad <= 50 && salarioMensual >= 30000 && estudios == "Profesional" && hijos <= 4 && casaPropia == "SI" && deudas <= 20000 && antiguedadLaboral == "8 a�os" && numVehiculos == 4)
            {
                tipoDeTargeta = "American Express para For�neos";
                foraneosAmericanExpress++;
                totalForaneos++;
            }
            else
            {
                tipoDeTargeta = "No apto para ninguna tarjeta";
                totalDeclinados++;
            }

            MessageBox.Show("Tipo de tarjeta asignada: " + tipoDeTargeta, "Asignaci�n de tarjeta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    
        private string cdmx;
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            cdmx = "CDMX";
        }

        private void comboBoxEstudios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private string foraneo;
        private void opcion2_CheckedChanged(object sender, EventArgs e)
        {
            foraneo = "Foraneo";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private string publica;
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            publica = "publica";
        }
        private string privada;
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            privada = "privada";
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            TextBoxNombre.Text = string.Empty;
            textBoxEdad.Text = string.Empty;
            textBoxSalarioMensual.Text = string.Empty;
            textBoxDeudas.Text = string.Empty;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Total evaluados: " + totalEvaluados +
      "\nTotal declinados: " + totalDeclinados +
      "\nClientes CDMX: " + totalCDMX +
      "\n\tOro para CDMX: " + cdmxOro +
      "\n\tPlatinum para CDMX: " + cdmxPlatinum +
      "\n\tAmerican Express para CDMX: " + cdmxAmericanExpress +
      "\nClientes For�neos: " + totalForaneos +
      "\n\tOro para For�neos: " + foraneosOro +
      "\n\tPlatinum para For�neos: " + foraneosPlatinum +
      "\n\tAmerican Express para For�neos: " + foraneosAmericanExpress,
      "Informe de Evaluaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }

