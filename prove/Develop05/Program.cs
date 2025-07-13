using System;
public class Program
{

    static void Main(string[] args)
    {
        int choice;
         GoalManager goalManager = new GoalManager(); 



        do
        {
            goalManager.DisplayPlayerInfo(); 

            Console.WriteLine("Menu Options:\n 1.Create New Goal \n 2. List Goals \n 3. Save Goals\n 4. Load Goals \n 5. Record Event \n 6.Delete Goal \n 7.Quit \n Please Select a Choice From the Menu:");
            string response = Console.ReadLine(); 
            choice = int.Parse(response); 
 
            switch (choice)
            {

                case 1:

                    goalManager.CreateGoal();
                    break;


                case 2:
                    goalManager.ListGoals();
                    break;

                case 3:
                    Console.Write("What is the filename for the goal file? ");
                    string saveFileName = Console.ReadLine();
                    goalManager.SaveGoals(saveFileName);

                    break;
                case 4:
                    Console.Write("What is the filename for the goal file? ");
                    string loadFileName = Console.ReadLine();
                    goalManager.LoadGoal(loadFileName);

                    break;

                case 5:
                    goalManager.RecordGoalEvent();
                    break;
                case 6:
                    goalManager.DeleteGoal();
                    break;

                case 7:
                    Console.WriteLine("Goodbye Now Goodbye!");
                    break;


                default:
                    Console.WriteLine("Invailid Answer");

                    break;
            }

        }
        while (choice != 6);
    }
}