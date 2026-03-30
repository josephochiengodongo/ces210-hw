using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _completedGoals = 0;
    private int _GetLevel = 0;
    private string GetLevel()
    {
        if (_score >= 500)
        {
            return "Master";
        }
        else if (_score >= 300)
        {
            return "Expert";
        }
        else if (_score >= 100)
        {
            return "Intermediate";
        }
        else
        {
            return "Beginner";
        }
    }

    public void Start()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            DisplayPlayerInfo();

            Console.WriteLine("\n1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": running = false; break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
        Console.WriteLine($"Level: {_GetLevel}");
        Console.WriteLine($"Completed Goals: {_completedGoals}");
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.ReadLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Negative Goal");

        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("You have earned bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
        else if (type == "4")
        {
            _goals.Add(new NegativeGoal(name,desc,points));
        }
    }

    public void RecordEvent()
    {
        ListGoalDetails();

        Console.Write("Which goal is completed? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int earned = _goals[index].RecordEvent();
        _score += earned;
        if (earned > 0)
        {
            _completedGoals++;
        }
        if(_completedGoals % 3 == 0)
        {
            Console.WriteLine("Congratulations! You've completed 3 goals and earned a bonus of 50 points!");
            _score += 50;
        }
        if (_score < 0)
        {
             _score = 0;
             
        }
        Console.WriteLine($"Earned {earned} points!");
        Console.ReadLine();
    }

    public void SaveGoals()
    {
        using (StreamWriter output = new StreamWriter("mygoals.txt"))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    
    public void LoadGoals()
    {
        string filename = "mygoals.txt";
        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];

            string[] parts = line.Split(":");
            string goalType = parts[0];

            string[] data = parts[1].Split(",");

            if (goalType == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(
                    data[0],
                    data[1],
                    int.Parse(data[2]),
                    bool.Parse(data[3])
                ));
            }   
            else if (goalType == "EternalGoal")
            {
                _goals.Add(new EternalGoal(
                    data[0],
                    data[1],
                    int.Parse(data[2])
                ));
            }
            else if (goalType == "ReturdGoal")
            {
                _goals.Add(new NegativeGoal(
                    data[0],
                    data[1],
                    int.Parse(data[2])
                ));
            }
            else if (goalType == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(
                    data[0],
                    data[1],
                    int.Parse(data[2]),
                    int.Parse(data[4]),
                    int.Parse(data[3]),
                    int.Parse(data[5])
                ));
            }
        }
    }
}

                