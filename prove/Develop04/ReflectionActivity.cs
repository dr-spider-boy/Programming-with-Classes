using System;
using System.Collections.Generic;

class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Recall a moment you overcame a challenge.",
        "Think of a time you helped someone in need.",
        "Remember when you stood up for someone.",
        "Reflect on a time you did something selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why does this moment stand out to you?",
        "Have you faced a similar situation before?",
        "How did you approach it?",
        "What did you feel when it was complete?",
        "What made this instance different from others?",
        "What is the most memorable aspect?",
        "What lessons can you carry forward?",
        "What did you discover about yourself?",
        "How can this guide you in the future?",
        "What will you do now?"
    };

    private Random rand = new Random();

    public ReflectionActivity()
    {
        title = "Personal Reflection Session";
        descriptionText = "This activity helps you explore your strengths and resilience.";
    }

    protected override void RunActivity()
    {
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        int timePassed = 0;
        while (timePassed < durationSeconds)
        {
            string question = questions[rand.Next(questions.Count)];
            Console.WriteLine(question);
            ShowAnimation(5);
            timePassed += 5;
        }
    }
}
