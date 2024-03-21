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
    public partial class EmpleadoEditarVista : Form
    {
        int idx = 0;
        Empleado em = new Empleado();
        EmpleadoBSS bss = new EmpleadoBSS();
        public EmpleadoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void EmpleadoEditarVista_Load(object sender, EventArgs e)
        {
            em = bss.ObtenerIdBss(idx);
            textBox1.Text = em.IdPersona.ToString();
            textBox2.Text = em.Puesto;
            textBox3.Text = em.Salario.ToString();
            textBox4.Text = em.FechaContratacion.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            em.IdPersona = IdPersonaSeleccionada;
            em.Puesto = textBox2.Text;
            em.Salario = Convert.ToDecimal( textBox3.Text);
            em.FechaContratacion = Convert.ToDateTime(textBox4.Text);

            bss.EditarEmpleadoBss(em);
            MessageBox.Show("SE GUARDO CORRECTAMENTE");
        }

        public static int IdPersonaSeleccionada = 0;
        PersonaBSS bsspersona = new PersonaBSS();

        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bsspersona.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }
}
