using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaphore02
{
    public partial class Form1 : Form
    {
        int situation = 0;
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            switch (situation)
            {
                case 0:
                    timer2.Start();
                    pictureBox1.Image = Semaphore02.Properties.Resources.semaforo_verde;
                    btnCancelar.Enabled = true;
                    label2.Text = "Favor Cruzar";
                    timer1.Interval = 3000;
                    contador = 11;
                    contador = contador - 1;
                    this.LbContador.Text = Convert.ToInt32(contador).ToString();
                    if (contador == 0)
                    {
                        this.timer2.Enabled = false;
                    }
                    situation = 1;
                    break;
                case 1:
                    pictureBox1.Image = Semaphore02.Properties.Resources.semaforo_verde;
                    btnCancelar.Enabled = false;
                    timer1.Interval = 7000;
                    situation = 2;
                    break;

                case 2:
                    timer2.Start();
                    pictureBox1.Image = Semaphore02.Properties.Resources.semaforo_amarillo2;
                    timer1.Interval = 4000;
                    label2.Text = "Favor Cruzar";
                    //label2.Enabled = false;
                    btnCancelar.Enabled = false;
                    contador = 5;
                    contador = contador - 1;
                    this.LbContador.Text = Convert.ToInt32(contador).ToString();
                    if (contador == 0)
                    {
                        this.timer2.Enabled = false;
                    }
                    situation = 3;
                    break;

                case 3:
                    timer2.Start();
                    pictureBox1.Image = Semaphore02.Properties.Resources.semaforo_rojo;
                    //label2.Text = "No Cruzar";
                    label2.Enabled = false;
                    timer1.Interval = 5000;
                    btnCancelar.Enabled = false;
                    contador = 6;
                    contador = contador - 1;
                    this.LbContador.Text = Convert.ToInt32(contador).ToString();
                    if (contador == 0)
                    {
                        this.timer2.Enabled = false;
                        Form2 form = new Form2();
                        form.Show();
                    }
                    situation = 4;
                    
                    break;
                case 4:
                    timer2.Start();
                    
                    timer1.Interval = 1000;
                    label2.Enabled = false;
                    contador = 1;
                    contador = contador - 1;
                    this.LbContador.Text = Convert.ToInt32(contador).ToString();
                    if (contador == 0)
                    {
                        this.timer2.Enabled = false;
                        Form2 form = new Form2();
                        form.Show();
                    }
                    situation = 0;

                    break;

            }
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            if (timer1.Interval > 3000)
            {
                btnCancelar.Enabled = false;

            }
            else
               if (timer1.Interval < 3000)
            {
                btnCancelar.Enabled = true;
            }
            //btnCancelar.Enabled = false;
            //btnCancelar.Enabled = true;
            label1.Text = "Semaforo";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (btnCancelar.Text == "Cancelar")
            {
                timer1.Enabled = false;
                btnCancelar.Text = "Reanudar";
                label1.Text = "Semaforo Detenido";
            }
            else
                if (btnCancelar.Text == "Reanudar")
            {
                timer1.Enabled = true;
                btnCancelar.Text = "Cancelar";
                label1.Text = "Semaforo Encendido";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Semaphore02.Properties.Resources.semaforo_verde;
            //btnCancelar.Enabled = false;
            contador = 50;
            this.LbContador.Text = contador.ToString();
            this.timer2.Enabled = true;
            //timer2.Stop();
            //label2.Enabled = false;


        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            
            contador = contador - 1;
            this.LbContador.Text = Convert.ToInt32(contador).ToString();
            if (contador == 0)
            {
                this.timer2.Enabled = false;
            }
        }
    }
}
