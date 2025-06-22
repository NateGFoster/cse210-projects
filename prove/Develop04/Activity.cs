public class Activity
{
   
    protected string _description;
    protected string _lastMessage;
     protected string _name;
    protected int _duration;


    public Activity(string name, string description)
     {
        _name = name;
        _description = description;
     }
private Animation animation = new Animation();
    public void displayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine($" {_description} ");
        getDuration();
        Console.WriteLine("Get Ready!");
        animation.showSpinner(4);
    }
    public void getDuration()
    {
        //runUniqueActivity()
        // int duration = getSessionDuration();
        int duration = 0;

        do // do this while condition
        {
            Console.WriteLine("How long, in seconds, would you like for your session to be?");
            string readResponse = Console.ReadLine();
            if (!int.TryParse(readResponse, out duration)) // if you successfully parse the integer turning it into a string then send it to response

            {
                Console.WriteLine("Invalid input.");

            }
            //while (duration <= 0) ; //while condition

        } while (duration <= 0);
         { _duration = duration; }


    }
    public void displayEndingMessage(string _name, string _description)
    {
       
        animation.showSpinner(3);
        Console.WriteLine("Good job"); 
        Console.WriteLine($"You completed the {_name} activity.");
        Console.WriteLine($"Duration: {_duration} seconds\n");
     }
}

