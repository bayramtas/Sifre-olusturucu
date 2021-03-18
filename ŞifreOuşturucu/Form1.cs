using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ŞifreOuşturucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uzunluk = comboBox1.Text;
            int v = Convert.ToInt32(uzunluk);
            int enfazla = v;


            Random rastgele = new Random();
            string karakterler = "qwertyuıopğüasdfghjklşizxcvbnmöçQWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇ1234567890";
            string sonuç = "";

            for (int i = 0; i < enfazla; i++)
            {
                sonuç += karakterler[rastgele.Next(karakterler.Length)];
            }
            textBox1.Text = sonuç;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
