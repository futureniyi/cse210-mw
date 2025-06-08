// Exceeds Requirements:
// - Counts how many times each activity was performed and displays a summary when the user quits.
// - Logs every completed activity with timestamp, name, and duration in log.txt.
// - Allows user to view the activity log from the menu.

using System;

class Program
{
    static int breathingCount = 0;
    static int reflectingCount = 0;
    static int listingCount = 0;

    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. View Activity Log");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine().Trim();

            if (choice == "1")
            {
                breathingCount++;
                var activity = new BreathingActivity(
                    "Breathing",
                    "This activity will help you relax by guiding you through slow breathing.");
                activity.Run();
                LogActivity("Breathing", activity.GetDuration());
            }
            else if (choice == "2")
            {
                reflectingCount++;
                var activity = new ReflectingActivity(
                    "Reflecting",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience.");
                activity.Run();
                LogActivity("Reflecting", activity.GetDuration());
            }
            else if (choice == "3")
            {
                listingCount++;
                var activity = new ListingActivity(
                    "Listing",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                activity.Run();
                LogActivity("Listing", activity.GetDuration());
            }
            else if (choice == "4")
            {
                ViewLog();
            }
            else if (choice == "5")
            {
                Console.WriteLine();
                Console.WriteLine("Session Activity Summary:");
                Console.WriteLine($"Breathing Activities: {breathingCount}");
                Console.WriteLine($"Reflecting Activities: {reflectingCount}");
                Console.WriteLine($"Listing Activities: {listingCount}");
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }

    static void LogActivity(string activityName, int duration)
    {
        string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}\t{activityName}\t{duration} seconds";
        System.IO.File.AppendAllText("log.txt", logEntry + Environment.NewLine);
    }

    static void ViewLog()
    {
        string logPath = "log.txt";
        if (System.IO.File.Exists(logPath))
        {
            Console.WriteLine("\n--- Activity Log ---");
            string[] lines = System.IO.File.ReadAllLines(logPath);
            if (lines.Length == 0)
            {
                Console.WriteLine("Log file is empty.");
            }
            else
            {
                foreach (var line in lines)
                    Console.WriteLine(line);
            }
            Console.WriteLine("--- End of Log ---\n");
        }
        else
        {
            Console.WriteLine("No log file found yet.");
        }
    }
}
