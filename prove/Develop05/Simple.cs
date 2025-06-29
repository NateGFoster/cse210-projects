public class Simple : Goal 
{
    
    private bool _isComplete = false;
    public Simple(string name, string description, int points) : base(name, description, points)
    {
        // _name = name; this is redundant already in goal class

    }
    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }
    public override bool GetStatus()
    {
        return _isComplete; 
    }
    public void DisplayStatus()
    {
         if (_isComplete == true)
            Console.WriteLine($"[x]{_name}");
        else
            Console.WriteLine($"[]{_name}");
    }
} 