using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Medrano_CobrarBecaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BOTON_Click(object sender, EventArgs e)
        {
            if (int.Parse(EDAD.Text) >= 19 && SALARIO.Text == "100,001 - 200,000" || SALARIO.Text == "Más de 200,000")
            {
                MessageBox.Show("¡Felicidades!Puedes cobrar la beca");
            }
            else if (int.Parse(EDAD.Text) <= 18 && SALARIO.Text == "Entre 0 - 50,000" || SALARIO.Text == "50,001 - 100,000")
            {
                MessageBox.Show("No podes cobrar la beca");
            }
            else
            {
                MessageBox.Show("No podes cobrar la beca");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
