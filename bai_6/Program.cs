using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so n :");
            n = int.Parse(Console.ReadLine());
            if(n%2==0)
            {
                Console.WriteLine("N la so chan !");
            }
            else
            {
                Console.WriteLine("N la so le !");
            }
        }
    }
}
