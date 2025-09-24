using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        float average;
        int maximum = 0;

        int number;
        List<int> numbers;
        numbers = new List<int>();
        Console.WriteLine("Write down some numbers to add to a list. Type 0 when finished.");
        do
        {
            Console.Write("Enter Number:");
            string userinput = Console.ReadLine();
            number = int.Parse(userinput);
            numbers.Add(number);
            if (number > maximum)
            {
                maximum = number;
            }
        } while (number != 0);
        foreach (int item in numbers)
        {
            sum = sum + item;
        }
        average = sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maximum}");
    }
}