using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geom5
{
    public partial class Form1 : Form
    {
        private Random r;
        Bitmap bitmap;
        Graphics graphics;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            r = new Random();
            bitmap = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height, PixelFormat.Format32bppArgb);
            graphics = Graphics.FromImage(bitmap);

            this.pictureBox1.Image = bitmap;
        }
        private List<Point> pointList = new List<Point>();
        


        private void deseneazaBT_Click(object sender, EventArgs e)
        {

            if (int.TryParse(nrPuncte.Text, out var x))
            {
                for (int i = 0; i < x; i++)
                {
                    var p = new Point(r.Next(70, 279), r.Next(70, 284));
                    pointList.Add(p);

                    graphics.FillRectangle(new SolidBrush(Color.Red), p.X, p.Y, 6, 6);

                    pointList.Add(p);

                }
                this.pictureBox1.Image = bitmap;

            }
            else
            {
                MessageBox.Show("Completati cu un numar.");
            }
        }

        private void incercuireBT_Click(object sender, EventArgs e)
        {

            var h = GetConvexHull(pointList);

            if (h.Count < 5)
            {
                MessageBox.Show("Adaugati mai multe puncte pentru a le incercui. ");
                return;
            }
            Point? lastP = null;
            foreach (var point in h)
            {
                if (lastP == null)
                {
                    lastP = point;
                    continue;
                }

                graphics.DrawLine(new Pen(Color.Green, 3), lastP.Value, point);

                lastP = point;

            }
            graphics.DrawLine(new Pen(Color.Green, 3), h.Last(), h.First());


            this.pictureBox1.Image = bitmap;

        }
        private void stergeBT_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);

            pictureBox1.Image = bitmap;
        }

        public static List<Point> GetConvexHull(List<Point> points)
        {
            if (points == null)
                return null;

            if (points.Count() <= 1)
                return points;

            int n = points.Count(), k = 0;
            List<Point> H = new List<Point>(new Point[2 * n]);

            points.Sort((a, b) =>
                a.X == b.X ? a.Y.CompareTo(b.Y) : a.X.CompareTo(b.X));

            // Build lower hull
            for (int i = 0; i < n; ++i)
            {
                while (k >= 2 && cross(H[k - 2], H[k - 1], points[i]) <= 0)
                    k--;
                H[k++] = points[i];
            }

            // Build upper hull
            for (int i = n - 2, t = k + 1; i >= 0; i--)
            {
                while (k >= t && cross(H[k - 2], H[k - 1], points[i]) <= 0)
                    k--;
                H[k++] = points[i];
            }

            return H.Take(k - 1).ToList();
        }

        public static double cross(Point O, Point A, Point B)
        {
            return (A.X - O.X) * (B.Y - O.Y) - (A.Y - O.Y) * (B.X - O.X);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
