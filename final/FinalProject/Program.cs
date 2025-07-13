using System;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the workout generator!");
        Console.WriteLine("Do you have a barbell? (yes/no)");
        string barbellResponse = Console.ReadLine().ToLower();
        bool HasBarbell = false;

        if (barbellResponse == "yes")
        {
            HasBarbell = true;
        }
        else if (barbellResponse == "no")
        {
            HasBarbell = false;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            return;
        }

        Console.WriteLine("Do you have a dumbbell? (yes/no)");
        string dumbbellResponse = Console.ReadLine().ToLower();
        bool HasDumbbells = false;

        if (dumbbellResponse == "yes")
        {
            HasDumbbells = true;
        }
        else if (dumbbellResponse == "no")
        {
            HasDumbbells = false;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            return;
        }

        int durationMinutes;
        while (true)
        {
            Console.WriteLine("How many exercises do you want to do in your workout?");
            Console.WriteLine("4: Thirty minutes");
            Console.WriteLine("6: Forty-five minutes");
            Console.WriteLine("8: One hour");
            Console.WriteLine("(Please enter the number correlating with your answer.)");
            string time = Console.ReadLine();
            if (time == "4")
            {

            }
            else if (time == "6")
            {

            }
            else if (time == "8")
            {

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 4,6,or 8.");
                return;
            }
          //  durationMinutes = time;
        }
    }

    private static readonly List<List<string>> PushExercises;
    private static readonly List<List<string>> PullExercises;
    private static readonly List<List<string>> LegExercises;

    private static int GetStrengthDurationInput()
    { 
        return 0;
    }
    private static bool GetYesNoInput(string question)
    {
        return false;
    }
    private static string GetRepPreferenceInput(string workoutType) { return ""; }
    private static string GetCardioTypeInput(string question) { return ""; }
    private static int GetCardioDurationInput(string question) { return 0; }


  
}
    
