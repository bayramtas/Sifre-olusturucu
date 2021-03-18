using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şifrekırıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        string random;
        int artan = 0;
        int azalan = 9999;

        private void timer1_Tick(object sender, EventArgs e)
        {
            artan++;
            azalan--;
            Random rnd = new Random();
            random = rnd.Next(0, 10000).ToString();
            label1.Text = artan.ToString();
            label2.Text = azalan.ToString();
            label3.Text = random;
            if (azalan.ToString() == textBox1.Text)
            {
                timer1.Stop();
                MessageBox.Show($@"{azalan.ToString()}", "Şifre", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (artan.ToString() == textBox1.Text)
            {
                timer1.Stop();
                MessageBox.Show($@"{artan.ToString()}", "Şifre", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (random == textBox1.Text)
            {
                timer1.Stop();
                MessageBox.Show($@"{random}", "Şifre", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
