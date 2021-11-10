using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNladder
{
    class Program
    {
      //Constants 
        public const int NO_PLAY = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public const int FINAL = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("**Welcome to the game of snake and ladder");
            Console.WriteLine();
            //as per UC1
            Console.WriteLine("singlr player mode: Starting Position 0");
            Console.WriteLine("The Game Begins");
            int Position = 0;

            Random die = new Random();
            Random options = new Random();
            while (Position <= FINAL)
            {
                int dice = die.Next(1, 7);
                Console.WriteLine("The number on the dice roll is:" + dice);
                int opt = options.Next(0, 3);

                //option used 
                if (opt == NO_PLAY)
                {
                    Console.WriteLine("Player in same position--" + Position);
                }
                else if (opt == LADDER)
                {
                    Position = Position + dice;
                    Console.WriteLine("Ladder! new position" + Position);
                }
                else
                {
                    Position = Position - dice;
                    Console.WriteLine("Oops,Snake!--" + Position);
                }
                if (Position < 0)
                {
                    Position = 0;
                }
            }
            Console.ReadLine();


        }


    }
}

