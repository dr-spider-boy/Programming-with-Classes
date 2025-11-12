using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "List people you appreciate in your life:",
        "Write down your personal strengths:",
        "Who have you helped recently?",
        "When have you felt grateful this month?",
        "Who inspires you the most?"
    };

    private Random rand = new Random();

    public ListingActivity()
    {
        title = "Positive Listing Activity";
        descriptionText = "This activity helps you focus on the positive aspects of your life by listing items in a chosen area.";
    }

    protected override void RunActivity()
    {
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        Console.WriteLine("Start listing items now (press Enter after each). GO GO GO!!!");
        DateTime endTime = DateTime.Now.AddSeconds(durationSeconds);
        List<string> items = new List<string>();
        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(item))
                    items.Add(item);
            }
        }
        Console.WriteLine($"You listed {items.Count} items. Good job!!!");
    }
}
