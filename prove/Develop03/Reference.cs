using System;

class Reference
{
    // Private fields to store book, chapter, and verse
    private string _book, _chapter, _verse;
    // Initialize reference with book, chapter, and verse
    
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    // Convert reference to string
    public string toString()
    {
        // Format the reference string with book, chapter, and verse
        return string.Format("{0} {1}:{2}", _book, _chapter, _verse);
    }
}
