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

    public void SetFlag()
    {
        foreach (Word word in _words)
        {
            Random _r = new Random();
            int i = _r.Next(0,3);
            bool _flagValue = word.CheckFlag();
            if (_flagValue == true)
            {
                switch (i)
                {
                    case 0:
                    word.SetFlag(true);
                    break;

                    case 1:
                    word.SetFlag(true);
                    break;

                    case 2:
                    word.SetFlag(false);
                    break;
                }   
            
            }
            else
            {
                word.SetFlag(false);
            }

        }
    }    
}