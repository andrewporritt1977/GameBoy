using System;
using System.Collections.Generic;
using System.Text;
using GameBoy20.Utils;

namespace GameBoy20.NumberGuessGame
{


    //Game Setup
    class Setup
    {
        public int Target { get; set; }

        public int Round { get; set; }

        public int Guess { get; set; }

        public string Result()
        {
            if (Guess == Target)
            {
                return Win();
            }
            else
            {
                return Lose();

            }
        }

        public int NumberGuess()
        {
            Random rando = new Random();
            return rando.Next(1, 10);
        }

        public string PlayRound()
        {
            Console.WriteLine("Guess my number Fam");
            Console.WriteLine("It's between 1 and 10");
            int guess = Convert.ToInt32(Console.ReadLine());
            Guess = guess;
            Result();
            return null;
        }

        public string Win()
        {
            Console.WriteLine("Congrats Bro! You Win!");
            return null;
        }

        public string Lose()
        {
            if (Round == 3) {
                Console.WriteLine("All Guesses Used Up. You Lose.....");
                Console.WriteLine("The number you were looking for is " + Target + "!!!");
                return null;
            } else
            {
                Console.WriteLine("Nah");
                Round += 1;
                PlayRound();
                return null;
            }


        }


    }

}
