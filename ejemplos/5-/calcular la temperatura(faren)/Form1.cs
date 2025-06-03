using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcular_la_temperatura_faren_
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            lblRespuesta.Text = "";
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double Faren, Celsius;
            if (double.TryParse(txtFaren.Text, out Faren))
            {
                Celsius = (Faren - 32) * (5 / 9);
                lblRespuesta.Text = "Grados Celsius:" + Faren.ToString("N2");
            }
            else
            {
                lblRespuesta.Text = "Ingresa un numero porfavor";
            }

        }
    }
}
