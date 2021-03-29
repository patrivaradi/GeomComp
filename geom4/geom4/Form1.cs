using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geom4
{
    public partial class Form1 : Form
    {
        private static Graphics gfx;
        private Random rnd=new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gfx = pictureBox1.CreateGraphics();
        }
        /*private void DrawRectangles()
        {
            Point p;
            int size;
            Color c;
            for (int i = 0; i < 8; i++)
            {
                p=new Point(rnd.Next())
            }
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            DrawRectangles();
        }
        private void DrawRectangles()
        {
            Pen pen = new Pen(Color.Black);
            string[] text = textBox1.Text.Split(' ');
            Point point = new Point(int.Parse(text[0]), int.Parse(text[1]));

            text = textBox2.Text.Split(' ');
            Size size = new Size(int.Parse(text[0]), int.Parse(text[1]));

            Rectangle rect = new Rectangle(point, size);

            gfx.DrawRectangle(pen, rect);
            DrawMidLines(rect);
            DrawAxis(rect);
        }
        private Rectangle GenerateRectangle()
        {
            int rectSize = rnd.Next(200);
            Size size = new Size(rectSize, rectSize);
            Point point = new Point(rnd.Next(pictureBox1.Size.Width - size.Width),
                rnd.Next(pictureBox1.Size.Height - size.Height));
            Rectangle rect = new Rectangle(point, size);
            if(checkBox1.Checked)
            { 
                DrawAxis(rect);
                DrawMidLines(rect);
            }
           
            return new Rectangle(point, size);
        }
        private Color RandomColor() => Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));

        private void DrawRandomRectangles()
        {
            
            for (int i = 0; i < 8; i++)
            {Pen pen = new Pen(RandomColor(), 3);
                gfx.DrawRectangle(pen, GenerateRectangle());
                // Color draw = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)); 
                
            }
           
        }
        private void DrawMidLines(Rectangle rect)
        {
            gfx.DrawLine(new Pen(Color.BlueViolet), rect.X + rect.Width / 2, rect.Y, rect.X + rect.Width / 2, rect.Y + rect.Height);
            gfx.DrawLine(new Pen(Color.BlueViolet), rect.X, rect.Y + rect.Height / 2, rect.X + rect.Width, rect.Y + rect.Height / 2);
        }
        private void DrawAxis(Rectangle rect)
        {
            gfx.DrawLine(new Pen(Color.BlueViolet), rect.X, rect.Y, rect.X + rect.Width, rect.Y + rect.Height);
            gfx.DrawLine(new Pen(Color.BlueViolet), rect.X + rect.Width, rect.Y, rect.X, rect.Y + rect.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DrawRandomRectangles();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DrawPoly();
        }
        private void DrawPoly()
        {
            int sides = int.Parse(textBox3.Text);
            PointF[] points = new PointF[sides];

            string[] text = textBox4.Text.Split(' ');

            PointF center = new PointF(float.Parse(text[0]), float.Parse(text[1]));
            float radius = float.Parse(textBox5.Text);
            double theta = Math.PI / sides;

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new PointF(center.X + radius * (float)Math.Cos(theta), center.Y + radius * (float)Math.Sin(theta));
                theta += 2 * Math.PI / sides;
            }


            gfx.FillPolygon(new SolidBrush(Color.White), points);
            gfx.DrawPolygon(new Pen(Color.Black), points);
        }
    }
}
