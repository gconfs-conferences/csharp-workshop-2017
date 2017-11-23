using System;

namespace Partie2
{
    public class Fight
    {
        private Student firstStudent_;
        private Student secondStudent_;
        private uint round_;

        public Fight(Student firstStudent, Student secondStudent)
        {
            firstStudent_ = firstStudent;
            secondStudent_ = secondStudent;
            round_ = 1;
        }

        public bool isFinished()
        {
            return firstStudent_.Life == 0 || secondStudent_.Life == 0;
        }

        public void Update(bool verbose)
        {
            firstStudent_.Attack(secondStudent_);
            secondStudent_.Attack(firstStudent_);
            if (verbose)
            {
                Console.WriteLine("-- Round {0} --", round_);
                firstStudent_.Status();
                secondStudent_.Status();
            }
            round_++;
        }

        public Student GetWinner()
        {
            if (firstStudent_.Life == 0 && secondStudent_.Life != 0)
                return secondStudent_;
            if (firstStudent_.Life != 0 && secondStudent_.Life == 0)
                return firstStudent_;
            return null;
        }
        
        public void Finish()
        {
            Console.WriteLine("-- The fight is done --");
            Student winner = GetWinner();
            if (winner == null)
                Console.WriteLine("{0} Won this fight!", secondStudent_.Name);
            else
                Console.WriteLine("No one won this fight!");
        }

        public Student FirstStudent
        {
            get { return firstStudent_; }
        }
        
        public Student SecondStudent
        {
            get { return secondStudent_; }
        }
        
        public uint Round
        {
            get { return round_; }
        }
    }
}