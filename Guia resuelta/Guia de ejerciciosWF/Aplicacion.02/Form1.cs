using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion._02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ingreso = Int32.Parse(txtIngreso.Text);

            if (ingreso >= 30 && ingreso <= 50)
            {
                txtDescuento.Text = (ingreso * 0.10f).ToString();
                txtTotal.Text = (ingreso - (ingreso * 0.10f)).ToString();
            }
            if(ingreso > 50)
            {
                txtDescuento.Text = (ingreso * 0.20f).ToString();
                txtTotal.Text = (ingreso - (ingreso * 0.20f)).ToString();
            }
            else
            {
                txtDescuento.Text = "0";
                txtTotal.Text = ingreso.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtIngreso.Clear();
            txtDescuento.Clear();
            txtTotal.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea salir de la aplicacion?","Atención",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
