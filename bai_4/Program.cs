using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine("Nhap so a :");
            a = long.Parse(Console.ReadLine());
            
            long giaithua = 1;
            for(int  i = 1; i <= a; i++)
            {
                giaithua*= i;
            }
            Console.WriteLine($"Giai thua cua a la : {giaithua}");
        }
    }
}
