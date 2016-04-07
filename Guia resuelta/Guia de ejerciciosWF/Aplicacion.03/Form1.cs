using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {

            string cadena1 = txtIngreso.Text;
            string cadena2 = txtIngreso.Text;
            string aux = "";
            for (int i = cadena1.Length - 1; i > -1; i--)
            {
                aux += cadena1[i];
            }
            txtInvertida.Text = aux;

            List<char> auxcad = new List<char>();
            foreach (char item in cadena1)
                auxcad.Add(item);
            auxcad.Sort();
            foreach (char item in auxcad)
                txtAlfabetico.Text += item;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control caja in this.Controls)
            {
                if (caja is TextBox)
                {
                    ((TextBox)caja).Clear();
                }

            }
        }
    }
}
