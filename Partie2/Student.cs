using System;

namespace Partie2
{
    public class Student
    {
        private string name_;
        private int life_;
        private int damage_;
        public bool is_magician_;
        public int physical_armor_;
        public int magical_armor_;

        private static ulong nbStudent = 0;

        public Student(string name, int life, int damage, bool isMagician, int physicalArmor, int magicalArmor)
        {
            name_ = name.ToUpper();
            life_ = life;
            damage_ = damage;
            is_magician_ = isMagician;
            physical_armor_ = physicalArmor;
            magical_armor_ = magicalArmor;
            nbStudent++;
        }
        
        // Static functions

        public static void DisplayNbStudent()
        {
            Console.WriteLine("Il y a {0} etudiants.", nbStudent);
        }
        
        // Methodes

        public void TakeDamage(int damage, bool isMagical)
        {
            if (isMagical)
                this.life_ -= Math.Max(0, damage - this.magical_armor_);
            else
                this.life_ -= Math.Max(0, damage - this.physical_armor_);
            this.life_ = Math.Max(0, this.life_);
        }
        
        public void Attack(Student s)
        {
            s.TakeDamage(this.damage_, this.is_magician_);
        }
        
        // Getters & Setters
        
        public string Name
        {
            get { return name_; }
            set { name_ = value.ToUpper(); }
        }

        public int Life
        {
            get { return life_; }
            set { life_ = Math.Max(0, value); }
        }

        public int Damage
        {
            get { return damage_; }
            set { damage_ = Math.Max(Math.Min(value, 10), -10); }
        }
    }
}