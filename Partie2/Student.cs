using System;

namespace Partie2
{
    public class Student
    {
        private string name;
        private int life;
        private int damage;
        public bool isMagician;
        public int physicalArmor;
        public int magicalArmor;

        private static ulong nbStudent = 0;

        public Student(string name, int life, int damage, bool isMagician, int physicalArmor, int magicalArmor)
        {
            this.name = name.ToUpper();
            this.life = life;
            this.damage = damage;
            this.isMagician = isMagician;
            this.physicalArmor = physicalArmor;
            this.magicalArmor = magicalArmor;
            nbStudent++;
        }
        
        // Static functions

        public static void DisplayNbStudent()
        {
            Console.WriteLine("There are {0} student(s).", nbStudent);
        }
        
        // Methodes

        public void TakeDamage(int damage, bool isMagical)
        {
            if (isMagical)
                Life -= Math.Max(0, damage - magicalArmor);
            else
                Life -= Math.Max(0, damage - physicalArmor);
        }
        
        public void Attack(Student s)
        {
            if (s == this)
                throw new Exception("You can't hit your self!");
            s.TakeDamage(damage, isMagician);
        }

        public virtual void Status()
        {
            Console.WriteLine("I still have {0} HP.", life);
        }
        
        // Getters & Setters
        
        public string Name
        {
            get { return name; }
            set { name = value.ToUpper(); }
        }

        public int Life
        {
            get { return life; }
            set { life = Math.Max(0, value); }
        }

        public int Damage
        {
            get { return damage; }
            set { damage = Math.Max(Math.Min(value, 10), 0); }
        }
    }
}