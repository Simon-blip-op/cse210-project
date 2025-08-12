using System; // This line allows us to use basic built-in C# features like Console

// Define a class named Assignment
public class Assignment
{
    // These are private fields that store the student's name and the topic of the assignment
    private string _studentName;
    private string _topic;

    // Constructor: This method runs when we create a new Assignment object
    // It takes two parameters: the student's name and the topic, and stores them in the private fields
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method that returns a short summary of the assignment in the format: "Student Name - Topic"
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Method that returns just the student's name
    public string GetStudentName()
    {
        return _studentName;
    }
}  