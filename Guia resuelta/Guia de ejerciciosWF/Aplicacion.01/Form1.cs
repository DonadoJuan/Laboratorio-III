using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion._01
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
            int numero = Int32.Parse(txtNumero.Text);
            for(int i= 1; i<11; i++)
            {
                lstTable.Items.Add(numero + " * " + i + " = " + numero*i );
            }
        }

        private void lstTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            lstTable.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing( object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Desea cerrar la aplicacion?","Atención",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }

            e.Cancel = true;
        }

    }
}

