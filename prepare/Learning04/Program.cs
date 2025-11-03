using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Samuel Bennett", "Muliplication");
        Console.WriteLine(a1.GetSummary());

        Math a2 = new Math("Roberto Rodriguez", "Fractions", "7.3", "8-10");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());


        Writing a3 = new Writing("Mary Waters", "Eurpean history", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}