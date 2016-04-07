using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            listNum.Items.Add(txtIngreso.Text);
            txtIngreso.Clear();
            txtIngreso.Focus();

        }

        private void radbtnAscendente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiobtnDescente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radiobtnDescente.Checked)
            { 
            List<string> ListaDeNumeros = new List<string>();
            foreach (string numero in listNum.Items)
                ListaDeNumeros.Add(numero);

            listNum.Items.Clear();

            for (int i = 0; i < ListaDeNumeros.Count - 1; i++)
            {
                for (int j = 0; j < ListaDeNumeros.Count - 1; j++)
                {
                    if (Int32.Parse(ListaDeNumeros[j]) < Int32.Parse(ListaDeNumeros[j + 1]))
                    {
                        int aux = Int32.Parse(ListaDeNumeros[j]);
                        ListaDeNumeros[j] = ListaDeNumeros[j + 1];
                        ListaDeNumeros[j + 1] = aux.ToString();
                    }
                }
            }
            foreach (string numero in ListaDeNumeros)
                listNum.Items.Add(numero);
            }


            if (radbtnAscendente.Checked)
            {
                List<string> ListaDeNumeros = new List<string>();
                foreach (string numero in listNum.Items)
                    ListaDeNumeros.Add(numero);

                listNum.Items.Clear();

                for (int i = 0; i < ListaDeNumeros.Count - 1; i++)
                {
                    for (int j = 0; j < ListaDeNumeros.Count - 1; j++)
                    {
                        if (Int32.Parse(ListaDeNumeros[j]) > Int32.Parse(ListaDeNumeros[j + 1]))
                        {
                            int aux = Int32.Parse(ListaDeNumeros[j]);
                            ListaDeNumeros[j] = ListaDeNumeros[j + 1];
                            ListaDeNumeros[j + 1] = aux.ToString();
                        }
                    }
                }
                foreach (string numero in ListaDeNumeros)
                    listNum.Items.Add(numero);
            }
        }
    }
}
