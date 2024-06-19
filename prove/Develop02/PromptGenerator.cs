using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What new skill or knowledge did I gain today?",
        "What challenge did I face today and how did I overcome it?",
        "What was the most surprising thing that happened today?",
        "How did I help someone today?",
        "What made me laugh or smile today?",
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}