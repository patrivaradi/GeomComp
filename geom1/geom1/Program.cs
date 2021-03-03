using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geom1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Xa :");
            double xa = double.Parse(Console.ReadLine());
            Console.Write("Ya :");
            double ya = double.Parse(Console.ReadLine());
            Console.Write("Xb :");
            double xb = double.Parse(Console.ReadLine());
            Console.Write("Yb :");
            double yb = double.Parse(Console.ReadLine());
            Console.Write("Xc :");
            double xc = double.Parse(Console.ReadLine());
            Console.Write("Yc :");
            double yc = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double a = ya - yb;
            double b = xa - xb;
            double c = (xa * yb) - (xb * ya);

            if (b < 0 && c>0)
            {
                Console.WriteLine($"AB: {a}X{b}Y+{c}=0");
            }
            if (b < 0 && c < 0)
            {
                Console.WriteLine($"AB: {a}X{b}Y{c}=0");
            }
            if (b > 0 && c > 0)
            {
                Console.WriteLine($"AB: {a}X-{b}Y+{c}=0");
            }
            if (b > 0 && c < 0)
            {
                Console.WriteLine($"AB: {a}X-{b}Y{c}=0");
            }

           Console.WriteLine();
            double dist = Math.Sqrt(((xa - xb) * (xa - xb)) + ((ya - yb) * (ya - yb)));
            Console.WriteLine($"|AB|={dist}");
            Console.WriteLine();
            double ec = (xa * yb) + (xb * yc) + (xc * ya) - (xc * yb) - (xa * yc) - (xb * ya);
            if (ec == 0)
                Console.WriteLine("Punctele sunt coliniare");
            else Console.WriteLine("Punctele NU sunt coliniare");
            Console.WriteLine();
            Console.Write("a1 :");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("b1 :");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("c1 :");
            double c1 = double.Parse(Console.ReadLine());
            //Console.WriteLine($"{a1}x+{b1}y+{c1}=0");
            if (b1 < 0 && c1 > 0)
            {
                Console.WriteLine($"d1: {a1}x{b1}y+{c1}=0");
            }
            if (b1 < 0 && c1 < 0)
            {
                Console.WriteLine($"d1: {a1}x{b1}y{c1}=0");
            }
            if (b1 > 0 && c1 > 0)
            {
                Console.WriteLine($"d1: {a1}x+{b1}y+{c1}=0");
            }
            if (b1 > 0 && c1 < 0)
            {
                Console.WriteLine($"d1: {a1}x+{b1}y{c1}=0");
            }

            Console.WriteLine();
            Console.Write("a2 :");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("b2 :");
            double b2 = double.Parse(Console.ReadLine());
            Console.Write("c2 :");
            double c2 = double.Parse(Console.ReadLine());
            //Console.WriteLine($"{a2}x+{b2}y+{c2}=0");
            if (b2 < 0 && c2 > 0)
            {
                Console.WriteLine($"d2: {a2}x{b2}y+{c2}=0");
            }
            if (b2 < 0 && c2 < 0)
            {
                Console.WriteLine($"d2: {a2}x{b2}y{c2}=0");
            }
            if (b2 > 0 && c2 > 0)
            {
                Console.WriteLine($"d2: {a2}x+{b2}y+{c2}=0");
            }
            if (b2 > 0 && c2 < 0)
            {
                Console.WriteLine($"d2: {a2}x+{b2}y{c2}=0");
            }

            Console.WriteLine();
            Console.Write("a3 :");
            double a3 = double.Parse(Console.ReadLine());
            Console.Write("b3 :");
            double b3 = double.Parse(Console.ReadLine());
            Console.Write("c3 :");
            double c3 = double.Parse(Console.ReadLine());
            //Console.WriteLine($"{a3}x+{b3}y+{c3}=0");
            if (b3 < 0 && c3 > 0)
            {
                Console.WriteLine($"d3: {a3}x{b3}y+{c3}=0");
            }
            if (b3 < 0 && c3 < 0)
            {
                Console.WriteLine($"d3: {a3}x{b3}y{c3}=0");
            }
            if (b3 > 0 && c3 > 0)
            {
                Console.WriteLine($"d3: {a3}x+{b3}y+{c3}=0");
            }
            if (b3 > 0 && c3 < 0)
            {
                Console.WriteLine($"d3: {a3}x+{b3}y{c3}=0");
            }
            Console.WriteLine();
            double ec1 = (a1 * b2*c3) + (a2*b3*c1) + (a3*b1*c2) - (a3*b2*c1) - (a1*c2*b3) - (a2*b1*c3);
            if (ec1 == 0)
                Console.WriteLine("Concurente");
            else Console.WriteLine("NU sunt concurente");
            Console.ReadKey();
        }
    }
}
