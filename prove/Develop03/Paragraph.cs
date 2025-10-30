using System;

class Paragraph
{
    private Reference _reference;
    private List<Word> _words;

    private static readonly Random _random = new Random();

    public Paragraph(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(' ');
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }


    public void HideRandomWords(int numberToHide)
    {
        List<int> availableIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                availableIndexes.Add(i);
            }
        }

        if (availableIndexes.Count == 0)
        {
            return;
        }

        int toHide = Math.Min(numberToHide, availableIndexes.Count);

        for (int i = 0; i < toHide; i++)
        {
            int pickIndex = _random.Next(availableIndexes.Count);
            int wordIndex = availableIndexes[pickIndex];

            _words[wordIndex].Hide();

            availableIndexes.RemoveAt(pickIndex);
        }

    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "-";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }


}   

