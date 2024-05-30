using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Nhap do C :");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine($"Do C sau khi doi thanh do K co gia tri la : {a + 273}");
            Console.WriteLine($"Do C sau khi doi thanh do F co gia tri la : {a * 18 / 10 + 32}");


        }
    }
}
