using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion.CajeroAutomatico
{
    public partial class Form1 : Form
    {
        private bool resto;
        public Form1()
        {
            InitializeComponent();
            this.resto = false;
        }


        private void Calcular(object sender, EventArgs e)
        {
            int dinero= Int32.Parse(this.txtIngreso.Text);
            int cont100 = 0;
            int cont50 = 0;
            int cont20 = 0;
            int cont10 = 0;
            int cont5 = 0;
            int cont2 = 0;
            bool resto = false;

            for (int i = dinero; i > 0; i++)
            {
                if (dinero >= 100)
                {
                    dinero = dinero - 100;
                    cont100++;
                    this.txtCien.Text = cont100.ToString();
                    continue;
                }

                if (dinero >= 50)
                {
                    dinero = dinero - 50;
                    cont50++;
                    this.txtCincuenta.Text = cont50.ToString();
                    continue;
                }

                if (dinero >= 20)
                {
                    dinero = dinero - 20;
                    cont20++;
                    this.txtVeinte.Text = cont20.ToString();
                    continue;
                }

                if (dinero >= 10)
                {
                    dinero = dinero - 10;
                    cont10++;
                    this.txtDiez.Text = cont10.ToString();
                    continue;
                }

                if (dinero >= 5)
                {
                    dinero = dinero - 5;
                    cont5++;
                    this.txtCinco.Text = cont5.ToString();
                    continue;
                }

                if (dinero >= 2)
                {
                    dinero = dinero - 2;
                    cont2++;
                    this.txtDos.Text = cont2.ToString();
                    continue;
                }

                else
                {
                    MessageBox.Show("Le queda $1 de vuelto");
                    break;
                }

            }
        }

        private void informar(object sender, EventArgs e)
        {
            MessageBox.Show("Debe limpiar la pantalla para seguir operando");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnAceptar.Click += new EventHandler(this.Calcular);
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.btnAceptar.Click -= new EventHandler(this.Calcular);
            this.btnAceptar.Click += new EventHandler(this.informar);
            this.btnLimpiar.Click += new EventHandler(this.Limpiar);
            
        }

        private void Limpiar(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Clear();
            }
            this.btnAceptar.Click -= new EventHandler(this.informar);
            this.btnLimpiar.Click -= new EventHandler(this.Limpiar);
            this.btnAceptar.Click += new EventHandler(this.Calcular);
        }



          
        
    }
}
