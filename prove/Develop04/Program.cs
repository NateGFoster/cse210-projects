using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:\n 1.Start Breathing Activity \n 2. Start Reflecting Activity \n 3. Start Listing Activity \n 4. Quit \n Please Select a Choice From the Menu:");
        // private member variables
        //     _name
        //     _description

        switch (response)
                {
                    case 1:
                        runBreathActivity
                        break;
                    case 2:
                        runReflectingActivity
                        break;
                    case 3:
                        runListingActivty
                        break;
                    case 4:
                        quit
                        break;
                    default:
                        Console.WriteLine("Invailid Answer");

                        break;

                }

    }
    
}