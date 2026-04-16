// 1.Added part of program: NegativeGoal.cs(meaning negative performance)
//      (Addition of new class NegativeGoal.cs ) user loses points on failure to complete goal
//  By:-Addition in GoalManager.cs -> menu in private void CreateGoal()
//           Console.WriteLine("4. Negative Goal")
//          _goals.Add(new NegativeGoal(name,desc,points) 
//      -Addition in GoalManager.cs through private void RecordEvent()
//               if  (_score < 0)
//                {
//                  _Score =+ 0
//                }
//     -Addition in GoalManager.cs through private void LoadGoals()
//               else if (goalType == "NegativeGoal") 
// 2. Added part of program: Level System
//      (Addition of new property _GetLevel in GoalManager.cs) user levels up after  
//      reaching certain score  500,300 and 100 thresholds
//      By:-Addition in GoalManager.cs -> private int _GetLevel.
//      -Addition in GoalManager.cs through public void DisplayPlayerInfo()       
// 3. Added part of program: completed goals counter
//      (Addition of new property _completedGoals in GoalManager.cs) user can see how

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