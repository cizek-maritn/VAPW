using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vapw_pr6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(Pens.Aqua, 10, 10, 100, 100);
            g.DrawRectangle(Pens.Black, 100, 100, 120, 160);
            Rectangle r = new Rectangle(200, 200, 10, 10);
            Pen p1 = new Pen(Color.Bisque, 10);
            g.DrawEllipse(p1, r);

            g.DrawString("NAPIS!", this.Font, Brushes.Chocolate, 50, 50);
        }
    }
}
