using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos_Persnales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtCiudad.Clear();
            label1.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre, edad, ciudad;
            nombre = txtNombre.Text;
            edad = txtEdad.Text;
            ciudad = txtCiudad.Text;
            label1.Text= "Bienvendio" + nombre + " Su edad: " +edad+ " Su ciudad: "+ciudad;
        }
    }
}
