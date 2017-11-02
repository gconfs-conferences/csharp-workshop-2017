using System;
using System.Collections.Generic;

namespace Partie1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Fibo
            Console.WriteLine("Fibo 0: {0}", fibo(0));
            Console.WriteLine("Fibo 1: {0}", fibo(1));
            Console.WriteLine("Fibo 2: {0}", fibo(2));
            Console.WriteLine("Fibo 6: {0}", fibo(6));
            Console.WriteLine("Fibo 42: {0}", fibo(42));
            
            // Fact
            Console.WriteLine("Fact 0: {0}", fact(0));
            Console.WriteLine("Fact 1: {0}", fact(1));
            Console.WriteLine("Fact 2: {0}", fact(2));
            Console.WriteLine("Fact 3: {0}", fact(3));
            Console.WriteLine("Fact 6: {0}", fact(6));
            Console.WriteLine("Fact 12: {0}", fact(12));
        }

        private static long fibo(long n)
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
        
        private static long fact(long n)
        {
            if (n == 0)
                return 1; 
            return n * fact(n - 1);
        }
    }
}