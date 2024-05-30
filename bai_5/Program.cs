using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_5
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
        static void nhap(out long n)
        {
            do
            {
                Console.WriteLine("Nhap so n :");
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
            long n;
            nhap(out n);
            for (int i = 0; i < n; i++)
            {
                if (nto(i)) Console.Write(i + " ");
            }
        }
    }
}
