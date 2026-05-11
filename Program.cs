using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /* Richie's code
             * 
             **/
            string guess = null, again = null;
            bool playagain = true;
            Random rand = new Random();
            while (playagain)
            {
                int coin = 0, guess_2 = 0, right = 0, wrong = 0;
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Guess heads or tails");
                    guess = Console.ReadLine();
                    coin = rand.Next(2);
                    switch (guess)
                    {
                        case "heads":
                        case "Heads":
                        case "h":
                        case "H":
                            guess_2 = 1;
                            break;
                        case "tails":
                        case "Tails":
                        case "t":
                        case "T":
                            guess_2 = 0;
                            break;
                    }
                    if (guess_2 == coin)
                    {
                        right++;
                    }
                    else
                    {
                        wrong++;
                    }


                }
                Console.WriteLine($"you have {right} points and the computer has {wrong} points");
                Console.WriteLine("do you want to play again? (y/n)");
                again = Console.ReadLine();
                if (again != "y")
                {
                    playagain = false;
                    Console.WriteLine("press 'Enter' to exit");
                }
                else
                {
                    playagain = true;
                }
            }
            Console.ReadLine();
        }
    }
}
