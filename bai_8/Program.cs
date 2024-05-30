using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> soChan = new List<int>();
            List<int> soLe = new List<int>();
            int[] a = new int[4] { 3, 5, 7, 8 };
            for(int i=0; i<a.Length; i++)
            {
                if (a[i]%2==0) soChan.Add(a[i]);
                else soLe.Add(a[i]);
            }
            Console.Write("Mang so chan : ");
            foreach(int i in soChan) { Console.Write(i + " "); }
            Console.WriteLine();
            Console.Write("Mang so le : ");
            foreach (int i in soLe) { Console.Write(i+" "); }

        }
    }
}
