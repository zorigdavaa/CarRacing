using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_racing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            button1.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coins(gamespeed);
            getcoin();
        }
        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(0, 320);
                y = r.Next(0, 0);
                enemy1.Location = new Point(x, y);
            }
            else
            {
                enemy1.Top += speed;
            }
            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 320);
                y = r.Next(0, 0);
                enemy2.Location = new Point(x, y);
            }
            else
            {
                enemy2.Top += speed;
            }
            if (enemy3.Top >= 500)
            {
                x = r.Next(0, 320);
                y = r.Next(0, 0);
                enemy3.Location = new Point(x, y);
            }
            else
            {
                enemy3.Top += speed;
            }
        }

        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 320);
                y = r.Next(0, 0);
                coin1.Location = new Point(x, y);
            }
            else
            {
                coin1.Top += speed;
            }
            if (coin2.Top >= 500)
            {
                x = r.Next(0, 320);
                y = r.Next(0, 0);
                coin2.Location = new Point(x, y);
            }
            else
            {
                coin2.Top += speed;
            }
            if (coin3.Top >= 500)
            {
                x = r.Next(0, 320);
                y = r.Next(0, 0);
                coin3.Location = new Point(x, y);
            }
            else
            {
                coin3.Top += speed;
            }
            if (coin4.Top >= 500)
            {
                x = r.Next(0, 320);
                y = r.Next(0, 0);
                coin4.Location = new Point(x, y);
            }
            else
            {
                coin4.Top += speed;
            }
        }

        int collectedcoins = 0;
        void getcoin()
        {
            if (car1.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoins ++;
                label2.Text = "coins=" + collectedcoins.ToString();
                x = r.Next(0, 320);
                y = r.Next(0, 0);
                coin1.Location = new Point(x, y);
            }
            if (car1.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoins++;
                label2.Text = "coins=" + collectedcoins.ToString();
                x = r.Next(0, 320);
                y = r.Next(0, 0);
                coin2.Location = new Point(x, y);
            }
            if (car1.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoins++;
                label2.Text = "coins=" + collectedcoins.ToString();
                x = r.Next(0, 320);
                y = r.Next(0, 0);
                coin3.Location = new Point(x, y);
            }
            if (car1.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoins++;
                label2.Text = "coins=" + collectedcoins.ToString();
                x = r.Next(0, 320);
                y = r.Next(0, 0);
                coin4.Location = new Point(x, y);
            }
        }


        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = -25;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = -25;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = -25;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = -25;
            }
            else
            {
                pictureBox4.Top += speed;
            }

            
        }
        void gameover()
        {
            if (car1.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
                button1.Visible = true;
            }
            if (car1.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
                button1.Visible = true;
            }
            if (car1.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
                button1.Visible = true;
            }
        }
        private void PictureBox5_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }
        int gamespeed = 0;

        private void Coin2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Visible = false;
            button1.Visible = false;
            enemy1.Top = 0;
            enemy2.Top = 0;
            enemy3.Top = 0;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if(car1.Left>16)
                car1.Left += -12;
            }
            if (e.KeyCode == Keys.Right)
            {
                if(car1.Right<375)
                car1.Left += 12;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                    gamespeed++;
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                    gamespeed--;
            }

        }
    }
}
