using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geom2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1 :");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 :");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("z1 :");
            double z1 = double.Parse(Console.ReadLine());
            
            if (y1 < 0 && z1 > 0)
            {
                Console.WriteLine($"v1= {x1}i{y1}j+{z1}k");
            }
            if (y1 < 0 && z1 < 0)
            {
                Console.WriteLine($"v1= {x1}i{y1}j{z1}k");
            }
            if (y1 > 0 && z1 > 0)
            {
                Console.WriteLine($"v1= {x1}i+{y1}j+{z1}k");
            }
            if (y1 > 0 && z1 < 0)
            {
                Console.WriteLine($"v1= {x1}i+{y1}j{z1}k");
            }

            Console.WriteLine();
            Console.Write("x2 :");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 :");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write("z2 :");
            double z2 = double.Parse(Console.ReadLine());
            //Console.WriteLine($"{x2}x+{y2}y+{z2}=0");
            if (y2 < 0 && z2 > 0)
            {
                Console.WriteLine($"v2= {x2}i{y2}j+{z2}k");
            }
            if (y2 < 0 && z2 < 0)
            {
                Console.WriteLine($"v2= {x2}i{y2}j{z2}k");
            }
            if (y2 > 0 && z2 > 0)
            {
                Console.WriteLine($"v2= {x2}i+{y2}j+{z2}k");
            }
            if (y2 > 0 && z2 < 0)
            {
                Console.WriteLine($"v2= {x2}i+{y2}j{z2}k");
            }

            Console.WriteLine();
            Console.Write("x3 :");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("y3 :");
            double y3 = double.Parse(Console.ReadLine());
            Console.Write("z3 :");
            double z3 = double.Parse(Console.ReadLine());
            //Console.WriteLine($"{x2}x+{y2}y+{z2}=0");
            if (y3 < 0 && z3 > 0)
            {
                Console.WriteLine($"v3= {x3}i{y3}j+{z3}k");
            }
            if (y3 < 0 && z3 < 0)
            {
                Console.WriteLine($"v3= {x3}i{y3}j{z3}k");
            }
            if (y3 > 0 && z3 > 0)
            {
                Console.WriteLine($"v2= {x3}i+{y3}j+{z3}k");
            }
            if (y3 > 0 && z3 < 0)
            {
                Console.WriteLine($"v2= {x3}i+{y3}j{z3}k");
            }
            Console.WriteLine();
            /*
            double v1v2 = (x1 * x2) + (y1 * y2) + (z1 * z2);
            Console.Write("Produsul scalar :");
            Console.WriteLine(v1v2);
            if (v1v2 == 0) Console.WriteLine("Sunt perpendiculari");
            else Console.WriteLine("NU sunt perpendiculari");
            double m1 = Math.Sqrt((x1*x1) + (y1*y1) + (z1*z1));
            Console.WriteLine($"Marimea vectorului   ||v1|| = {m1}");
            double m2 = Math.Sqrt((x2*x2) + (y2*y2) + (z2*z2));
            Console.WriteLine($"Marimea vectorului   ||v2|| = {m2}");
            Console.WriteLine();
            //double v1xv2 = (y1*z2)i + (z1*x2)j + (x1*y2)k - (x2*y1)i - (z1*y2)j - (x1*z2)k;
            double i = (y1 * z2) - (z1 * y2);
            double j = (z1 * x2) - (x1 * z2);
            double k = (x1 * y2) - (x2 * y1);
            if (j < 0 && k > 0)
            {
                Console.WriteLine($"v1xv2= {i}i{j}j+{k}k");
            }
            if (j < 0 && k < 0)
            {
                Console.WriteLine($"v1xv2= {i}i{j}j{k}k");
            }
            if (j > 0 && k > 0)
            {
                Console.WriteLine($"v1xv2= {i}i+{j}j+{k}k");
            }
            if (j > 0 && k < 0)
            {
                Console.WriteLine($"v1xv2= {i}i+{j}j{k}k");
            }
            if (i == 0 && j == 0 && k == 0) Console.WriteLine($"v1xv2= 0");
            //Console.WriteLine($"Produsul vectorial :  {i}i {j}j {k}k");
            if (i == 0 && j == 0 && k == 0) Console.WriteLine("Sunt coliniari");
            else Console.WriteLine("NU sunt coliniari.");
            double aria = Math.Sqrt((i*i)+(j*j)+(k*k));
            Console.WriteLine("Aria");
            Console.WriteLine($"||v1xv2|| = {aria}");*/
            Console.WriteLine();
            double v1v2v3 = (x1*y2 * z3) + (y3*z1 * x2) + (x3 * y1*z2) - (x3 * y2*z1) - (z2 * y3*x1) - (x2 * z3*y1);
            Console.WriteLine($"Produsul mixt = {v1v2v3}");
            if (v1v2v3 == 0) Console.WriteLine("Sunt coplanari.");
            else Console.WriteLine("NU sunt coplanari.");
            Console.WriteLine($"Volumul paralelogramului = {Math.Abs(v1v2v3)}");
            Console.ReadKey();
        }
    }
}
