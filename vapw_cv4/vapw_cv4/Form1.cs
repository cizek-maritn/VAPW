using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vapw_cv4
{
    public partial class Form1 : Form
    {
        int n = 1;
        btn_cls[] arr = new btn_cls[20];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (n<20)
            {
                arr[n - 1] = new btn_cls(n);
                this.Controls.Add(arr[n-1].getBtn());
                n++;
            }
        }
    }
}
