using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Medrano__MiPrimerMenuGUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        private void VOLVER_Click(object sender, EventArgs e)
        {
            Form1 pantalla1 = new Form1();
            pantalla1.Show();
            this.Hide();
        }

        private void CER2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void calcular_Click(object sender, EventArgs e)
        {
            resultado.Text = (int.Parse(NUM1.Text) + int.Parse(NUM2.Text)).ToString();
        }

       
    }
}
