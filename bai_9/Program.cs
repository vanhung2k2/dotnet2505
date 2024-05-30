using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tmp = 0;
            int[] a = new int[4] { 3, 5, 7, 8 };
            Array.Sort(a);

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }

            }
            Console.Write("Day tang dan la : ");
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }

           Console.WriteLine();


            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }

            }
            Console.Write("Day giam dan la : ");
            foreach (var item in a)
            {
                Console.Write(item +" ");
            }
        }
    }
}
