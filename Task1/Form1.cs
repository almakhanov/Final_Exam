using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;

        int cx;
        int cy;
        int x;
        int y;
        int val = 0;
        int[] coord = new int[2];
        int[] coords = new int[2];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width + 1, pictureBox1.Height + 1);
            cx = pictureBox1.Width / 4;
            cy = 0;
            x = pictureBox1.Width / 4 + 100;
            y = 100;

            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            g.DrawEllipse(new Pen(Color.Red, 2), cx, cy, 200, 200);
            g.DrawRectangle(new Pen(Color.Blue, 2), 50, pictureBox1.Height - 100, 360, 50);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            g.DrawLine(new Pen(Color.Blue, 1), 50+val, pictureBox1.Height - 100,
                50 + val, pictureBox1.Height - 50);


            coord[0] = x + (int)(100 * Math.Sin(Math.PI * val / 180));
            coord[1] = y - (int)(100 * Math.Cos(Math.PI * val / 180));

            val++;

            g.DrawLine(new Pen(Color.Red, 3), x, y, coord[0], coord[1]);

            Refresh();

            if(val == 360)
            {
                timer1.Enabled = false;
                MessageBox.Show("Done!");
            }
        }
    }
}
