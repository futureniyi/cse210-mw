static void Main(string[] args)
{
    var scriptureLibrary = ScriptureLibrary.GetScriptures();

    // Shuffle (Fisher-Yates)
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
        Scripture scripture = new Scripture(scriptureEntry.GetReference(), scriptureEntry.GetText());

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
                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("All words are hidden! Type 'next' for another verse, or 'quit' to exit.");
                    input = Console.ReadLine().Trim().ToLower();
                    if (input == "next")
                    {
                        scriptureIndex++;
                        break;
                    }
                    else if (input == "quit")
                        return;
                }
                else
                {
                    scripture.HideRandomWords(2);
                }
            }
        }
    }

    Console.WriteLine("You've finished all verses. Program ended.");
}
