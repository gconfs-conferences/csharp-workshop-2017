﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Partie1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Fibo
            Console.WriteLine("Fibo 0: {0}", Fibo(0));
            Console.WriteLine("Fibo 1: {0}", Fibo(1));
            Console.WriteLine("Fibo 2: {0}", Fibo(2));
            Console.WriteLine("Fibo 6: {0}", Fibo(6));
            Console.WriteLine("Fibo 42: {0}", Fibo(42));

            // Fact
            Console.WriteLine("Fact 0: {0}", Fact(0));
            Console.WriteLine("Fact 1: {0}", Fact(1));
            Console.WriteLine("Fact 2: {0}", Fact(2));
            Console.WriteLine("Fact 3: {0}", Fact(3));
            Console.WriteLine("Fact 6: {0}", Fact(6));
            Console.WriteLine("Fact 12: {0}", Fact(12));
            
            // Min
            long[] tab = new long[] {1, 42, -42, 35};
            Console.WriteLine("Min [1, 42, -42, 35]: {0}", MinInTab(tab));
            
            // Sum
            long[,] mat1 = new long[,]
            {
                {61,3,34},
                {31,4,-7},
                {-7,8,2}
            };
            long[,] mat2 = new long[,]
            {
                {0,2,-1},
                {-8,4,26},
                {-2,-8,42}
            };
            Console.WriteLine("Sum: {0}", Sum(mat1, mat2));
            
            // Parite
            List<int> l1 = new List<int>(new int[] { 4, 5, 8, 3, 2, 5});

            int x = 3;
            int y = 42;
            Swap(ref x, ref y);
            Console.WriteLine("x: {0}  y: {1}", x, y);
        }

        private static long Fibo(long n)
        {
            if (n < 2)
                return n;
            long p1 = 0;
            long p2 = 1;
            for (long i = 0; i < n - 1; i++)
            {
                long swap = p2;
                p2 = p1 + p2;
                p1 = swap;
            }
            return p2;
        }

        private static long Fact(long n)
        {
            if (n == 0)
                return 1;
            return n * Fact(n - 1);
        }

        private static void Swap(ref int x, ref int y)
        {
            int swp = x;
            x = y;
            y = swp;
        }
        
        private static long MinInTab(long[] tab)
        {
            if (tab.Length == 0)
                throw new ArgumentException("min: Tab is empty");
            return tab.Min();
        }

        private static long[,] Sum(long[,] mat1, long[,] mat2)
        {
            long[,] res = new long[mat1.GetLength(0), mat1.GetLength(1)];
            for (int i = 0; i < mat1.GetLength(0); i++)
                for (int j = 0; j < mat1.GetLength(1); j++)
                    res[i, j] = mat1[i, j] + mat2[i, j];
            return res;
        }

        private static bool Parite(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
                if (list[i] % 2 != i % 2)
                    return false;
            return true;
        }

        private static uint NbBitsSet(long number)
        {
            uint n = 0;
            while (number != 0)
            {
                n += ((number & 1) == 1) ? 1u : 0u;
                number >>= 1;
            }
            return n;
        }
    }
}