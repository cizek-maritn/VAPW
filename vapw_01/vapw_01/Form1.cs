using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vapw_01
{
    //pole 20 int, cisla 1-10, najdi modus (nejcastejsi cislo)
    public partial class Form1 : Form
    {
        int[] a = new int[20];
        int count = 0; int max = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void inicializace(object sender, EventArgs e)
        {
            for (int i=0; i<a.Length; i++)
            {
                a[i] = rnd.Next(10)+1;
            }
        }

        private void modus(object sender, EventArgs e)
        {
            label2.Text = "";
            int[] b = new int[10];
            for (int i=0; i<a.Length; i++)
            {
                b[a[i] - 1]++;
            }
            for (int i=0; i<b.Length; i++)
            {
                label2.Text += b[i] + ", ";
                if (b[i] > count)
                {
                    count = b[i];
                    max = i+1;
                    
                }
            }

            label1.Text = "cislo " + max + " se vyskytuje " + count;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
