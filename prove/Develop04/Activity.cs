using System;
using System.Threading;

abstract class Activity
{
    protected int durationSeconds;
    protected string title;
    protected string descriptionText;

    public void StartSession()
    {
        Console.Clear();
        Console.WriteLine($"--- {title} ---");
        Console.WriteLine(descriptionText);
        Console.Write("Enter session duration in seconds: ");
        durationSeconds = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare yourself for this session...");
        ShowAnimation(3);
        RunActivity();
        Console.WriteLine($"Great job! You finished the {title} sesion, which lasted {durationSeconds} seconds.");
        ShowAnimation(3);
    }

    protected void ShowAnimation(int seconds)
    {
        string spinner = ".,.,.,.,";
        for (int i = 0; i < seconds * 8; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    protected abstract void RunActivity();
}
