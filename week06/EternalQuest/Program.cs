//Added part of program: ReturdGoal.cs(meaning nagative purformance)
//      -Changes in GoalManager through private void CreateGoal()
//           Console.WriteLine("4. Returd Goal")
//      -Changes in GoalManager through private void RecordEvent()
//               if  (_score < 0)
//                {
//                  _Score =+ 0
//                }
    
        


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}