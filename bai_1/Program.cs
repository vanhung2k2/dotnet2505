using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_buoi1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double a, b;
            Console.Write("Nhap so a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Nhap so b: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Tong {a} + {b} : {a+b}");
            Console.WriteLine($"Hieu {a} - {b} : {a-b}");
            Console.WriteLine($"Tich number {a} * {b} : {a*b}");
            Console.WriteLine($"thuong number {a} / {b} : {a/b}");

        }
    }

}