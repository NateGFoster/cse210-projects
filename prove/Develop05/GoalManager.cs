using System;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    private int _totalPoints = 0;

    private List<Simple> _simpleGoals = new List<Simple>();
    private List<Eternal> _eternalGoals = new List<Eternal>();
    private List<CheckList> _checklistGoals = new List<CheckList>();
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_totalPoints} points.\n");
    } 
    public void ListGoals()
    {
        //Console.WriteLine($"Simple Goals: {_simpleGoals}, Eternal Goals: {_eternalGoals}, Checklist Goals: {_checklistGoals}");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to display yet.");
            return;
        }

        Console.WriteLine("Your Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].DisplayStatus();
        }

    }
   
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: \n 1.Simple Goal \n 2. Eternal Goal \n 3. Checklist Goal");
        string response = Console.ReadLine();

        int choice = int.Parse(response);


        Console.WriteLine("What do you want to name your goal?");
        string freeResponse = Console.ReadLine();
        Console.WriteLine("What is the description of your goal?");
        string descriptionResponse = Console.ReadLine();
        Console.WriteLine("How many points is the goal worth?");
        int Points = int.Parse(Console.ReadLine());


        switch (choice)
        {

            case 1:
                Simple simple = new Simple(freeResponse, descriptionResponse, Points);
                _goals.Add(simple); // Add to the main _goals list
                _simpleGoals.Add(simple);
                Console.WriteLine("Simple Goal created!");
                break;


            case 2:
                Eternal eternal = new Eternal(freeResponse, descriptionResponse, Points);
                _goals.Add(eternal);
                _eternalGoals.Add(eternal);
                Console.WriteLine("Eternal Goal created!");
                break;

            case 3:
                
                Console.WriteLine("How many times does this goal need to be completed for a bonus?");
                if (!int.TryParse(Console.ReadLine(), out int limit))
                {
                    Console.WriteLine("Invalid input for limit. Please enter a number.");
                    return;
                }
                Console.WriteLine("What is the bonus points for completing it?");
                if (!int.TryParse(Console.ReadLine(), out int bonusPoints))
                {
                    Console.WriteLine("Invalid input for bonus points. Please enter a number.");
                    return;
                }
                CheckList checklist = new CheckList(freeResponse, descriptionResponse, Points, limit, bonusPoints);
                _goals.Add(checklist);
                _checklistGoals.Add(checklist); // Add to specific list too
                Console.WriteLine("Checklist Goal created!");
                break;
            default:
                Console.WriteLine("Choose an actual choice.");
                break; // Added break to default case 

        }

    }
   
    

   public void DeleteGoal() // this is my stretch challenge
{
    if (_goals.Count == 0)
    {
        Console.WriteLine("There are no goals to delete.");
        return;
    }

    Console.WriteLine("Select a goal to delete:");
    ListGoals();
    Console.Write("Enter the goal number: ");

    string input = Console.ReadLine();
    int index;
    bool isNumber = int.TryParse(input, out index);

    if (isNumber)
    {
        if (index > 0)
        {
            if (index <= _goals.Count)
            {
                Goal goalToRemove = _goals[index - 1];
                _goals.Remove(goalToRemove);

                foreach (Simple s in _simpleGoals)
                  {
                    if (s == goalToRemove)
                    {
                        _simpleGoals.Remove(s);
                         break;
                    }
                  }

                foreach (Eternal e in _eternalGoals)
                {
                    if (e == goalToRemove)
                      {
                        _eternalGoals.Remove(e);
                        break;
                      }
                }

                foreach (CheckList c in _checklistGoals)
                {
                    if (c == goalToRemove)
                     {
                        _checklistGoals.Remove(c);
                        break;
                     }
                }
            }
        }
    }
}


    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalPoints);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.TieingTheBow());
            }
        }
        Console.WriteLine($"Goals saved to {filename}");
    }

   
    public void LoadGoal(string location) // going to be coompletly h0onest I used  AI to do this one method because I have been stuck on it for a while but i can put a description of what everthing does for you
    {
        string[] lines = File.ReadAllLines(location); //reads all the lines from the chosen file
        _goals.Clear(); // This clears existing goals before loading
        _simpleGoals.Clear();
        _eternalGoals.Clear();
        _checklistGoals.Clear();

        _totalPoints = int.Parse(lines[0]); // deals with the points parses to lines

        for (int i = 1; i < lines.Length; i++) // for loops through each line in the file 
        {
            string[] parts = lines[i].Split(',');
            string goalType = parts[0];          // this tells you what type of goal it is 

            if (goalType == "SimpleGoal") // we need this for it to load right
            {
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                Simple simple = new Simple(name, desc, points);
                if (isComplete) simple.RecordEvent(); // if the goal is already done then it is marked as complete
                _goals.Add(simple);         //for adding new goals in simple
                _simpleGoals.Add(simple);
            }
            else if (goalType == "EternalGoal")  // this deals with the never ending goals woooowwww
            {
                string name = parts[1];      //this eternal goal type will have more criteria and was the hardest to code. 
                string desc = parts[2];
                int points = int.Parse(parts[3]);

                Eternal eternal = new Eternal(name, desc, points);
                _goals.Add(eternal);
                _eternalGoals.Add(eternal);
            }
            else if (goalType == "CheckListGoal")
            {
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);
                int limit = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int completed = int.Parse(parts[6]);
                bool isComplete = bool.Parse(parts[7]);

                CheckList checklist = new CheckList(name, desc, points, limit, bonus);
                checklist.SetCompleted(completed);
                _goals.Add(checklist); // this adds the goal to the list and is pretty straightforward this is my level hahaha
                 _checklistGoals.Add(checklist);
            }
        }

        Console.WriteLine("Goals are all good to go.");
    }

    public void RecordGoalEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You don't have any goals in your life.");
            return;
        }

        Console.WriteLine("Your goals:");
        ListGoals();

        Console.Write("Which goal did you finish? (Enter the number): ");
        string response = Console.ReadLine();

        if (int.TryParse(response, out int goalIndex))
        {



            Goal selectedGoal = _goals[goalIndex-1];


            int pointsEarned = selectedGoal.RecordEvent();
            _totalPoints += pointsEarned;

            Console.WriteLine($"Congratulations! You earned {pointsEarned} points for '{selectedGoal.GetName()}'.");
            Console.WriteLine($"You now have {_totalPoints} points.");
            if (selectedGoal is CheckList)
            {
                CheckList checklistGoal = (CheckList)selectedGoal;
                if (checklistGoal.GetStatus())
                {
                    Console.WriteLine($"You also earned a bonus of {checklistGoal.GetBonusPoints()} for completing the checklist!");
                }
            }
        }
    }
}


