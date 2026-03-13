using System;
using System.Collections.Generic;


public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Did I study my scriptures today?",
        "Which lesson did I learn in scriptures reading?",
        "What made me happy today?",
        "What challenge did I overcome today?",
        "What am I grateful for today?",
        "Did I achieve one of my goal today?",
        "What is one of my goal for tomorrow?"

    };

    public Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}



    
        
       