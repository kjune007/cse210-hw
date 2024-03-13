using System.Reflection.Metadata.Ecma335;

public class Passage
{
    private List<Word> _words = new List<Word>();


    public Passage()
    {
    }
    
    public void PassageAdd(Word _word)
    {
        _words.Add(_word); 
    }

    public Word GetWordFromPassage(int i)
    {
    
        Word _word = _words[i];
        return _word;
    }

    public Word ReturnPassage(int i)
    {
        return _words[i];
    }    
}