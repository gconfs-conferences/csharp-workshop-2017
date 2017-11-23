using System;
using System.Collections.Generic;

namespace Partie2
{
    public class Arena
    {
        public Stack<Fight> matchup_;

        public Arena(Stack<Fight> matchup)
        {
            matchup_ = matchup;
        }

        public Arena(uint nbFight)
        {
            matchup_ = new Stack<Fight>();
            Random rnd = new Random();
            for (uint i = 0; i < nbFight; i++)
            {
                var a = new ACDC("ACDC" + i, rnd.Next(50, 150), rnd.Next(5, 10), rnd.Next(0, 5), rnd.Next(0, 5));
                var s = new Sup("Sup" + i, rnd.Next(50, 150), rnd.Next(5, 10), rnd.Next(0, 5), rnd.Next(0, 5));
                matchup_.Push(new Fight(a, s));
            }
        }

        public void ResolveFights()
        {
            uint winsACDC = 0;
            uint winsSup = 0;
            uint draws = 0;
            while (matchup_.Count > 0)
            {
                Fight fight = matchup_.Pop();
                while (!fight.isFinished())
                    fight.Update(false);
                Student winner = fight.GetWinner();
                if (winner == null)
                    draws++;
                else if (winner is ACDC)
                    winsACDC++;
                else
                    winsSup++;
            }
            Console.WriteLine("ACDC: {0} wins / Sups: {1} wins / Draws: {2}", winsACDC, winsSup, draws);
        }
    }
}