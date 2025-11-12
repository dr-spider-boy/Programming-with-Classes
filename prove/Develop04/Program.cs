using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Mindfulness Companion ===");
            Console.WriteLine("1. Calm Breathing");
            Console.WriteLine("2. Personal Reflection");
            Console.WriteLine("3. Positive Listing");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            Activity activity = null;
            if (choice == "1") activity = new BreathingActivity();
            else if (choice == "2") activity = new ReflectionActivity();
            else if (choice == "3") activity = new ListingActivity();
            else if (choice == "4") break;
            else continue;

            activity.StartSession();
        }
    }
}
