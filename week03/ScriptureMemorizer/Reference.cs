using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public void Display()
    {
        Console.Write($"{_book} {_chapter}:{_startVerse}");
        if (_endVerse != _startVerse)
        {
            Console.Write($"-{_endVerse}");
        }
        Console.WriteLine();
    }
    
}