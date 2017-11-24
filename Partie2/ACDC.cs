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
            Console.WriteLine("There are {0} ACDC.", nbACDC);
        }

        public void Taunt()
        {
          Console.WriteLine("These violent deadlines have violent ends.");
        }

        public override void Status()
        {
            Console.WriteLine("{0}: You can't beat me, I still have {1} HP.", Name, Life);
        }
    }
}
