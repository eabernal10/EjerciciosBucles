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
    public partial class frmbinaro_a_decimal : Form
    {
        public frmbinaro_a_decimal()
        {
            InitializeComponent();
        }

        private void btncarrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int suma = 0;
            if (chk1.Checked == true)
                suma += 1;
            if (chk2.Checked == true)
                suma += 2;
            if (chk3.Checked == true)
                suma += 4;
            if (chk4.Checked == true)
                suma += 8;
            if (chk5.Checked == true)
                suma += 16;
            if (chk6.Checked == true)
                suma += 32;
            if (chk7.Checked == true)
                suma += 64;
            if (chk8.Checked == true)
                suma += 128;
           
            this.txtnum.Text = suma.ToString();
        }

        
    }
}
