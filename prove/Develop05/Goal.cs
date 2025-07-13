public abstract class Goal//parent class
{
    protected string _name;
     protected string _description;
     // protected string _completed;
    protected bool _isComplete;
    protected int _points;



    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false; //set to be false so I can then mark it true when completed
    }

    public bool IsComplete()
    {
        return _isComplete;
    }
 

    public int GetPoints() //nice getter
    {
        return _points;
    }

    public virtual int RecordEvent()
    {
        //return _isComplete;
        return 0; 
    }
    public virtual bool GetStatus()
    {
        return _isComplete;
    }
    public string GetDescription() //getter
    {
        return _description;
    }
    public string GetName()
    {
        return _name;
    }
        public abstract void DisplayStatus(); 
    public abstract string TieingTheBow();

}