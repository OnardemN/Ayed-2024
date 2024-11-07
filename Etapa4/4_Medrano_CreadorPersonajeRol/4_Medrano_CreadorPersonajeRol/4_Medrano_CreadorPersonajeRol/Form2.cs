using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Medrano_CreadorPersonajeRol
{
    public partial class Form2 : Form
    {
        public Form2(string Nombre, string vida, string habilidad, string raza)
        {
            InitializeComponent();
            nombre2.Text = Nombre;
            vida2.Text = vida;
            habilidades2.Text = habilidad;
            raza2.Text = raza;

           
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            Form1 pantalla1 = new Form1();
            pantalla1.Show();
            this.Hide();
        }

        private void BOTCER2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
