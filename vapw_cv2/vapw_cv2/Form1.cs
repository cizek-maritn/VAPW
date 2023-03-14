using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vapw_cv2
{
    public partial class Form1 : Form
    {
        character player;
        character enemy;
        Random r = new Random();
        bool a = false;
        bool b = false;
        
        public Form1()
        {
            InitializeComponent();
            button5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int atk = 6 + r.Next(6);
            int hp = 12 + r.Next(6) + r.Next(6);
            player = new character("player", atk, hp);
            label1.Text = player.getName();
            label3.Text = "atk " + player.getAttack();
            label5.Text = "hp " + player.getHealth();
            button1.Visible = false;
            button3.Visible = false;
            a = true;
            if (a && b)
            {
                button5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int atk = 6 + r.Next(6);
            int hp = 12 + r.Next(6) + r.Next(6);
            enemy = new character("enemy", atk, hp);
            label2.Text = enemy.getName();
            label4.Text = "atk " + enemy.getAttack();
            label6.Text = "hp " + enemy.getHealth();
            button2.Visible = false;
            button4.Visible = false;
            b = true;
            if (a && b)
            {
                button5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player = new character("horac", 10, 20);
            label1.Text = player.getName();
            label3.Text = "atk " + player.getAttack();
            label5.Text = "hp " + player.getHealth();
            button1.Visible = false;
            button3.Visible = false;
            a = true;
            if (a && b)
            {
                button5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            enemy = new character("the IRS", 10, 20);
            label2.Text = enemy.getName();
            label4.Text = "atk " + enemy.getAttack();
            label6.Text = "hp " + enemy.getHealth();
            button2.Visible = false;
            button4.Visible = false;
            b = true;
            if (a && b)
            {
                button5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int pRoll;
            int eRoll;
            pRoll = r.Next(6) + player.getAttack();
            eRoll = r.Next(6) + enemy.getAttack();
            label7.Text = "rolled: " + pRoll;
            label8.Text = "rolled: " + eRoll;
            if (pRoll>eRoll)
            {
                enemy.setHealth(enemy.getHealth() - 2);
                label6.Text = "hp " + enemy.getHealth();
            } else if (eRoll>pRoll)
            {
                player.setHealth(player.getHealth() - 2);
                label5.Text = "hp " + player.getHealth();
            }
            if (player.getHealth() <= 0)
            {
                label9.Visible = true;
                label9.Text = "YOU LOSE";
                button5.Visible = false;
            }
            if (enemy.getHealth() <= 0)
            {
                label9.Visible = true;
                label9.Text = "YOU WIN";
                button5.Visible = false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
