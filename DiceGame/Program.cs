using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 7);
            int userRandom = rnd.Next(1, 7);
            int cpuScore = 0;
            int userScore = 0;
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

                if (cpuRandom < userRandom)
                {
                    userScore++;
                }
                else
                {
                    cpuScore++;
                }
                
                cpuRandom = rnd.Next(1, 7);

                
                userRandom = rnd.Next(1, 7);
                i++;

            }
            if (userScore > cpuScore)
            {
                Console.WriteLine($"Kasutaja võitis mängu {userScore} punktiga.");
            }
            else
            {
                Console.WriteLine($"Arvuti võitis mängu {cpuScore} punktiga.");
            }

            if (userScore == cpuScore)
            {
                Console.WriteLine("Viik!");
            }

        }
    }
}
