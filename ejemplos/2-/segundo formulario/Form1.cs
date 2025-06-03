using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segundo_formulario
{
    public partial class ContarCaracteres: Form
    {
        public ContarCaracteres()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblTexto_Click(object sender, EventArgs e)
        {

        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int Contar;
            Contar = txtCadenaDeTexto.Text.Length;
            lblRespuesta.Text = Contar.ToString();

        }
    }
}
