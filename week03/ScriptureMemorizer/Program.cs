/*
 * Showing Creativity and Exceeding Requirements
 * -------------------------------------------
 * 1. Mode Selection: The user can choose "Single Mode" (which is the core requirement) or 
    "Multi Mode" (lets the user keep going by choosing 'next'). This uses a library of scriptures, not just one.
 * 2. Random Order: In Multi Mode, scriptures appear in a different order each time for better engagement.
 * 3. Smart Word Hiding: The program only hides words that are not already hidden, making memorization more user-friendly.
 */

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to Scripture Memorizer!");
        Console.WriteLine();
        Console.WriteLine("Choose mode:");
        Console.WriteLine();
        Console.WriteLine("1 =  Memorize a Single scripture");
        Console.WriteLine("2 = Memorize Multiple scriptures");
        string mode = Console.ReadLine().Trim();

        if (mode == "1")
        {
            RunSingleMode();
        }
        else
        {
            RunMultiMode();
        }
    }

    static void RunSingleMode()
    {
        var scriptureLibrary = ScriptureLibrary.GetScriptures();
        Random rand = new Random();
        var scriptureEntry = scriptureLibrary[rand.Next(scriptureLibrary.Count)];
        var scripture = new Scripture(scriptureEntry.GetReference(), scriptureEntry.GetText());

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                return;

            scripture.HideRandomWords(2);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("All words are hidden! Program will now end.");
                return;
            }
        }
    }

    static void RunMultiMode()
    {
        var scriptureLibrary = ScriptureLibrary.GetScriptures();

        // Shuffle for random order
        Random rand = new Random();
        for (int i = 0; i < scriptureLibrary.Count; i++)
        {
            int j = rand.Next(i, scriptureLibrary.Count);
            var temp = scriptureLibrary[i];
            scriptureLibrary[i] = scriptureLibrary[j];
            scriptureLibrary[j] = temp;
        }

        int scriptureIndex = 0;
        while (scriptureIndex < scriptureLibrary.Count)
        {
            var scriptureEntry = scriptureLibrary[scriptureIndex];
            var scripture = new Scripture(scriptureEntry.GetReference(), scriptureEntry.GetText());

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("Press Enter to hide more words, type 'next' for another verse, or 'quit' to exit.");
                string input = Console.ReadLine().Trim().ToLower();

                if (input == "quit")
                    return;
                else if (input == "next")
                {
                    scriptureIndex++;
                    break;
                }
                else
                {
                    scripture.HideRandomWords(2);

                    if (scripture.IsCompletelyHidden())
                    {
                        Console.Clear();
                        Console.WriteLine(scripture.GetDisplayText());
                        Console.WriteLine();
                        Console.WriteLine("All words are hidden for this scripture. Type 'next' for another verse, or 'quit' to exit.");
                        input = Console.ReadLine().Trim().ToLower();
                        if (input == "next")
                        {
                            scriptureIndex++;
                            break;
                        }
                        else if (input == "quit")
                            return;
                    }
                }
            }
        }

        Console.WriteLine("You've finished all verses. Program ended.");
    }
}
