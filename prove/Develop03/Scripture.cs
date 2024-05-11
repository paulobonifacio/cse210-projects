using System;

class Scripture
{
    // Private fields to store scripture text and reference
    private string _scriptureText;
    private Reference _scriptureReference;
    
    // Constructor to initialize scripture with reference and text
    public Scripture(Reference scriptureReference, string scriptureText)
    {
        _scriptureReference = scriptureReference;
        _scriptureText = scriptureText;
    }
    // Method to convert scripture to string
    public string toString()
    {
        // Return the scripture text
        return string.Format("{0}", _scriptureText);
    }
}
