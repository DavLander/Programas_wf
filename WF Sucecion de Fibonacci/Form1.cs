using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Sucecion_de_Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double a = 0;
        private double b = 1;
        private int limit;

        private void chcDividir_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtLimit_TextChanged(object sender, EventArgs e)
        {

        }

        private void chcSum_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            object evento;
            limit = Convert.ToInt32(txtLimit.Text);
            int signo;

            if (this.chcSum.Checked)
            {
                signo = 1;

                secuencia(limit, signo);
            }

            if (this.chcRestar.Checked)
            {
                signo = 2;
            
                secuencia(limit, signo);
            }

            if (this.chcMultiplicar.Checked)
            {
                signo = 3;

                secuencia(limit, signo);
            }

            if (this.chcDividir.Checked)
            {
                signo = 4;

                secuencia(limit, signo);
            }

            /*
            Timer timer = new Timer();
            timer.Tick += new EventHandler(on_timer_event);
            timer.Interval = 100;
            timer.Enabled = true;
            */
        }

        void secuencia(int limit, int signo)
        {
            double operacion;

            switch (signo)
            {
                case 1:
                    this.txtResult.Text += "Suma de la serie: " + Environment.NewLine;
                    for (int i = 0; i <= limit; i++)
                    {
                        this.txtResult.Text += Convert.ToString(b) + Environment.NewLine;
                        operacion = a + b;
                        a = b;
                        b = operacion;
                    }

                    this.txtResult.SelectionStart = this.txtResult.TextLength;
                    this.txtResult.ScrollToCaret();

                    break;

                case 2:
                    this.txtResult.Text += "Resta de la serie: " + Environment.NewLine;
                    for (int i = 0; i <= limit; i++)
                    {
                        this.txtResult.Text += Convert.ToString(b) + Environment.NewLine;
                        operacion = a - b;
                        a = b;
                        b = operacion;
                    }

                    this.txtResult.SelectionStart = this.txtResult.TextLength;
                    this.txtResult.ScrollToCaret();

                    break;

                case 3:
                    this.txtResult.Text += "Multiplicacion de la serie: " + Environment.NewLine;
                    for (int i = 0; i <= limit; i++)
                    {
                        this.txtResult.Text += Convert.ToString(b) + Environment.NewLine;
                        operacion = a / b;
                        a = b;
                        b = operacion;
                    }

                    this.txtResult.SelectionStart = this.txtResult.TextLength;
                    this.txtResult.ScrollToCaret();

                    break;

                case 4:
                    this.txtResult.Text += "Divicion de la serie: " + Environment.NewLine;
                    for (int i = 0; i <= limit; i++)
                    {
                        this.txtResult.Text += Convert.ToString(b) + Environment.NewLine;
                        operacion = a / b;
                        a = b;
                        b = operacion;
                    }

                    this.txtResult.SelectionStart = this.txtResult.TextLength;
                    this.txtResult.ScrollToCaret();

                    break;

                default:
                    break;
            }
        }

        /*
        void on_timer_event(object sender, EventArgs e)
        {
            this.txtResult.Text += DateTime.Now.ToString("dd/MM/yy H:mm:ss ttt") + Environment.NewLine;
            txtResult.SelectionStart = txtResult.TextLength;
            txtResult.ScrollToCaret();
        }
        */
    }
}
