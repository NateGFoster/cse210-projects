public class CheckList : Goal
{
    private int _amountCompleted;

    private int _limit;

    private int _bonusPoints;
    
    int amountCompleted = 0;
    public CheckList(string name, string description, int points) : base(name, description, points)
    {
        //Constructors do not return anything
    }
   // bool _isComplete = false;

    public void CheckListGoal(int points, int limit, int bonusPoints) //: base(name, description, points)//string name, string description,
    {

        // int _amount = amount;
        _limit = limit;
        _bonusPoints = bonusPoints;
    }
// do a csv i need set the goal types in line from line 10 probelmly to line 1 


    public override bool RecordEvent()
    {


        _amountCompleted++;
        if (_amountCompleted < _limit)
        {

            Console.WriteLine($"You recorded an event for goal: {_name}.");
            Console.WriteLine($"You gained {_points} points.");
            return false;
        }

        else if (_amountCompleted == _limit)
        {
            _isComplete = true;

            //MarkComplete();
            Console.WriteLine($"Congratulations! You completed the checklist goal: {_name}!");
            Console.WriteLine($"You gained an additional {_bonusPoints} bonus points!");
            return true;
        }
        else
        {
            return false;
        }
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