// Exceeded Requirements: Added NegativeGoal class.
// Users can create negative goals (bad habits) where they LOSE points if they record an event for that goal.


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

         GoalManager gm = new GoalManager();
        gm.MainMenu();
    }
}
