using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaDeControles
{
    public partial class TaTeTi : UserControl
    {
        private bool turnoX;
        public TaTeTi()
        {
            InitializeComponent();
            this.turnoX = true;
            foreach (Control c in this.Controls)
            {
                c.Click += new EventHandler(marcarCasillero);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void marcarCasillero(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "")
            {
                if (this.turnoX)
                {
                    ((Button)sender).Text = "X";
                    this.turnoX = false;
                }
                else
                {
                    ((Button)sender).Text = "O";
                    this.turnoX = true;
                }

            }
            verificarEstado();
        }

        private void verificarEstado()
        {
            if (this.btn1.Text != "" && this.btn2.Text != "" && this.btn3.Text != "")
                if (this.btn1.Text == this.btn2.Text && this.btn2.Text == this.btn3.Text)
                    MessageBox.Show("Gano pibe CANTINA!!!");

            if (this.btn4.Text != "" && this.btn5.Text != "" && this.btn6.Text != "")
                if (this.btn4.Text == this.btn5.Text && this.btn5.Text == this.btn6.Text)
                    MessageBox.Show("Gano pibe CANTINA!!!");

            if (this.btn7.Text != "" && this.btn8.Text != "" && this.btn9.Text != "")
                if (this.btn7.Text == this.btn8.Text && this.btn8.Text == this.btn9.Text)
                    MessageBox.Show("Gano pibe CANTINA!!!");

            if (this.btn1.Text != "" && this.btn4.Text != "" && this.btn7.Text != "")
                if (this.btn1.Text == this.btn4.Text && this.btn4.Text == this.btn7.Text)
                    MessageBox.Show("Gano pibe CANTINA!!!");

            if (this.btn2.Text != "" && this.btn5.Text != "" && this.btn8.Text != "")
                if (this.btn2.Text == this.btn5.Text && this.btn5.Text == this.btn8.Text)
                    MessageBox.Show("Gano pibe CANTINA!!!");

            if (this.btn3.Text != "" && this.btn6.Text != "" && this.btn9.Text != "")
                if (this.btn3.Text == this.btn6.Text && this.btn6.Text == this.btn9.Text)
                    MessageBox.Show("Gano pibe CANTINA!!!");

            if (this.btn1.Text != "" && this.btn5.Text != "" && this.btn9.Text != "")
                if (this.btn1.Text == this.btn5.Text && this.btn5.Text == this.btn9.Text)
                    MessageBox.Show("Gano pibe CANTINA!!!");

            if (this.btn3.Text != "" && this.btn5.Text != "" && this.btn7.Text != "")
                if (this.btn3.Text == this.btn5.Text && this.btn5.Text == this.btn7.Text)
                    MessageBox.Show("Gano pibe CANTINA!!!");

            bool lleno = true;

            foreach (Control c in this.Controls)
            {
                

                if (((Button)c).Text == "")
                {
                    lleno = false;
                    break;
                }
            }

            if (lleno)
                MessageBox.Show("EMPATE MAESTRULI!!!!!!");

        }

    }
}
