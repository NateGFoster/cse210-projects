public class Eternal : Goal
{
    public Eternal(string name, string description, int points) : base(name, description, points)
    {
        //Constructors do not return anything
    }

    

     public override string GetGoalRepresentation()
    {
        // Format for saving/loading EternalGoal specific data
        return $"EternalGoal:{_name},{_description},{_points}";
    }
    public override bool GetStatus()
    {
        return false;
    }
}