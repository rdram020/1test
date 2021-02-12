using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string alph = "абвгдеёж";
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mes = textBox1.Text;
            string key = textBox2.Text;
            string str = "";
            int first = 69;
            int second = 69;
            for (int i = 0; i < mes.Length; i++)
            {
                if (i < key.Length)
                {
                    for (int j = 0; j < alph.Length; j++)
                    {
                        if (mes[i] == alph[j]) first = j;
                        string temp_sumbolKey = key[i].ToString();
                        for (int x = 0; x < alph.Length; x++)
                        {
                            if (temp_sumbolKey == alph[x].ToString()) second = x;
                        }
                    }
                    int temp = (first + second) % alph.Length;
                    str += alph[temp];
                }
                else
                {
                    for (int k = 0; k < alph.Length; k++)
                    {
                        if (mes[i] == alph[k]) first = k;
                        string temp = key[(mes[i] % key.Length)].ToString();
                        if (temp == alph[k].ToString()) second = k;
                    }
                    str += alph[(first + second) % alph.Length];
                }
            }
            resultLabel.Text = str; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            alfLabel.Text += alph;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'а' && e.KeyChar <= 'ж') || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'а' && e.KeyChar <= 'ж') || e.KeyChar == 8 || e.KeyChar == 'ё')
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
    }
}
