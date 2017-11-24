using System;

namespace Partie2
{
    public class Sup : Student
    {
        private static ulong nbSup = 0;
        public Sup(string name, int life, int damage, int physicalArmor, int magicalArmor) : base(name, life, damage, false, physicalArmor, magicalArmor)
        {
            nbSup++;
        }

        public static void DisplayNbSup()
        {
            Console.WriteLine("There are {0} Sups.", nbSup);
        }
        
        public override void Status()
        {
            Console.WriteLine("Please help! I have {0} HP left.", Life);
        }
    }
}