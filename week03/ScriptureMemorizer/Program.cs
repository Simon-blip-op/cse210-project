using System;
using System.IO;

// Start of your program
class Program
{
    static void Main(string[] args)
    {
        // Load a random scripture from the file
        Scripture scripture = LoadRandomScriptureFromFile("scriptures.txt");

        // Keep showing scripture until all words are hidden
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear(); // Clears the screen
            scripture.Display(); // Shows the reference and words

            Console.WriteLine("\nPress ENTER to hide more words or type 'quit' to end:");
            string input = Console.ReadLine();

            // Exit if the user types "quit"
            if (input.ToLower() == "quit")
                return;

            scripture.HideRandomWords(); // Hide 3 more random words
        }

        Console.Clear(); // Final clear
        scripture.Display(); // Show fully hidden verse
        Console.WriteLine("\nAll words are hidden. Program ended.");
    }

    // This method reads a random line from scriptures.txt and creates a Scripture object
    static Scripture LoadRandomScriptureFromFile(string filePath)
    {
        var lines = File.ReadAllLines(filePath); // Read all lines from file
        var random = new Random();
        var randomLine = lines[random.Next(lines.Length)]; // Pick one line randomly

        // Each line should look like: Book|Chapter|StartVerse|EndVerse|Text
        string[] parts = randomLine.Split('|');

        // Get book and numbers from the line
        string book = parts[0];
        int chapter = int.Parse(parts[1]);
        int startVerse = int.Parse(parts[2]);
        int endVerse = int.Parse(parts[3]);
        string text = parts[4];

        // Create reference and scripture objects
        Reference reference = new Reference(book, chapter, startVerse, endVerse);
        Scripture scripture = new Scripture(reference, text);
        return scripture;
    }
}
