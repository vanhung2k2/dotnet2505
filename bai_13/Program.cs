using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_13
{
    internal class Program
    {
        static void timMax(int[] a, out int max)
        {
            max = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > a[max])
                {
                    max = i;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[4] { 3, 5, 7, 6 };
            int max = 0;
            timMax(a, out max);
            Console.WriteLine("vi tri lon nhat la : " + a[max]);
        }
    }
}
