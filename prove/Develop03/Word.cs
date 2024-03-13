public class Word
{
    private string _word;
    private bool _flag;

    public Word()
    {
    }

    public Word(string _setword, bool _setflag)
    {
        _word = _setword;
        _flag = _setflag;
    }

    public bool CheckFlag()
    {
        return _flag;
    }
    public string GetWord()
    {
        if (_flag == true)
        {   
            return _word;
        }
        else
        {
            int numberOfLetters = _word.Length;
            string empty = "_";
            string emptyWord = String.Concat(Enumerable.Repeat(empty, numberOfLetters));
            return emptyWord;
        }
    }  
}