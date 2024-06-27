using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string reference, string text)
    {
        _reference = ParseReference(reference);
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    private Reference ParseReference(string reference)
    {

         string[] parts = reference.Split(' ');
        string book = parts[0];
        string[] chapterAndVerses = parts[1].Split(':');
        int chapter = int.Parse(chapterAndVerses[0]);
        string[] verses = chapterAndVerses[1].Split('-');

        if (verses.Length == 1)
        {
            int verse = int.Parse(verses[0]);
            return new Reference(book, chapter, verse);
        }
        else
        {
            int startVerse = int.Parse(verses[0]);
            int endVerse = int.Parse(verses[1]);
            return new Reference(book, chapter, startVerse, endVerse);
        }
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int hiddenWords = 0;

        while (hiddenWords < count)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenWords++;
            }
        }
    }

    public string GetDisplayText()
    {
        string text = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()}\n{text}";
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}