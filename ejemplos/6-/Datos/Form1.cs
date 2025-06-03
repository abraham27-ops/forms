using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResultado.Text = "";
        }

        private void lbldos_Click(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double suma, num1, num2;
            if (double.TryParse(txtuno.Text, out num1))
            {
                if (double.TryParse(txtdos.Text, out num2))
                {
                    suma = num1 + num2;
                    lblResultado.Text = "El total es:" + suma.ToString();
                }
            }
            else
            {
                lblResultado.Text = "Error dato mal ingresado";
            }

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            double resta, num1, num2;
            if (double.TryParse(txtuno.Text, out num1))
            {
                if (double.TryParse(txtdos.Text, out num2))
                {
                    resta = num1 - num2;
                    lblResultado.Text = "El total es" + resta.ToString();
                }
            }
            else
            {
                lblResultado.Text = "Error dato mal ingresado";
            }


        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            double multi, num1, num2;
            if (double.TryParse(txtuno.Text, out num1))
            {
                if (double.TryParse(txtdos.Text, out num2))
                {
                    multi = num1 * num2;
                    lblResultado.Text = "El total es" + multi;
                }
            }
            else
            {
                lblResultado.Text = "Error dato mal ingresado";
            }



        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double division, num1, num2;
            if (double.TryParse(txtuno.Text, out num1 )&& (double.TryParse(txtdos.Text, out num2)))
            {
                if (num2!=0)
                {
                    division = num1 / num2;
                    lblResultado.Text = "El total es" + division;
                }
                else
                {

                    lblResultado.Text = "error";

                }
            }
            else
            {
                lblResultado.Text = "Error dato mal ingresado";
            }

        }
    }
}
