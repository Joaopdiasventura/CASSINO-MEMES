using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cassino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled == false && timer2.Enabled == false && timer3.Enabled == false && timer4.Enabled == false && timer5.Enabled == false)
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
                timer3.Enabled = true;
                timer4.Enabled = true;
                timer5.Enabled = true;

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random gera = new Random();
            int x = gera.Next(0, 10);

            if (x == 1)
            {
                pictureBox1.Image = Properties.Resources.indoali;

            }

            else if (x == 2)
            {
                pictureBox1.Image = Properties.Resources.elemorango;
            }

            else if (x == 3)
            {
                pictureBox1.Image = Properties.Resources.vini;
            }

            else if (x == 4)
            {
                pictureBox1.Image = Properties.Resources.chupetao;
            }

            else if (x == 5)
            {
                pictureBox1.Image = Properties.Resources.piter;
            }

            else if (x == 6)
            {
                pictureBox1.Image = Properties.Resources.monday;
            }

            else if (x == 7)
            {
                pictureBox1.Image = Properties.Resources.miles;
            }

            else if (x == 8)
            {
                pictureBox1.Image = Properties.Resources.sigma;
            }

            else if (x == 9)
            {
                pictureBox1.Image = Properties.Resources.medo;
            }

            else if (x == 10)
            {
                pictureBox1.Image = Properties.Resources.gael;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random gera = new Random();
            int x = gera.Next(0, 10);

            if (x == 1)
            {
                pictureBox2.Image = Properties.Resources.indoali;

            }

            else if (x == 2)
            {
                pictureBox2.Image = Properties.Resources.elemorango;
            }

            else if (x == 3)
            {
                pictureBox2.Image = Properties.Resources.vini;
            }

            else if (x == 4)
            {
                pictureBox2.Image = Properties.Resources.chupetao;
            }

            else if (x == 5)
            {
                pictureBox2.Image = Properties.Resources.piter;
            }

            else if (x == 6)
            {
                pictureBox2.Image = Properties.Resources.monday;
            }

            else if (x == 7)
            {
                pictureBox2.Image = Properties.Resources.miles;
            }

            else if (x == 8)
            {
                pictureBox2.Image = Properties.Resources.sigma;
            }

            else if (x == 9)
            {
                pictureBox2.Image = Properties.Resources.medo;
            }

            else if (x == 10)
            {
                pictureBox2.Image = Properties.Resources.gael;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random gera = new Random();
            int x = gera.Next(0, 10);

            if (x == 1)
            {
                pictureBox3.Image = Properties.Resources.indoali;

            }

            else if (x == 2)
            {
                pictureBox3.Image = Properties.Resources.elemorango;
            }

            else if (x == 3)
            {
                pictureBox3.Image = Properties.Resources.vini;
            }

            else if (x == 4)
            {
                pictureBox3.Image = Properties.Resources.chupetao;
            }

            else if (x == 5)
            {
                pictureBox3.Image = Properties.Resources.piter;
            }

            else if (x == 6)
            {
                pictureBox3.Image = Properties.Resources.monday;
            }

            else if (x == 7)
            {
                pictureBox3.Image = Properties.Resources.miles;
            }

            else if (x == 8)
            {
                pictureBox3.Image = Properties.Resources.sigma;
            }

            else if (x == 9)
            {
                pictureBox3.Image = Properties.Resources.medo;
            }

            else if (x == 10)
            {
                pictureBox3.Image = Properties.Resources.gael;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Random gera = new Random();
            int x = gera.Next(0, 10);

            if (x == 1)
            {
                pictureBox4.Image = Properties.Resources.indoali;

            }

            else if (x == 2)
            {
                pictureBox4.Image = Properties.Resources.elemorango;
            }

            else if (x == 3)
            {
                pictureBox4.Image = Properties.Resources.vini;
            }

            else if (x == 4)
            {
                pictureBox4.Image = Properties.Resources.chupetao;
            }

            else if (x == 5)
            {
                pictureBox4.Image = Properties.Resources.piter;
            }

            else if (x == 6)
            {
                pictureBox4.Image = Properties.Resources.monday;
            }

            else if (x == 7)
            {
                pictureBox4.Image = Properties.Resources.miles;
            }

            else if (x == 8)
            {
                pictureBox4.Image = Properties.Resources.sigma;
            }

            else if (x == 9)
            {
                pictureBox4.Image = Properties.Resources.medo;
            }

            else if (x == 10)
            {
                pictureBox4.Image = Properties.Resources.gael;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            Random gera = new Random();
            int x = gera.Next(0, 10);

            if (x == 1)
            {
                pictureBox5.Image = Properties.Resources.indoali;

            }

            else if (x == 2)
            {
                pictureBox5.Image = Properties.Resources.elemorango;
            }

            else if (x == 3)
            {
                pictureBox5.Image = Properties.Resources.vini;
            }

            else if (x == 4)
            {
                pictureBox5.Image = Properties.Resources.chupetao;
            }

            else if (x == 5)
            {
                pictureBox5.Image = Properties.Resources.piter;
            }

            else if (x == 6)
            {
                pictureBox5.Image = Properties.Resources.monday;
            }

            else if (x == 7)
            {
                pictureBox5.Image = Properties.Resources.miles;
            }

            else if (x == 8)
            {
                pictureBox5.Image = Properties.Resources.sigma;
            }

            else if (x == 9)
            {
                pictureBox5.Image = Properties.Resources.medo;
            }

            else if (x == 10)
            {
                pictureBox5.Image = Properties.Resources.gael;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer4.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer5.Enabled = false;
        }
    }
}
