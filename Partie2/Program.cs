using System;
using System.Collections.Generic;

namespace Partie2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Arena arena =  new Arena(100);
            arena.ResolveFights();
        }
    }
}