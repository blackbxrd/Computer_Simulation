using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labadabdabdab1
{
    public partial class Form1 : Form
    {
        
        private Random rnd = new Random();
        double W, H;
        double u;
        double l;
        long intersect = 0;
        long total = 0;
        Graphics g;


        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            H = panel1.Height;
            W = panel1.Width;
        }


        void g_linii()
        {
            Pen p = new Pen(Color.Black, 2);
            u = H / 3;
            int x1, x2, y1, y2;
            x1 = 0;
            y1 = (int)u;
            x2 = (int)W;
            y2 = (int)u;
            g.DrawLine(p, x1, y1, x2, y2);
            x1 = 0;
            y1 = 2 * (int)u;
            x2 = (int)W;
            y2 = 2 * (int)u;
            g.DrawLine(p, x1, y1, x2, y2);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            u = H / 3;
            l = H / 6;
            long i, n;
            n = Convert.ToInt64(textBox1.Text);
            double angel, sin, cos;
            double xc, yc, x1, x2, y1, y2;
            
            Pen p1 = new Pen(Color.Red, 2);
            Pen p2 = new Pen(Color.Black, 2);
            for (i = 1; i <= n; i++, total++)
            {
                xc = rnd.NextDouble() * (W - 2 * l) + l;
                yc = rnd.NextDouble() * (H - 2 * l) + l;
                angel = rnd.NextDouble() * 3.14159265359;
                cos = Math.Cos(angel);
                sin = Math.Sin(angel);
                x1 = xc + l * cos;
                y1 = yc + l * sin;
                x2 = xc + l * -cos;
                y2 = yc + l * -sin;
                if ((y2 <= u && y1 >= u) || (y2 <= 2 * u && y1 >= 2 * u))
                {
                    intersect++;
                    textBox2.Text = Convert.ToString(total);
                    textBox3.Text = Convert.ToString(intersect);
                    textBox4.Text = Convert.ToString(2.0 * total / intersect);
                    Application.DoEvents();
                    if (checkBox1.Checked == true)
                       
                            g.DrawLine(p2, (int)x1, (int)y1, (int)x2, (int)y2);
                }
                else
                    if (checkBox1.Checked == true)
                   
                        g.DrawLine(p1, (int)x1, (int)y1, (int)x2, (int)y2);
            }
            textBox2.Text = Convert.ToString(total);
            textBox3.Text = Convert.ToString(intersect);
            textBox4.Text = Convert.ToString(2.0 * total / intersect);
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            g_linii();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            total = 0;
            intersect = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            g_linii();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g_linii();
        }
    }
}
