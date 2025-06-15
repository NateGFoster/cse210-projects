class Activity
{
    string _firstMessage;
    string _description;
    string _lastMessage;
    string _pause;
    string _loader;
    string _name;
    int _duration;
    
private Animation animation = new Animation();
    public void displayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine($"Welcome to the {_description} activity");
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
            if (!int.TryParse(Console.ReadLine(), out duration)) // if you successfully parse the integer turning it into a string then send it to response

            {
                Console.WriteLine("Invalid input.");

            }
            //while (duration <= 0) ; //while condition
            //{ _duration = duration; }
        } while (duration <= 0);


    }
    public void displayEndingMessage()
    {
        Console.WriteLine("Get Ready...");
        //Animation animation = new Animation();
        animation.showSpinner(3);
        Console.WriteLine("Good job"); // this probably is in the wrong place
    }
}

//COUNTDOWN AND SPINNER

      
            
        

    //     endActivity()
    // }
