using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_14
{
    internal class Program
    {
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

       
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("So a va b luc dau la : " + a + " , " + b );
            Swap(ref a, ref b);

            
            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
