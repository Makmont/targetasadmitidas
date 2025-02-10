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

            comboBoxEstadoCivil.Items.Add("Soltero(a)");
            comboBoxEstadoCivil.Items.Add("Casado(a)");
            comboBoxEstadoCivil.Items.Add("Viudo(a)");
            comboBoxEstadoCivil.Items.Add("Divorciado(a)");
            comboBoxEstadoCivil.Items.Add("Unión libre");

            comboBox3Casa.Items.Add("SI");
            comboBox3Casa.Items.Add("NO");

            comboBoxVehiculos.Items.Add("SI");
            comboBoxVehiculos.Items.Add("NO");

            comboBoxAntiguedad.Items.Add("3 años");
            comboBoxAntiguedad.Items.Add("8 años");
            comboBoxAntiguedad.Items.Add("5 años");
            comboBoxAntiguedad.Items.Add("10 años");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = TextBoxNombre.Text;
            string aspirante = "";
            string direccion = textBoxDireccion.Text;
            string delegacion = textBoxDelegacion.Text;
            int edad = int.Parse(textBoxEdad.Text);
            string sexo = "";
            string puesto = textBoxPuesto.Text;
            string empresa = textBoxEmpresa.Text;
            string tipoEmpresa = "";
            string estudios = comboBoxEstudios.SelectedItem.ToString();
            string estadoCivil = comboBoxEstadoCivil.SelectedItem.ToString();
            decimal hijos = numericUpDown1Hijos.Value;
            string casaPropia = comboBox3Casa.SelectedItem.ToString();
            int valorCasa = int.Parse(textBoxCasa.Text);
            string vehiculos = comboBoxVehiculos.SelectedItem.ToString();
            decimal numVehiculos = numericUpDownVehiculos.Value;
            string antiguedadLaboral = comboBoxAntiguedad.SelectedItem.ToString();
            int salarioMensual = int.Parse(textBoxSalarioMensual.Text);
            int deudas = int.Parse(textBoxDeudas.Text);
            string infonavit = "";
            decimal referencias = numericUpDown3Referencias.Value;
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



            if (radioButton6.Checked)
            {
                infonavit = radioButton6.Text;
            }
            else if (radioButton5.Checked)
            {
                infonavit = radioButton5.Text;
            }



            if ((tipoEmpresa == "privada" || tipoEmpresa == "publica") && aspirante == "CDMX" && sexo != "" && edad >= 25 && edad <= 50 && salarioMensual >= 12000 && estudios == "carrera trunca" && hijos == 1 && casaPropia == "SI" && deudas <= 5000 && antiguedadLaboral == "3 años")
            {
                tipoDeTargeta = "Oro para CDMX";
            }
            else if ((tipoEmpresa == "privada" || tipoEmpresa == "publica") && aspirante == "CDMX" && sexo != "" && edad >= 30 && edad <= 50 && salarioMensual >= 20000 && estudios == "Profesional" && hijos <= 2 && casaPropia == "SI" && deudas <= 10000 && antiguedadLaboral == "3 años")
            {
                tipoDeTargeta = "Platinum para CDMX";
            }
            else if ((tipoEmpresa == "privada" || tipoEmpresa == "publica") && aspirante == "CDMX" && sexo != "" && edad >= 30 && edad <= 50 && salarioMensual >= 30000 && estudios == "Profesional" && hijos <= 4 && casaPropia == "SI" && valorCasa >= 2000000 && deudas <= 20000 && antiguedadLaboral == "8 años" && numVehiculos == 4)
            {
                tipoDeTargeta = "American Express para CDMX";
            }
            else if (tipoEmpresa == "publica" && aspirante == "Foraneo" && sexo != "" && edad >= 25 && edad <= 50 && salarioMensual >= 12000 && estudios == "carrera trunca" && hijos == 1 && casaPropia == "SI" && deudas <= 5000 && antiguedadLaboral == "3 años")
            {
                tipoDeTargeta = "Oro para Foráneos";
            }
            else if (tipoEmpresa == "publica" && aspirante == "Foraneo" && sexo != "" && edad >= 30 && edad <= 50 && salarioMensual >= 20000 && estudios == "Profesional" && hijos <= 2 && casaPropia == "SI" && deudas <= 10000 && antiguedadLaboral == "3 años" && (vehiculos == "1" || vehiculos == "2"))
            {
                tipoDeTargeta = "Platinum para Foráneos";
            }
            else if ((tipoEmpresa == "privada" || tipoEmpresa == "publica") && aspirante == "Foraneo" && sexo != "" && edad >= 30 && edad <= 50 && salarioMensual >= 30000 && estudios == "Profesional" && hijos <= 4 && casaPropia == "SI" && valorCasa >= 2000000 && deudas <= 20000 && antiguedadLaboral == "8 años" && numVehiculos == 4)
            {
                tipoDeTargeta = "American Express para Foráneos";
            }
            else
            {
                tipoDeTargeta = "No apto para ninguna tarjeta";
            }

            MessageBox.Show("Tipo de tarjeta asignada: " + tipoDeTargeta, "Asignación de tarjeta", MessageBoxButtons.OK, MessageBoxIcon.Information);



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
            textBoxDireccion.Text = string.Empty;
            textBoxDelegacion.Text = string.Empty;
            textBoxEdad.Text = string.Empty;
            textBoxPuesto.Text = string.Empty;
            textBoxEmpresa.Text = string.Empty;
            textBoxCasa.Text = string.Empty;
            textBoxSalarioMensual.Text = string.Empty;
            textBoxDeudas.Text = string.Empty;

        }
    }
}
