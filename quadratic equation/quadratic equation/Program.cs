using System;

namespace quadratic_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int x = Convert.ToInt32(Console.ReadLine());
            double sqrtpart = b * b - 4 * a * c;
            double y, x1, x2, img;
            if (sqrtpart > 0)
            {
                x1 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                x2 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);
                Console.WriteLine("Two Real Solutions: {0,8:f4} or  {1,8:f4}", x1, x2);
            }
            else if (sqrtpart < 0)
            {
                sqrtpart = -sqrtpart;
                x = -b / (2 * a);
                img = System.Math.Sqrt(sqrtpart) / (2 * a);
                Console.WriteLine("Two Imaginary Solutions: {0,8:f4} + {1,8:f4} i or {2,8:f4} + {3,8:f4} i", x, img, x, img);
            }
            else
            {
                x = (int)((-b + System.Math.Sqrt(sqrtpart)) / (2 * a));
                Console.WriteLine("One Real Solution: {0,8:f4}", x);
            }

        }
    }
}
