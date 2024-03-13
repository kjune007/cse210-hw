public class Word
{
    public string _word;

    public Word()
    {
    }

    public string GetWord(bool _stringVarable)
    {
        if (_stringVarable == true)
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