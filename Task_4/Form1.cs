using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        float x;
        float y_sin;
        float y_x;
        float y_x_plus_Sin;
        float y_xSin;
        int height;
        Bitmap bmp;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = 0;
            y_sin = 0;
            height = 150;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;

            g.DrawLine(new Pen(Color.Black, 2), 0, pictureBox1.Height / 2-25, pictureBox1.Width, pictureBox1.Height / 2-25);
            g.DrawLine(new Pen(Color.Black, 2), (float)(height*3.14)-105, 0,
                (float)(height * 3.14)-105, pictureBox1.Height);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y_sin = height/4 * (float)Math.Sin(Math.PI * x / 180) + height + 10;
            y_x = height - x-25; 
            y_x_plus_Sin = height / 4 * (float)Math.Sin(Math.PI * x / 180) + height+ height*3 - x-75;
            y_xSin = ((float)Math.Sin(Math.PI * x / 180)) * (x)+150;



            x++;
            
            g.FillEllipse(new Pen(Color.Black).Brush, x, y_sin, 5, 5);
            g.FillEllipse(new Pen(Color.Blue).Brush, x, y_x+(height*3)-50, 5, 5);
            g.FillEllipse(new Pen(Color.Red).Brush, x, y_x_plus_Sin, 5, 5);
            g.FillEllipse(new Pen(Color.Magenta).Brush, x, y_xSin, 5, 5);

            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
