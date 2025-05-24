using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int count = 0;

        List<int> indexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
                indexes.Add(i);
        }

        while (count < numberToHide && indexes.Count > 0)
        {
            int randomIndex = rand.Next(indexes.Count);
            int wordIndex = indexes[randomIndex];

            _words[wordIndex].Hide();

            indexes.RemoveAt(randomIndex);
            count++;
        }
    }

    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            display += word.GetDisplayText() + " ";
        }
        return display.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}
