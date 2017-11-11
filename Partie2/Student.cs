using System;

namespace Partie2
{
    public class Student
    {
        private string name_;
        private int life_;
        private int damage_;
        private bool is_magician_;
        private int physical_armor_;
        private int magical_armor_;

        private static ulong nbStudent;

        public Student(string name, int life, int damage, bool isMagician, int physicalArmor, int magicalArmor)
        {
            name_ = name;
            life_ = life;
            damage_ = damage;
            is_magician_ = isMagician;
            physical_armor_ = physicalArmor;
            magical_armor_ = magicalArmor;
            nbStudent++;
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
            set { name_ = value; }
        }

        public int Life
        {
            get { return life_; }
            set { life_ = value; }
        }

        public int Damage
        {
            get { return damage_; }
            set { damage_ = value; }
        }

        public bool IsMagician
        {
            get { return is_magician_; }
            set { is_magician_ = value; }
        }

        public int PhysicalArmor
        {
            get { return physical_armor_; }
            set { physical_armor_ = value; }
        }

        public int MagicalArmor
        {
            get { return magical_armor_; }
            set { magical_armor_ = value; }
        }
    }
}