/*
Exceeding Requirements

1. I added a mood option. When a user writes a journal entry, the program asks how they are feeling and saves their mood with the entry.
2. I added time tracking. The program saves not just the date, but also the time for each entry.
3. I used error handling (try-catch) when loading a file. If there is a problem, the program shows an error message instead of crashing.
*/


using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Write a new entry
                    // Get a random prompt
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");

                    // Get the user's response
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    // Ask for mood
                    Console.Write("How would you describe your mood? (e.g., happy, sad, excited, tired): ");
                    string mood = Console.ReadLine();

                    // Get today's date and time as strings
                    string date = DateTime.Now.ToShortDateString();
                    string time = DateTime.Now.ToShortTimeString();

                    // Create a new Entry and add to journal
                    Entry newEntry = new Entry();
                    newEntry._date = date;
                    newEntry._time = time;
                    newEntry._promptText = prompt;
                    newEntry._entryText = response;
                    newEntry._mood = mood;

                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added!\n");
                    break;
                case "2":
                    // Display the journal
                    if (journal._entries.Count == 0)
                    {
                        Console.WriteLine("\nNo entries yet.\n");
                    }
                    else
                    {
                        Console.WriteLine("\nYour Journal Entries:\n");
                        journal.DisplayAll();
                    }
                    break;
                case "3":
                    // Save the journal to a file
                    Console.Write("\nEnter a filename to save your journal (e.g., journal.txt): ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved!\n");

                    break;
                case "4":
                    // Load the journal from a file
                    Console.Write("\nEnter the filename to load your journal from (e.g., journal.txt): ");
                    string loadFile = Console.ReadLine();
                    try
                    {
                        journal.LoadFromFile(loadFile);
                        Console.WriteLine("Journal loaded!\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Could not load file: {ex.Message}\n");
                    }
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
