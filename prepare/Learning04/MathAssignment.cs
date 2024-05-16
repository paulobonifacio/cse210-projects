using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;
    
    // MathAssignment constructor with 4 parameters.
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
          // MathAssignment variables.
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList() 
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}