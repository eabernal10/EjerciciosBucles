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
    public partial class frmTablas : Form
    {
        public frmTablas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //recuperar valores ingresados por el usuario
            int tabla= Convert.ToInt32(this.textBox1.Text);
            int j = 1;
            string aux = "";
            //generar la tabla
            // limpiar lisbox
            while(j <= 12)
            {
                //Console.WriteLine($"{tabla} x {j} = {tabla * j}");
                string cad = $"{tabla} x {j} = {tabla * j}";
                aux = aux + $"{tabla} x {j} = {tabla * j}" + Environment.NewLine;
               this.lstTabla.Items.Add(cad);
                j++;
            }
            //mostrar el resultado
            this.textBox2.Text = aux;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTabla.Items.Add(textBox2.Text);
            //Aqui es donde pasamos el parámetro
            textBox2.Text = "";
            textBox2.Focus();
        }
    }
}
