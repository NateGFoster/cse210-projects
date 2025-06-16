using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:\n 1.Start Breathing Activity \n 2. Start Reflecting Activity \n 3. Start Listing Activity \n 4. Quit \n Please Select a Choice From the Menu:");
        // private member variables
        //     _name
        //     _description
        //string response = "";
        int choice;
        do
        {
            string response = Console.ReadLine(); // Need to get user input
             choice = int.Parse(response); // Convert string to int for switch



            Breathing BreathingActivity = new Breathing(); // constructers need to be out of the switch
            Reflecting ReflectingActivity = new Reflecting();
            Listing ListingActivity = new Listing();

            switch (choice)
            {

                case 1:
                    {
                        BreathingActivity.RunBreathingActivity();
                        break;
                    }

                case 2:
                    //ReflectingActivity.RunReflectingActivity();
                    new Reflecting().RunReflectingActivity();
                    break;

                case 3:

                    ListingActivity.RunListingActivity();
                    break;

                case 4:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invailid Answer");

                    break;

            }

        }
        while (choice != 4);
        }
    
}
