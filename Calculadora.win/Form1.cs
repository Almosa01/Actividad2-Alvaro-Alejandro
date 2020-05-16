using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadEval2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtOper1.Text = "";
            //txtOper2.Text = "";
            //txtResultado.Text = "";

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {

            //Operacion op = new Operacion(txtOper1.Text, txtOper2.Text);
            //txtResultado.Text = op.Resta();



        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //Operacion op = new Operacion(txtOper1.Text, txtOper2.Text);
            //txtResultado.Text = op.Resta();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            //Operacion op = new Operacion(txtOper1.Text, txtOper2.Text);
            //txtResultado.Text = op.Multiplicacion();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            //Operacion op = new Operacion(txtOper1.Text, txtOper2.Text);
            //txtResultado.Text = op.Division();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Finaliza la aplicación
            this.Close();
            this.Dispose();
        }
    }
}
