public class Eternal : Goal
{
    public Eternal(string name, string description, int points) : base(name, description, points)
    {
        //Constructors do not return anything
     }

    public override bool GetStatus()
    {
        return false;
    }
      public override void DisplayStatus()
    {
        Console.WriteLine($"{_name} ({_description})"); // Eternal goals are always displayed as incomplete
    }
    public override int RecordEvent()
    {
        Console.WriteLine($"You recorded an event for eternal goal: {_name}.");
        Console.WriteLine($"You gained {_points} points.");
        return _points;
    } 
    public override string TieingTheBow()
    {
        return $"EternalGoal,{_name},{_description},{_points},{false}";
    }

}