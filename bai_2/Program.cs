using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double x = 0;
            Console.WriteLine("Nhap a , b ,c ");

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            Console.WriteLine($"Ham vua nhap la : {a}x^2 +{b}x + c ");

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0) { Console.WriteLine("Phuong trinh vo so nghiem"); }
                    else Console.WriteLine("Phuong trinh vo nghiem");
                }
                else
                {
                    x = -c / b;
                }
            }
            else
            {
                double delta = b * b - 4 * a * a;
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else if (delta == 0)
                {
                    Console.WriteLine($"Phuong trinh co nghiem kep : x = {-b / 2 * a}");
                }
                else
                {
                    Console.WriteLine($"Phuong trinh co nghiem x1 = {(-b + Math.Sqrt(delta)) / 2 * a} ; x2 = {(-b - Math.Sqrt(delta)) / 2 * a}");
                }

            }

        }
    }
}
