using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string operacion;
        bool flag;
        public Form1()
        {
            InitializeComponent();
            this.operacion = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control item in this.grpNumeros.Controls)
                if (item is Button)
                    item.Click += new EventHandler(this.menajadorCentral);
        }

        private void menajadorCentral(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
       
                if(buton == this.btn0)
                { 
                    this.txtDisplay.Text += "0";
                    this.habilitarOperadores();
                }
                if(buton == this.btn1)
                { 
                    this.txtDisplay.Text += "1";
                    this.habilitarOperadores();
                }
                if(buton == this.btn2)
                { 
                    this.txtDisplay.Text += "2";
                    this.habilitarOperadores();
                }
                if(buton == this.btn3)
                { 
                    this.txtDisplay.Text += "3";
                    this.habilitarOperadores();
                }
                if(buton == this.btn4)
                { 
                    this.txtDisplay.Text += "4";
                    this.habilitarOperadores();
                }
                if (buton == this.btn5)
                {
                this.txtDisplay.Text += "5";
                this.habilitarOperadores();
                }
                if (buton == this.btn6)
                {
                this.txtDisplay.Text += "6";
                this.habilitarOperadores();
                }
                if (buton == this.btn7)
                {
                this.txtDisplay.Text += "7";
                this.habilitarOperadores();
                }
                if (buton == this.btn8)
                {
                this.txtDisplay.Text += "8";
                this.habilitarOperadores();
                }
                if (buton == this.btn9)
                {
                this.txtDisplay.Text += "9";
                this.habilitarOperadores();
                }
                if (buton == this.btnSuma)
                {
                this.txtDisplay.Text += "+";
                this.DesabilitarOperadores();
                }
                if (buton == this.btnResta)
                {
                this.txtDisplay.Text += "-";
                this.DesabilitarOperadores();
                }
                if (buton == this.btnMultiplicar)
                {
                this.txtDisplay.Text += "*";
                this.DesabilitarOperadores();
                }
                if (buton == this.btnDivision)
                {
                this.txtDisplay.Text += "/";
                this.DesabilitarOperadores();
                }
                if(buton == this.btnIgual)
                {
                    this.txtDisplay.Clear();
                    this.txtDisplay.Text = this.resolver();
                    this.btnIgual.Click -= this.menajadorCentral;
                    this.operacion = ""; 
                }   
        }

        private void DesabilitarOperadores()
        {
            foreach (Control item in this.grpOperadores.Controls)
                if (item is Button)
                    item.Click -= this.menajadorCentral;

            if (this.operacion == "")
                this.operacion += this.txtDisplay.Text;

            else
                this.operacion += this.txtDisplay.Text[this.txtDisplay.TextLength - 1];

            this.txtDisplay.Clear();
            this.txtDisplay.Focus();
             
        }

        private void habilitarOperadores()
        {

            if (this.operacion != "")
            {
                this.operacion += this.txtDisplay.Text; 
                this.btnIgual.Click += new EventHandler(this.menajadorCentral);
            }

            if (!this.txtDisplay.Text.Contains("+") && !this.txtDisplay.Text.Contains("-") && !this.txtDisplay.Text.Contains("*")
              && !this.txtDisplay.Text.Contains("/"))
                foreach (Control item in this.grpOperadores.Controls)
                    if (item is Button)
                        item.Click += new EventHandler(this.menajadorCentral);
        }

        private string resolver()
        {
            DataTable dt = new DataTable();
            int answer = (int)dt.Compute(this.operacion,"");
            return answer.ToString();
        }




     }
  }
                 
