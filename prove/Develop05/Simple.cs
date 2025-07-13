public class Simple : Goal
{

 
    public Simple(string name, string description, int points) : base(name, description, points)
    {
      

    }
    public override int RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"You recorded an event for simple goal: {_name}.");
        Console.WriteLine($"You gained {_points} points.");
        return _points;
    }
    public override bool GetStatus()
    {
         return _isComplete;
    } 
    public override void DisplayStatus()
    {
        if (_isComplete == true)
            Console.WriteLine($"[x]{_name} {_description}");
        else
            Console.WriteLine($"[]{_name} {_description}");

    }
    public override string TieingTheBow()
    {
        return $"SimpleGoal,{_name},{_description},{_points},{_isComplete}";
    }
} 