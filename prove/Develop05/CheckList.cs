public class CheckList : Goal
{
    private int _amountCompleted;

    private int _limit;

    private int _bonusPoints;

    public CheckList(string name, string description, int points, int limit, int bonusPoints) : base(name, description, points) // Added limit and bonusPoints to constructor
    {
        _limit = limit;
        _bonusPoints = bonusPoints;

        _isComplete = false;
    }
    public override int RecordEvent()
    {


        _amountCompleted++;
        int pointsEarned = _points;

        if (_amountCompleted < _limit)
        {

            Console.WriteLine($"You recorded an event for goal: {_name}.");
            Console.WriteLine($"You gained {_points} points.");
            return pointsEarned;
        }

        else if (_amountCompleted == _limit)
        {
            _isComplete = true;

            //MarkComplete();
            Console.WriteLine($"Congratulations! You completed the checklist goal: {_name}!");
            Console.WriteLine($"You gained an additional {_bonusPoints} bonus points!");
            return pointsEarned + _bonusPoints;
        }
        else
        {
            return pointsEarned;
        }
    }
    public override bool GetStatus()
    {
        return _isComplete;
    }
    public void LoadProgress(int completed, bool isComplete)
    {
        _amountCompleted = completed;
        _isComplete = isComplete;
    }
    public override void DisplayStatus()
    {
        if (_isComplete == true)
            Console.WriteLine($"[x]{_name}({_description}) -- Completed {_amountCompleted}/{_limit}");
        else
            Console.WriteLine($"[]{_name} ({_description}) -- Currently completed: {_amountCompleted}/{_limit}");
    }
    public override string TieingTheBow()
    {
        return $"CheckListGoal,{_name},{_description},{_points},{_limit},{_bonusPoints},{_amountCompleted},{_isComplete}";
    }

     public int GetBonusPoints()
    {
        return _isComplete ? _bonusPoints : 0; //the tutor showed me how to do this after seeing my goalmanager class be a million lines long

    }
    public void SetCompleted(int _amount)
    {
        _amountCompleted = _amount;
    }
}