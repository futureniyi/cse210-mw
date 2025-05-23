using System;

public class PromptGenerator
{
    public List<string> _prompts;

    // Constructor to initialize with at least five different prompts
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something I learned today?",
            "Describe a small act of kindness you witnessed or did today.",
            "Who is someone you are grateful for and why?",
            "Write about a happy memory from your childhood.",
            "What made you smile today?"
        };
    }

    // Method to get a random prompt
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }
}
