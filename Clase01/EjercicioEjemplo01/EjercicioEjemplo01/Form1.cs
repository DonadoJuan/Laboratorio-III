﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioEjemplo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string cadena):this()
        {
            this.Text = cadena;
            this.lblNombre.Text = "Ingrese su nombre:";
            this.btnMostrar.Text = "Mostrar";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola mundo");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tu nombre es :" + txtNomb);
        }

        private void botonprueba_Click(object sender, EventArgs e)
        {

        }
    }
}
