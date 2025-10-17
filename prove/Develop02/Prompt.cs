using System;

public class PromptGenerator
{
    private string[] prompts = new string[]
    {
        "What made you smile today?",
        "Describe a challenge you faced recently.",
        "Write about a happy memory from your childhood.",
        "What are your goals for this week?",
        "Reflect on something you learned today.",
        "Who are you grateful for today and why?",
        "Describe a place you’d like to visit and why.",
        "Write about a time you overcame fear.",
        "What is something you did today that you’re proud of?",
        "Describe your perfect day."
    };

    private Random random = new Random();

    public string GetRandomPrompt()
    {
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}
