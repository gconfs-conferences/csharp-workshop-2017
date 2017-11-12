using System;

namespace Partie2
{
    public class ACDC : Student
    {
        private static ulong nbACDC = 0;
        
        public ACDC(string name, int life, int damage, int physicalArmor, int magicalArmor) : base(name, life, damage, true, physicalArmor, magicalArmor)
        {
            nbACDC++;
        }
        
        public static void DisplayNbACDC()
        {
            Console.WriteLine("Il y a {0} sups", nbACDC);
        }
    }
}