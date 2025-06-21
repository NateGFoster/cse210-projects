using System;

class Program
{
    static void Main(string[] args)
    
    {
         Dictionary<string, int> activityCount = new Dictionary<string, int>();
        activityCount["Breathing Activity"] = 0;
        activityCount["Reflecting Activity"] = 0;
        activityCount["Listing Activity"] = 0;

        // private member variables
        //     _name
        //     _description
        //string response = "";

        int choice;
        do
        {
            Console.WriteLine("Menu Options:\n 1.Start Breathing Activity \n 2. Start Reflecting Activity \n 3. Start Listing Activity\n  4. View Activity Log; \n 5. Quit \n Please Select a Choice From the Menu:");
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
                        activityCount["Breathing Activity"]++;
                        break;
                    }

                case 2:
                    //ReflectingActivity.RunReflectingActivity();
                    new Reflecting().RunReflectingActivity();
                    activityCount["Reflecting Activity"]++;
                    break;

                case 3:

                    ListingActivity.RunListingActivity();
                    activityCount["Listing Activity"]++;
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
