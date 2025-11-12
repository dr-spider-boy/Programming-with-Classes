using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        title = "Calm Breathing Exercise";
        descriptionText = "Relax your mind with slow, deep breaths. Focus on each inhale and exhale.";
    }

    protected override void RunActivity()
    {
        int timePassed = 0;
        while (timePassed < durationSeconds)
        {
            Console.WriteLine("Inhale slowly...");
            Countdown(5);
            timePassed += 5;
            if (timePassed >= durationSeconds) break;
            Console.WriteLine("Exhale slowly...");
            Countdown(5);
            timePassed += 5;
        }
    }

    void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($" {i} ");
            Thread.Sleep(900);
            Console.Write("\b\b\b");
        }
        Console.WriteLine();
    }
}
