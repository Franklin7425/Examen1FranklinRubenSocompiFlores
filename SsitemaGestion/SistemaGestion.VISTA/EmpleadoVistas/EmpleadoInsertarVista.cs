using SistemaGestion.BSS;
using SistemaGestion.Modelos;
using SistemaGestion.VISTA.PersonaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion.VISTA.EmpleadoVistas
{
    public partial class EmpleadoInsertarVista : Form
    {
        public EmpleadoInsertarVista()
        {
            InitializeComponent();
        }

        public static int IdPersonaSeleccionada = 0;

        EmpleadoBSS bss = new EmpleadoBSS();
        private void button1_Click(object sender, EventArgs e)
        {
            Empleado em = new Empleado();
            em.IdPersona = IdPersonaSeleccionada;
            em.Puesto = textBox2.Text;
            em.Salario = Convert.ToDecimal( textBox3.Text);
            em.FechaContratacion = Convert.ToDateTime(textBox4.Text);

            bss.InsertarEmpleadosBss(em);
            MessageBox.Show("Se guardo correctamente al empleado");
        }
        PersonaBSS bssempleado = new PersonaBSS();

        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bssempleado.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }
}
