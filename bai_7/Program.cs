using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_7
{
    internal class Program
    {
        static bool nto(int n)
        {
            if (n < 2) return false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so n :");
            n = int.Parse(Console.ReadLine());
            if (nto(n))
            {
                Console.WriteLine("N la so nguyen to ! ");
            }
            else
            {
                Console.WriteLine("N khong la so nguyen to !");
            }
        }
    }
}
