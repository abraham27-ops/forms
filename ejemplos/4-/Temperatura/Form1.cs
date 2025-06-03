using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class GbDatosDeTemperatura: Form
    {
        public GbDatosDeTemperatura()
        {
            InitializeComponent();
            lblRespuesta.Text = "";
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double Celsius, Faren;
            if (double.TryParse(txtCelsius.Text, out Celsius))
            {
                Faren = 32 + ((Celsius * 9)/5);
                lblRespuesta.Text = "Grados Farenheit:" + Faren.ToString("N2"); 
            }
            else
            {
                lblRespuesta.Text = "Ingresa un numero por favor";
            }

        }

        private void lblRespuesta_Click(object sender, EventArgs e)
        {

        }
    }
}
