using System;
public class GoalManager
{
    /* private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        };
        */

    public void ListGoals()
    {
        Console.WriteLine($"Simple Goals: {_simpleGoals}, Eternal Goals: {_eternalGoals}, Checklist Goals: {_checklistGoals}");
    }
    private List<Goal> _simpleGoals = new List<Goal>
    {

    };

    private List<Goal> _eternalGoals = new List<Goal>
    {

    };
    private List<Goal> _checklistGoals = new List<Goal>
    {

    };







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
                //responseSimple = 0;
                //responseSimple.Add;
                _simpleGoals.Add(simple);


                break;


            case 2:
                Eternal eternal = new Eternal(freeResponse, descriptionResponse, Points);
                //responseEternal = 0;
                //responseEternal.Add;
                _eternalGoals.Add(eternal);

                break;

            case 3:
                CheckList checklist = new CheckList(freeResponse, descriptionResponse, Points);
               
                _checklistGoals.Add(checklist);

                break;
                // you could also just say is this a simple goal if yes then print if this way dont work too good down the road you would use casting for that
        }
        
    }
    public void DeleteGoal() //stretch
    {
        //just removie it from the list but you have to know where in the list
    }
    public void SaveEntries(string location)
    {
        foreach (Entry entry in entries)
        {
            using (StreamWriter sw = new StreamWriter(location))
            { sw.WriteLine($"{entry.date}\n{entry.question}\n {entry.answer}"); }

        }
    }

    public void LoadGoal(string location)
    {

        int i = 0;
        Entry entry = null;
        foreach (string Line in File.ReadAllLines(location))
        {
            if (i % 3 == 0)
            {
                entry = new Entry();
                entry.date = Line;
            }
            if (i % 3 == 1)
            {
                entry.question = Line;
            }
            if (i % 3 == 2)
            {

                entry.answer = Line;
                entries.Add(entry); // adds the complete entry to the list of entries
            }
            i++;

        }
    }
}