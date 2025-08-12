using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Simon Banda", "Computer Science - Software Developer"); 

        string summary = myAssignment.GetSummary();
        Console.WriteLine(summary);

        MathAssignment math = new MathAssignment("Simon Banda", "Fractions", "7.5", "20-24"); 
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment("Simon Banda", "world History", "The rise and fall of Ancient Civilizations");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());

    }
}