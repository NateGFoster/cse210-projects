using System;
public class Program
{

    static void Main(string[] args)
    {
        int choice;



        do
        {
            Console.WriteLine("Menu Options:\n 1.Create New Goal \n 2. List Goals \n 3. Save Goals\n 4. Load Goals \n 5. Record Event \n 6.Quit \n Please Select a Choice From the Menu:");
            string response = Console.ReadLine(); // Need to get user input
            choice = int.Parse(response); // Convert string to int for switch

            switch (choice)
            {

                case 1:

                    GoalManager.CreateGoal();
                    break;


                case 2:
                    GoalManager.ListGoals();
                    break;

                case 3:


                    break;
                case 4:


                    break;

                case 5:

                    break;

                case 6:

                    break;


                default:
                    Console.WriteLine("Invailid Answer");

                    break;
            }

        }
        while (choice != 6);
    }
}