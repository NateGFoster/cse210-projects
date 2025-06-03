class Reference
{
    private string _book;

    private int _chapter;


    private string _verse;


    public Reference(string totalReference)
    {
        string[] partsOfScripture = totalReference.Split(' ');
        string chapterAndVerse = partsOfScripture.Last();

        _book = string.Join(" ", partsOfScripture.Take(partsOfScripture.Length - 1));

        var chapterVerseSplit = chapterAndVerse.Split(':');

        _chapter = int.Parse(chapterVerseSplit[0]); //this is to refer to the first thing in my array cuz 0 is the first number for computers

        _verse = chapterVerseSplit[1];
    }

    public Reference(string book, int chapter, string verse) //this is my 2nd constructor to seprate the parts
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public string Display()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}
//attributes the two constructions and display the reference