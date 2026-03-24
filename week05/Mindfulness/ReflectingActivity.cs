using System;                                                                                                                                                         
public class ReflectingActivity : Activity

{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private List<string> _usedPrompts = new List<string>();
    private List<string> _usedQuestions = new List<string>();

    private Random _rand = new Random();

    public ReflectingActivity()
        : base(
            "Reflecting Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience."
          )
    {
    }

    public string GetRandomPrompt()
    {
        if (_usedPrompts.Count == _prompts.Count)
        {
            _usedPrompts.Clear();
        }

        string prompt;

        do
        {
            prompt = _prompts[_rand.Next(_prompts.Count)];
        }
        while (_usedPrompts.Contains(prompt));

        _usedPrompts.Add(prompt);

        return prompt;
    }

    public string GetRandomQuestion()
    {
        if (_usedQuestions.Count == _questions.Count)
        {
            _usedQuestions.Clear();
        }

        string question;

        do
        {
            question = _questions[_rand.Next(_questions.Count)];
        }
        while (_usedQuestions.Contains(question));

        _usedQuestions.Add(question);

        return question;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");

        Console.WriteLine("\nPress Enter when ready.");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"\n> {GetRandomQuestion()}");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}
