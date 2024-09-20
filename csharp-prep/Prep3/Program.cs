using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is your magic number? ");
        // string magic = Console.ReadLine();
        // int number = int.Parse(magic);

        Console.WriteLine("Welcome to the magic number game! Try to guess the magic number!");

        string play = "yes";

        do
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(1, 101);

            int guessNum = -1;

            int guesses = 0;

            do
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                guessNum = int.Parse(guess);

                if (guessNum < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNum > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                guesses ++;
            } while (guessNum != number);

            Console.WriteLine($"You took {guesses} guesses.");
            Console.Write("Do you want to play again? ");

            play = Console.ReadLine();

        } while (play == "yes");
    }
}