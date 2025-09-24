using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

class Program
{

    static void Main(string[] args)
    {
        welcome();
        int birthyear;
        BirthYear(out birthyear);

        display(birthyear);
    }





    static void welcome()
    {
        Console.WriteLine("welcome to the program!");
    }

    static string promptusername()
    {
        Console.Write("What is your name?");
        string username = Console.ReadLine();
        return username;
    }

    static int favoritenumber()
    {
        Console.Write("What is your favorite number?");
        string usernumber = Console.ReadLine();
        int number = int.Parse(usernumber);
        return number;
    }

    static void BirthYear(out int birthyear)
    {
        Console.Write("What year were you born?");
        string userinput = Console.ReadLine();
        birthyear = int.Parse(userinput);
    }

    static int squarenumber()
    {
        Console.Write("Give me a random number?");
        string randominput = Console.ReadLine();
        int randomnumber = int.Parse(randominput);
        int squarednumber = randomnumber * randomnumber;
        return squarednumber;
    }

    static void display(int birthyear)
    {
        string username = promptusername();
        int number = favoritenumber();
        int squarednumber = squarenumber();
        Console.WriteLine($"Hello {username}, your favorite number is: {number}.");
        Console.WriteLine($"The square of your random number is: {squarednumber}.");
        Console.WriteLine($"You are {2025 - birthyear} years old.");
    }
}