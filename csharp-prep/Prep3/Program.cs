using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the game. There's no turnign back now.");
        Console.WriteLine("The magic number is bewteen 1 and 100 including.");
        Random randomgenerator = new Random();
        int magicnumber = randomgenerator.Next(1, 100);
        string guess;
        int intguess;
        int tracker = 0;
        do
        {
            Console.Write("What is your guess?");
            guess = Console.ReadLine();
            intguess = int.Parse(guess);
            tracker++;
            if (intguess == magicnumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (intguess < magicnumber)
            {
                Console.WriteLine("Higher");
            }
            else if (intguess > magicnumber)
            {
                Console.WriteLine("Lower");
            }
        } while (intguess != magicnumber);
        Console.WriteLine($"It took you {tracker} guesses!");
    }
}