using System;

class ScriptureMemo
{
    private Scripture _scripture;
    // List to hold individual words of scripture text
    private List<string> _scriptureTextList;
    // Counter the total words removed
    private int _totalWordsRemoved = 0;

    // Constructor to initialize ScriptureMemo with a Scripture object
    public ScriptureMemo(Scripture scripture)
    {
        _scripture = scripture;
        _scriptureTextList = new List<string>();
        convertTextToList(); // Method to convert scripture text to list of words
    }

    // Convert scripture text to list of words
    private void convertTextToList()
    {
        _scriptureTextList = _scripture.toString().Split(" ").ToList();
    }

    // Remove words from scripture text
    public void removeWordsFromText()
    {
        int numWordsToRemove = 3;
        int wordsRemoved = 0;

        do
        { 
            // Generate a random index to remove a word
            int rndIndex = new Random().Next(0, _scriptureTextList.Count());
            if (_scriptureTextList[rndIndex].Contains('_') == false)
            {
                 // Replace the word with underscores to indicate it's been removed
                _scriptureTextList[rndIndex] = new string('_', _scriptureTextList[rndIndex].Length);
                wordsRemoved++;
                _totalWordsRemoved++;

                if ((_scriptureTextList.Count() - numWordsToRemove) <= _totalWordsRemoved && _totalWordsRemoved < (_scriptureTextList.Count() + 1))
                {
                    wordsRemoved = 3;
                }
            }

        } while (wordsRemoved != numWordsToRemove);
    }

    public string toString()
    {
        return string.Join(" ", _scriptureTextList);
    }

    // Method to check if there are still words left to be memorized
    public bool hasWordsLeft()
    {
        bool retValue = false;

        foreach (string word in _scriptureTextList)
        {
            if (word.Contains("_") == false)
            {
                retValue = true;
                break;
            }
        }
        return retValue;
    }
}