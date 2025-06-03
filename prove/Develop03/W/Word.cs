using System.Runtime.CompilerServices;

class Word
{
    private string _word;
    private bool _switch;

    public string Hide()
    {
        string saving = "";
        int length = _word.Length;
        for (int i = 0; i < length; i++)
            saving += "_";
        return saving;
    }
    public bool GetSwitch()
    {
        return _switch;
    }
    public Word(string word)
    {
        _word = word;
        _switch = false;

        //foreach word in words word.display()}
    }
    public void Hider()
    {
        _switch = true;

    }
    public void Shower()
    {
        _switch = false;

    }

    public string Display()
    {
        if (_switch == true)
        {
            return Hide();
        }
        else  
        {
            return _word;
        }

    }
   
}
