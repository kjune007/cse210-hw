public class Scripture
{
    private List<string> _scripture = new List<string>()
    {
        "Trust", "in", "the", "LORD", "with", "all", "thine", "heart;", "and", "lean", "not", "unto", "thine", "own", "understanding.",
        "In", "all", "thy", "ways", "acknowledge", "him,", "and", "he", "shall", "direct", "thy", "paths"
    };

    public List<string> GetScripture()
    {
        return _scripture;
    }

}