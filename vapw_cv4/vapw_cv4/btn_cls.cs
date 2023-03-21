using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vapw_cv4
{
    internal class btn_cls
    {
        int number;
        Button btn;
        public btn_cls(int n)
        {
            this.number = n;
            this.btn = new System.Windows.Forms.Button();

            this.btn.Location = new System.Drawing.Point(301, 13+(25*n));
            this.btn.Name = "btn" + n;
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 0;
            this.btn.Text = ""+n;
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
        }

        public int getNum()
        {
            return this.number;
        }

        public Button getBtn()
        {
            return this.btn;
        }

        public void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button number: " + this.number);
        }
    }
}
