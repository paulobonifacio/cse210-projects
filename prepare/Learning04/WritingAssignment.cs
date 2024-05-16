using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        // Set the variables.
        _title = title;
    }

    public string GetWritingInfo()
    {
        // Call the getter _studentName because it is private in the main class.
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}