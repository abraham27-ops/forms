using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mi_primer_formulario
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            lblRespuesta.Text = "";
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            int.TryParse(lblRespuesta.Text, out cantidad);
            cantidad++;
            lblRespuesta.Text = cantidad.ToString();
        }
    }
}
