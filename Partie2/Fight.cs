using System;

namespace Partie2
{
    public class Fight
    {
        private Student firstStudent;
        private Student secondStudent;
        private uint round;

        public Fight(Student firstStudent, Student secondStudent)
        {
            this.firstStudent = firstStudent;
            this.secondStudent = secondStudent;
            round = 1;
        }

        public bool isFinished()
        {
            return firstStudent.Life == 0 || secondStudent.Life == 0;
        }

        public void Update(bool verbose)
        {
            firstStudent.Attack(secondStudent);
            secondStudent.Attack(firstStudent);
            if (verbose)
            {
                Console.WriteLine("-- Round {0} --", round);
                firstStudent.Status();
                secondStudent.Status();
            }
            round++;
        }

        public Student GetWinner()
        {
            if (firstStudent.Life == 0 && secondStudent.Life != 0)
                return secondStudent;
            if (firstStudent.Life != 0 && secondStudent.Life == 0)
                return firstStudent;
            return null;
        }
        
        public void Finish()
        {
            Student winner = GetWinner();
            if (winner == null)
                Console.WriteLine("No one won this fight!");
            else
            {
                Console.WriteLine("-- The fight is done --");
                Console.WriteLine("{0} Won this fight!", winner.Name);
            }
        }

        public Student FirstStudent
        {
            get { return firstStudent; }
        }
        
        public Student SecondStudent
        {
            get { return secondStudent; }
        }
        
        public uint Round
        {
            get { return round; }
        }
    }
}