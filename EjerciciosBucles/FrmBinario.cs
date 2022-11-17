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
    public partial class FrmBinario : Form
    {
        public FrmBinario()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int num= Int32.Parse(this.txtnum.Text);
            //utilizo el bucle para realizar las diviciones sucesivas para 2
            int[] vector = { 0, 0, 0, 0, 0, 0, 0, 0 };
            int i = 0;
            while(num>0)
            {
                int resto = num % 2;
                vector[i] = resto;

                num /= 2;
                i++;

            }
            //encender y apagar los checkbox
            //for(i=0;i<8;i++)
            {
                this.chk1.Checked = (vector[0] == 1) ? true : false;
                this.chk2.Checked = (vector[1] == 1) ? true : false;
                this.chk3.Checked = (vector[2] == 1) ? true : false;
                this.chk4.Checked = (vector[3] == 1) ? true : false;
                this.chk5.Checked = (vector[4] == 1) ? true : false;
                this.chk6.Checked = (vector[5] == 1) ? true : false;
                this.chk7.Checked = (vector[6] == 1) ? true : false;
                this.chk8.Checked = (vector[7] == 1) ? true : false;
            }
        }

        private void btncarrar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
