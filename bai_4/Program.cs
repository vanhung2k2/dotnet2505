using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_4
{
    internal class Program
    {
        static void nhap(out long n)
        {
            do
            {
                Console.Write("Nhap a = ");
                try
                {
                    n = long.Parse(Console.ReadLine());
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
            long a;
            nhap( out a);
            long giaithua = 1;
            for (int i = 1; i <= a; i++)
            {
                giaithua *= i;
            }
            Console.WriteLine($"Giai thua cua a la : {giaithua}");
        }
    }
}
