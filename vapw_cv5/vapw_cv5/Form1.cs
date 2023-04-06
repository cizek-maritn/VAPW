using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vapw_cv5
{
    public partial class Form1 : Form
    {
        int cnt;
        bool move = false;
        int vecx;
        int vecy;
        int fw;
        int fh;
        public Form1()
        {
            InitializeComponent();
            int bw = button1.Width;
            int bh = button1.Height;
            fw = this.ClientRectangle.Width;
            fh = this.ClientRectangle.Height;
            button1.Left = (fw/2)-(bw/2);
            button1.Top = (fh/2)-(bh/2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cnt++;
            label1.Text = cnt.ToString();
            int newx = button1.Left + vecx;
            int newy = button1.Top + vecy;
            if (newx<0)
            {
                vecx = 0-vecx;
                newx = 0;
            } else if (newx+button1.Width>fw)
            {
                vecx = 0 - vecx;
                newx = fw-button1.Width;
            }
            if (newy<0)
            {
                vecy = 0 - vecy;
                newy = 0;
            } else if (newy+button1.Height>fh)
            {
                vecy = 0 - vecy;
                newy = fh-button1.Height;
            }
            button1.Left = newx;
            button1.Top = newy;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            Point coordinates = this.PointToClient(Cursor.Position);
            int xcoord = button1.Left+(button1.Width/2);
            int ycoord = button1.Top+(button1.Height/2);
            int mousex = coordinates.X;
            int mousey = coordinates.Y;
            vecx = (int) ((mousex - xcoord)/10);
            vecy = (int) ((mousey - ycoord)/10);
            
        }
    }
}
