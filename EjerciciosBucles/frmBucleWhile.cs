using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosBucles
{
    public partial class frmBucleWhile : Form
    {
        public frmBucleWhile()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //recuperar el valor ingresado por el usuario en TXTNUMERO
            int numero = Int32.Parse(this.TXTNUMERO.Text);
            int fact = 1;
            int i = 1;

            while(i<= numero )
            {
                //fact = fact * i;
                fact *= i;
                i++;
            }
            //muestro el resultado
            this.TXTRESULTADO.Text = fact.ToString();
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
