using System;
public class Breathing:Activity
{

    //private string _description = "This activity will help you to relax by walking you through breathing in and out slowly.\n Clear your mind and focus on your breathing.";
    //private string _name = "breathing activity";
    private Animation animation = new Animation();

    public Breathing() : base("breathing activity", "This activity will help you to relax by walking you through breathing in and out slowly.\n Clear your mind and focus on your breathing.")
    {
    
 }
    public void RunBreathingActivity()
    {
         displayStartingMessage();

        animation.showSpinner(4);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);




        while (DateTime.Now < endTime)

        {
            animation.showSpinner(2);
            Console.Write("Breathe in...\n");
            //how to show the countdown
            animation.showCountDown(4); // class.the_thing_you_want
            Console.Write("Breathe out...\n");
            animation.showCountDown(6);

        //     if (DateTime.Now >= endTime)
        //    //animation.showSpinner(2);
        //         break;

            // breathIn();
            // breathOut();

        }
        displayEndingMessage(_name, _description);
         animation.showSpinner(2);
    }

    }

