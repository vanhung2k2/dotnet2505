using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3
{
    internal class Program
    {
        static void nhap(out double n)
        {
            do
            {
                Console.WriteLine("Nhap do C :");
                try
                {
                    n = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Du lieu nhap vao khong hop le. Vui long nhap mot so.");
                }
            } while (true);
        }
        static void Main(string[] args)
        {
            double a;
            nhap(out a);
            Console.WriteLine($"Do C sau khi doi thanh do K co gia tri la : {a + 273}");
            Console.WriteLine($"Do C sau khi doi thanh do F co gia tri la : {a * 18 / 10 + 32}");


        }
    }
}
