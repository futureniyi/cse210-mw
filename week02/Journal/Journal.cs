using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._time}|{entry._mood}|{entry._promptText}|{entry._entryText}");
            }
        }
    }


    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 5)
            {
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._time = parts[1];
                entry._mood = parts[2];
                entry._promptText = parts[3];
                entry._entryText = parts[4];
                _entries.Add(entry);
            }
        }
    }


}
