using System.Security.Cryptography.X509Certificates;
using System;

namespace FifthTask
{
      class Program
    {
        public static void Main(string[] args)
        {
            // Create a number guessing game with the following rules.
            // Easy, intermediate and hard levels
            // Player should choose what level they wanna play
            // Easy
            // Player should guess from 1 to 10
            // Player has got 6 trials
            // Intermediate
            // Player should guess from 1 to 20
            // Player has got 4 trials
            // Hard
            // Player should guess from 1 to 50
            // Player has got 3 trials

            Console.WriteLine("Choose a Level between Easy, Intermediate and Hard, 1 for Easy, 2 for Intermediate and 3 for Hard");
            string level;
            // int trials;
            //Random random = new Random();
            Console.Write("What level would you like to play: ");
            var levelChose = int.Parse(Console.ReadLine());

            if (levelChose == 1)
            {
                level = "Easy";
            }
            else if (levelChose == 2)
            {
                level = "Intermediate";
            }
            else if (levelChose == 3)
            {
                level = "Hard";
            }
            else
            {
                level = "";
            }

            //If user chose Easy
            if (level == "Easy")
            {
                PlayGame(1, 10, 6);
            }


            if (level == "Intermediate")
            {
                PlayGame(1, 20, 4);
            }


            if (level == "Hard")
            {
                PlayGame(1, 50, 3);
            }

            if (level == "")
            {
                Console.WriteLine("Wrong Input");
            }

        }

            private static void PlayGame(int minNumber, int maxNumber, int numberOfAttempts)
            {
                // Player should guess from 1 to 10
                // Player has got 6 trials
                Console.WriteLine($"Please Take a Guess between (minNumber) and (maxNumber), You have (numberOfAttempts) trials");

                Random random = new Random();
                int guess = random.Next(minNumber, maxNumber + 1);

                int trials = 1;

                Console.Write("Guess a number now between (minNumber) and (maxNumber) : ");
                int GamerGuess = int.Parse(Console.ReadLine());

                do
                {
                    if (trials == numberOfAttempts)
                    {
                        Console.WriteLine("Sorry, You Lose.The number was {guess} ");
                        break;
                    }

                    if (guess != GamerGuess)
                    {
                        Console.Write("Sorry, wrong number, Play try again: ");
                        GamerGuess = int.Parse(Console.ReadLine());
                        trials++;
                    }

                    if (guess == GamerGuess)
                    {
                        Console.WriteLine($"Hey, You won. The number was {guess}");
                        break;
                    }

                } while (guess != GamerGuess);

            }




        }
    
}
