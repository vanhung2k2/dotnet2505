﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tong = 0;
            int[] a = new int[4] { 3, 5, 7, 8 };
            for(int i= 0 ; i<a.Length; i++)
            {
                tong += a[i];
            }
            Console.WriteLine("Tong bang : " + tong);
        }
    }
}
