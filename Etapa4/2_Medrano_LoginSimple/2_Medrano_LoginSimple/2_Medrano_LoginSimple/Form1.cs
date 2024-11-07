using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Medrano_LoginSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_Click(object sender, EventArgs e)
        {
            if (nombre.Text == "Admin" && contraseña.Text == "Admin12345")
            {
                MessageBox.Show("ingreso correctamente");
            }
            else if (nombre.Text == "Admin" && contraseña.Text != "Admin12345") 
            {
                MessageBox.Show("contraseña incorrectamente");
            }
            else if (nombre.Text != "Andim" && contraseña.Text == "Admin12345")
            {
                MessageBox.Show("usuario incorrectamente");
            }
            else
            {
                MessageBox.Show("usuario y contraseña incorrectamente");
            }

            
        }
    }
}
