using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade?");
        string userinput = Console.ReadLine();
        int grade = int.Parse(userinput);
        string lettergrade;
        if (grade >= 90)
        {
            lettergrade = "A";
        }
        else if (grade >= 80)
        {
            lettergrade = "B";
        }
        else if (grade >= 70)
        {
            lettergrade = "C";
        }
        else if (grade >= 60)
        {
            lettergrade = "d";
        }
        else
        {
            lettergrade = "F";
        }
        Console.WriteLine($"Your grade is {grade}.");
        Console.WriteLine($"Your earned a {lettergrade} in the course.");
        if (grade >= 70)
        {
            Console.WriteLine("You passed!!");
        }
        else
        {
            Console.WriteLine("You have failed. Don't try again.");
        }
    }
}