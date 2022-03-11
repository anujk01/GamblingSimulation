using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentGambling
{
    public class Gambling
    {
        public void Gamblerstake()
        {
            const int bet = 100;
            const int everygame = 1;
            int result;
        }

        public int WinLoose()
        {
            int result = new Random().Next(0, 2);
            return result;
        }

        public int Resign()
        {
            int win = 50;

            while (win > 50) ;
            {
                Console.WriteLine("Gamer Resign" + win);
                return win;
            }
        }
    }
}
