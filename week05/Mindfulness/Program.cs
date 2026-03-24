// 1- Changes(upgrade) ReflectingActivity:    prompts/questions (random) won't repeate until all random are used.
//    add:- _usedPrompts : List<string> 
//          _usedQuestions : List<string>
// 2- Changes inside (upgrade) ListingActivity: prompt rotates faily.
// 3- Changes inside Program.cs: To show activity acomplished
//     addition in class program: int complrtedActivity = 0;  
//                                completedActivities++ (in case 1,2 and 3)
//                                Console.WriteLine($"Activities completed this session: {completedActivities}");


using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        bool running = true;
        int completedActivities = 0;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine();
            Console.WriteLine($"Activities completed this session: {completedActivities}");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    completedActivities++;
                    break;

                case "2":
                    ReflectingActivity reflection = new ReflectingActivity();
                    reflection.Run();
                    completedActivities++;
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    completedActivities++;
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}