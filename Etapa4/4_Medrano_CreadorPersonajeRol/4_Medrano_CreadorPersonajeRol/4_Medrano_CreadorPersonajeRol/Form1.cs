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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            Form2 pantalla2 = new Form2(Nombre.Text, Vida.Text, habilidades.Text, Raza.Text);
            pantalla2.Show();
            this.Hide();
        }

        private void butoncer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
