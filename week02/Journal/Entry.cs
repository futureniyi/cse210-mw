public class Entry
{
    // Member variables
    public string _date;
    public string _time;
    public string _promptText;
    public string _entryText;
    public string _mood;

    // methods to access these variables
    public void Display()
    {
        Console.WriteLine($"Date: {_date}  Time: {_time}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}\n");
    }
}