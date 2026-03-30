//Added part of program: ReturdGoal.cs(meaning nagative purformance)
//      (Addition of new class ReturdGoal.cs ) user loses points on failer to complete goal
//  By:-Addition in GoalManager.cs -> menu in private void CreateGoal()
//           Console.WriteLine("4. Returd Goal")
//          _goals.Add(new ReturdGoal(name,desc,points) 
//      -Addition in GoalManager.cs through private void RecordEvent()
//               if  (_score < 0)
//                {
//                  _Score =+ 0
//                }
 //      -Addition in GoalManager.cs through private void LoadGoals()
 //               else if (goalType == "ReturdGoal")   
        


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