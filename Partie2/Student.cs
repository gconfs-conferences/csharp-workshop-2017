using System;

namespace Partie2
{
    public class Student
    {
        private string _name;
        private int _life;
        private int _damage;
        public bool _is_magician;
        public int _physical_armor;
        public int _magical_armor;

        private static ulong nbStudent = 0;

        public Student(string name, int life, int damage, bool isMagician, int physicalArmor, int magicalArmor)
        {
            _name = name.ToUpper();
            _life = life;
            _damage = damage;
            _is_magician = isMagician;
            _physical_armor = physicalArmor;
            _magical_armor = magicalArmor;
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
                this._life -= Math.Max(0, damage - this._magical_armor);
            else
                this._life -= Math.Max(0, damage - this._physical_armor);
            this._life = Math.Max(0, this._life);
        }
        
        public void Attack(Student s)
        {
            s.TakeDamage(this._damage, this._is_magician);
        }
        
        // Getters & Setters
        
        public string Name
        {
            get { return _name; }
            set { _name = value.ToUpper(); }
        }

        public int Life
        {
            get { return _life; }
            set { _life = Math.Max(0, value); }
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = Math.Max(Math.Min(value, 10), -10); }
        }
    }
}