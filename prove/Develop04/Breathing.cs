using System;
class Breathing : Activity
{

    private string _description = "This activity will help you to relax by walking you through breahing in and out slowly.\n Clear you mind and focus on your breathing.";
    private string _name = "breathing activity";
    protected override void runUniqueActivity()
    {
         Console.WriteLine($"{displayStartingMessage}");
        animation.wait();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

    

   
        while (DateTime.Now<endTime)
   
        {
                Animation.wait();
                Console.Write("Breath in...");
                //how to show the countdown
                Console.Write("Breath out");

                // breathIn();
                // breathOut();

            }
        


    }

