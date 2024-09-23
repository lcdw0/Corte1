using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Corte1
{
    public partial class Form1 : Form
    {
        private Registro registro;
        private Operacion operacion;
        public Form1()
        {
            InitializeComponent();
            registro = new Registro();
            operacion = new Operacion();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nombres = txtName.Text;             // Nombres
            string apellidos = txtLastname.Text;       // Apellidos
            DateTime fechaNacimiento = dtpBirthday.Value;  // Fecha de nacimiento
            string ciudad = cmbCity.SelectedItem.ToString(); // Ciudad

            
            Persona nuevaPersona = new Persona(nombres, apellidos, fechaNacimiento, ciudad);
            registro.AgregarPersona(nuevaPersona);

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (registro.ObtenerPersonas().Count > 0)
            {
                Persona ultimaPersona = registro.ObtenerPersonas().Last();

                // Calcula la edad y verifica si es mayor de edad
                int edad = operacion.CalcularEdad(ultimaPersona);
                bool esMayorDeEdad = operacion.EsMayorDeEdad(ultimaPersona);

                // Muestra un mensaje con la edad y si es mayor o menor de edad
                MessageBox.Show($"Edad: {edad}\nMayor de edad: {esMayorDeEdad}");
            }
            else
            {
                MessageBox.Show("No hay personas registradas.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
