using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0_Medrano_ConversorTemperaturasGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CELCIUS_TextChanged(object sender, EventArgs e)
        {

        }

        private void BOTON_Click(object sender, EventArgs e)
        {
            KELVIN.Text = (int.Parse(CELCIUS.Text) + 273 +" K").ToString();
            FARENHEIT.Text = (int.Parse(CELCIUS.Text) * (18 / 10) + 32 +" F").ToString();
        }
    }
}
