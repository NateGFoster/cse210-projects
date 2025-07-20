// using System;
// public class Program
// {


//     //PUSH
//     public static readonly List<string> PushExercisesBodyweight = new List<string>
// {
//     "Push-ups", "Plank", "Plank-to-Pushup", "Dips", "Pike Push-ups", "Archer Push-ups",
//     "Pseudo Planche Push-ups", "Wall Push-ups"
// };
//     public static readonly List<string> PushExercisesDumbbell = new List<string> // public makes it avaliable in everywhere static means I dont need to return or change it and is not an object readonly just means it cannot be reassinged  but it can be modified
// {
//     "Dumbbell Press", "Dumbbell Fly", "Dumbbell Shoulder Press", "Dumbbell Arnold Press",
//     "Dumbbell Incline Press", "Dumbbell Triceps Extension", "Dumbbell Lateral Raises"
// };
//     public static readonly List<string> PushExercisesBarbell = new List<string>
// {
//     "Bench Press", "Overhead Press", "Incline Bench Press", "Close-Grip Bench Press",
//     "Barbell Shoulder Press", "Landmine Press"      // note: I had Chat make up these lists of excersices because thinking of 20 exercises for chest day is not fun.
// };

//     // PULL
//     public static readonly List<string> PullExercisesBodyweight = new List<string>
// {
//     "Pull-Ups", "Chin-Ups", "Superman Pulls", "Reverse Snow Angels", "Towel Rows",
//     "Wall Pulls", "Prone Arm Raises"
// };
//     public static readonly List<string> PullExercisesDumbbell = new List<string>
// {
//     "Bent-over Rows", "Single-Arm Dumbbell Row", "Reverse Flys",
//     "Chest-Supported Rows", "Dumbbell Deadlift"
// };
//     public static readonly List<string> PullExercisesBarbell = new List<string>
// {
//     "Deadlift", "Pendlay Row", "Barbell Row", "Snatch-Grip Deadlift", "Rack Pulls",
//     "Seal Row"
// };


//     //LEG
//     public static readonly List<string> LegExercisesBodyweight = new List<string>
// {
//     "Burpees", "Jump Squats", "Lunges", "Bodyweight Squats",
//     "Wall Sit", "Step-Ups", "Glute Bridges", "Pistol Squats"
// };
//     public static readonly List<string> LegExercisesDumbbell = new List<string>
// {
//     "Goblet Squats", "Dumbbell Lunges", "Dumbbell Step-Ups",
//     "Dumbbell Romanian Deadlifts", "Dumbbell Bulgarian Split Squat",
//     "Dumbbell Calf Raises"
// };
//     public static readonly List<string> LegExercisesBarbell = new List<string>
// {
//     "Squats", "Front Squats", "Bulgarian Split Squat", "Deadlifts",
//     "Romanian Deadlifts", "Barbell Calf Raises", "Good Mornings",
//     "Hip Thrusts"
// };




//     static void Main(string[] args)
//     {
//         Console.WriteLine("Welcome to the workout generator!");
//         Console.WriteLine("Do you have a barbell? (yes/no)");
//         string barbellResponse = Console.ReadLine().ToLower();
//         bool HasBarbell = false;

        

//         if (barbellResponse == "yes")
//         {
//             HasBarbell = true;
//         }
//         else if (barbellResponse == "no")
//         {
//             HasBarbell = false;
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
//             return;
//         }

//         Console.WriteLine("Do you have a dumbbell? (yes/no)");
//         string dumbbellResponse = Console.ReadLine().ToLower();
//         bool HasDumbbells = false;

//         if (dumbbellResponse == "yes")
//         {
//             HasDumbbells = true;
//         }
//         else if (dumbbellResponse == "no")
//         {
//             HasDumbbells = false;
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
//             return;
//         }
//         string repPreference = GetRepPreferenceInput("What is your rep preference for strength workouts? (Low, Medium, High)");


//         int durationMinutes;
//         while (true)
//         {
//             Console.WriteLine("How many exercises do you want to do in your workout?");
//             Console.WriteLine("4: Thirty minutes");
//             Console.WriteLine("6: Forty-five minutes");
//             Console.WriteLine("8: One hour");
//             Console.WriteLine("(Please enter the number correlating with your answer.)");
//             string time = Console.ReadLine();
//             if (NumberofExercises == "4")
//             {

//             }
//             else if (NumberofExercises == "6")
//             {

//             }
//             else if (NumberofExercises == "8")
//             {

//             }
//             else
//             {
//                 Console.WriteLine("Invalid input. Please enter 4,6,or 8.");
//                 return;
//             }
//             //  durationMinutes = time;
//             //string repPreference = GetRepPreferenceInput("What is your rep preference? (Low, Medium, High)");
//         }
//     }

//     // private static readonly List<List<string>> PushExercises;
//     // private static readonly List<List<string>> PullExercises;
//     // private static readonly List<List<string>> LegExercises;
//     // public static readonly List<string> RunningCardio = new List<string> { "Outdoor Run", "Treadmill Jog" };
//     // public static readonly List<string> CyclingCardio = new List<string> { "Outdoor Bike Ride", "Stationary Bike" };
//     // public static readonly List<string> SprintCardio = new List<string> { "Running Sprints" };

//     WorkoutGenerator generator = new WorkoutGenerator(userPreference);

//     private static bool GetYesNoInput(string question)
//     {
//         while (true)
//         {
//             Console.WriteLine(question);
//             string response = Console.ReadLine().ToLower();
//             if (response == "yes")
//             {
//                 return true;
//             }
//             else // Simplified to single else, assuming "no" is the only other valid response for boolean
//             {
//                 if (response == "no") // Nested if for "no"
//                 {
//                     return false;
//                 }
//                 else
//                 {
//                     Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
//                 }
//             }
//         }
//           string cardioType = null;
//         int cardioDurationMinutes = 0;

//         if (wantsCardio)
//         {
//             cardioType = GetCardioTypeInput();
//             cardioDurationMinutes = GetCardioDurationInput();
//         }
//     }
    
//     private static string GetRepPreferenceInput(string question)
//     {
//         while (true)
//         {
//             Console.WriteLine(question);
//             Console.WriteLine("Options: Low, Medium, High");
//             string response = Console.ReadLine().ToLower();
//             if (response == "low")
//             {
//                 return "Low"; // Return capitalized for consistency
//             }
//             else
//             {
//                 if (response == "medium")
//                 {
//                     return "Medium"; // Return capitalized for consistency
//                 }
//                 else
//                 {
//                     if (response == "high")
//                     {
//                         return "High"; // Return capitalized for consistency
//                     }
//                     else
//                     {
//                         Console.WriteLine("Invalid input. Please enter 'Low', 'Medium', or 'High'.");
//                     }
//                 }
//             }
//         }
//     }
//     //private static string GetCardioTypeInput(string question) { return ""; }
//     //private static int GetCardioDurationInput(string question) { return 0; }
//      private static int GetNumberOfExercisesInput()
//     {
//         while (true)
//         {
//             Console.WriteLine("How many exercises do you want to do in your workout?");
//             Console.WriteLine("4: Thirty minutes");
//             Console.WriteLine("6: Forty-five minutes");
//             Console.WriteLine("8: One hour");
//             Console.WriteLine("(Please enter the number correlating with your answer.)");
//             string input = Console.ReadLine();
//             int numExercises;
//             if (int.TryParse(input, out numExercises)) // Using TryParse for safer conversion
//             {
//                 if (numExercises == 4)
//                 {
//                     return 4;
//                 }
//                 else
//                 {
//                     if (numExercises == 6)
//                     {
//                         return 6;
//                     }
//                     else
//                     {
//                         if (numExercises == 8)
//                         {
//                             return 8;
//                         }
//                         else
//                         {
//                             Console.WriteLine("Invalid input. Please enter 4, 6, or 8.");
//                         }
//                     }
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Invalid input. Please enter a number.");
//             }
//         }
//     }

//     private static bool GetCardioPreferenceInput()
//     {
//         return GetYesNoInput("Do you want to include a cardio day? (yes/no)");
//     }


//     private static string GetCardioTypeInput()
//     {
//         while (true)
//         {
//             Console.WriteLine("What general type of cardio are you interested in? (This helps us pick, but variety will be added!)");
//             Console.WriteLine("Options: Running, Biking, Sprints");
//             string response = Console.ReadLine().ToLower();
//             if (response == "running")
//             {
//                 return "Running";
//             }
//             else if (response == "biking")
//             {
//                 return Cycling;
//             }
//             else if (response == "sprints")
//             {
//                 return Sprints;
//             }
//             else
//             {
//                 Console.WriteLine("Choose: Running, Biking, or Sprints.");
//             }
//         }
//     }

//     private static int GetCardioDurationInput()
//     {
//         while (true)
//         {
//             Console.WriteLine("How long for your cardio session? (Please choose 30, 45, or 60 minutes)");
//             string input = Console.ReadLine();
//             int duration;
//             if (int.TryParse(input, out duration))
//             {
//                 if (input == "30")
//                 {
//                     return 30;
//                 }
//                 else if (input == "45")
//                 {
//                     return 45;
//                 }
//                 else if (input == "60")
//                 {
//                     return 60;
//                 }
//                 else
//                 {

//                     Console.WriteLine("Choose again.");
//                     return;
//                 }
//             }
//             // UserPreference userPreference = new UserPreference(hasBarbell, hasDumbbells, desiredStrengthExercisesPerDay, repPreference, wantsCardio, cardioType, cardioDurationMinutes, desiredCardioExercises);

//             // WorkoutGenerator generator = new WorkoutGenerator(userPreference, AllAvailableExercises);
//             // generator.GenerateWorkoutPlan();
//         }

//         //UserPreference userPreference = new UserPreference(hasBarbell, hasDumbbells, desiredStrengthExercises, repPreference, wantsCardio, cardioType, cardioDurationMinutes);


//     }
// }
using System;
using System.Collections.Generic;
using System.Linq; // Added for .ToList()

public class Program
{
    // PUSH Exercises
    public static readonly List<Exercise> PushExercisesBodyweight = new List<Exercise>
    {
        new Exercise("Push-ups", "Strength", "Push", "Bodyweight"),
        new Exercise("Plank", "Strength", "Push", "Bodyweight"),
        new Exercise("Plank-to-Pushup", "Strength", "Push", "Bodyweight"),
        new Exercise("Dips", "Strength", "Push", "Bodyweight"),
        new Exercise("Pike Push-ups", "Strength", "Push", "Bodyweight"),
        new Exercise("Archer Push-ups", "Strength", "Push", "Bodyweight"),
        new Exercise("Pseudo Planche Push-ups", "Strength", "Push", "Bodyweight"),
        new Exercise("Wall Push-ups", "Strength", "Push", "Bodyweight")
    };
    public static readonly List<Exercise> PushExercisesDumbbell = new List<Exercise>
    {
        new Exercise("Dumbbell Press", "Strength", "Push", "Dumbbells"),
        new Exercise("Dumbbell Fly", "Strength", "Push", "Dumbbells"),
        new Exercise("Dumbbell Shoulder Press", "Strength", "Push", "Dumbbells"),
        new Exercise("Dumbbell Arnold Press", "Strength", "Push", "Dumbbells"),
        new Exercise("Dumbbell Incline Press", "Strength", "Push", "Dumbbells"),
        new Exercise("Dumbbell Triceps Extension", "Strength", "Push", "Dumbbells"),
        new Exercise("Dumbbell Lateral Raises", "Strength", "Push", "Dumbbells")
    };
    public static readonly List<Exercise> PushExercisesBarbell = new List<Exercise>
    {
        new Exercise("Bench Press", "Strength", "Push", "Barbell"),
        new Exercise("Overhead Press", "Strength", "Push", "Barbell"),
        new Exercise("Incline Bench Press", "Strength", "Push", "Barbell"),
        new Exercise("Close-Grip Bench Press", "Strength", "Push", "Barbell"),
        new Exercise("Barbell Shoulder Press", "Strength", "Push", "Barbell"),
        new Exercise("Landmine Press", "Strength", "Push", "Barbell")
    };

    // PULL Exercises
    public static readonly List<Exercise> PullExercisesBodyweight = new List<Exercise>
    {
        new Exercise("Pull-Ups", "Strength", "Pull", "Bodyweight"),
        new Exercise("Chin-Ups", "Strength", "Pull", "Bodyweight"),
        new Exercise("Superman Pulls", "Strength", "Pull", "Bodyweight"),
        new Exercise("Reverse Snow Angels", "Strength", "Pull", "Bodyweight"),
        new Exercise("Towel Rows", "Strength", "Pull", "Bodyweight"),
        new Exercise("Wall Pulls", "Strength", "Pull", "Bodyweight"),
        new Exercise("Prone Arm Raises", "Strength", "Pull", "Bodyweight")
    };
    public static readonly List<Exercise> PullExercisesDumbbell = new List<Exercise>
    {
        new Exercise("Bent-over Rows", "Strength", "Pull", "Dumbbells"),
        new Exercise("Single-Arm Dumbbell Row", "Strength", "Pull", "Dumbbells"),
        new Exercise("Reverse Flys", "Strength", "Pull", "Dumbbells"),
        new Exercise("Chest-Supported Rows", "Strength", "Pull", "Dumbbells"),
        new Exercise("Dumbbell Deadlift", "Strength", "Pull", "Dumbbells")
    };
    public static readonly List<Exercise> PullExercisesBarbell = new List<Exercise>
    {
        new Exercise("Deadlift", "Strength", "Pull", "Barbell"),
        new Exercise("Pendlay Row", "Strength", "Pull", "Barbell"),
        new Exercise("Barbell Row", "Strength", "Pull", "Barbell"),
        new Exercise("Snatch-Grip Deadlift", "Strength", "Pull", "Barbell"),
        new Exercise("Rack Pulls", "Strength", "Pull", "Barbell"),
        new Exercise("Seal Row", "Strength", "Pull", "Barbell")
    };

    // LEG Exercises
    public static readonly List<Exercise> LegExercisesBodyweight = new List<Exercise>
    {
        new Exercise("Burpees", "Strength", "Leg", "Bodyweight"),
        new Exercise("Jump Squats", "Strength", "Leg", "Bodyweight"),
        new Exercise("Lunges", "Strength", "Leg", "Bodyweight"),
        new Exercise("Bodyweight Squats", "Strength", "Leg", "Bodyweight"),
        new Exercise("Wall Sit", "Strength", "Leg", "Bodyweight"),
        new Exercise("Step-Ups", "Strength", "Leg", "Bodyweight"),
        new Exercise("Glute Bridges", "Strength", "Leg", "Bodyweight"),
        new Exercise("Pistol Squats", "Strength", "Leg", "Bodyweight")
    };
    public static readonly List<Exercise> LegExercisesDumbbell = new List<Exercise>
    {
        new Exercise("Goblet Squats", "Strength", "Leg", "Dumbbells"),
        new Exercise("Dumbbell Lunges", "Strength", "Leg", "Dumbbells"),
        new Exercise("Dumbbell Step-Ups", "Strength", "Leg", "Dumbbells"),
        new Exercise("Dumbbell Romanian Deadlifts", "Strength", "Leg", "Dumbbells"),
        new Exercise("Dumbbell Bulgarian Split Squat", "Strength", "Leg", "Dumbbells"),
        new Exercise("Dumbbell Calf Raises", "Strength", "Leg", "Dumbbells")
    };
    public static readonly List<Exercise> LegExercisesBarbell = new List<Exercise>
    {
        new Exercise("Squats", "Strength", "Leg", "Barbell"),
        new Exercise("Front Squats", "Strength", "Leg", "Barbell"),
        new Exercise("Bulgarian Split Squat", "Strength", "Leg", "Barbell"),
        new Exercise("Deadlifts", "Strength", "Leg", "Barbell"),
        new Exercise("Romanian Deadlifts", "Strength", "Leg", "Barbell"),
        new Exercise("Barbell Calf Raises", "Strength", "Leg", "Barbell"),
        new Exercise("Good Mornings", "Strength", "Leg", "Barbell"),
        new Exercise("Hip Thrusts", "Strength", "Leg", "Barbell")
    };

    // Cardio Exercises
    public static readonly List<Exercise> RunningCardio = new List<Exercise>
    {
        new Exercise("Outdoor Run", "Cardio", "Running", "Bodyweight"),
        new Exercise("Treadmill Jog", "Cardio", "Running", "Bodyweight"),
        new Exercise("Running Sprints", "Cardio", "Sprints", "Bodyweight"), // Added for sprints
        new Exercise("Treadmill Sprints", "Cardio", "Sprints", "Bodyweight") // Added for sprints
    };
    public static readonly List<Exercise> CyclingCardio = new List<Exercise>
    {
        new Exercise("Outdoor Bike Ride", "Cardio", "Biking", "Bodyweight"),
        new Exercise("Stationary Bike", "Cardio", "Biking", "Bodyweight")
    };


    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the workout generator!");

        bool HasBarbell = GetYesNoInput("Do you have a barbell? (yes/no)");
        bool HasDumbbells = GetYesNoInput("Do you have dumbbells? (yes/no)");
        string repPreference = GetRepPreferenceInput("What is your rep preference for strength workouts? (Low, Medium, High)");
        int numberOfExercises = GetNumberOfExercisesInput();
        bool wantsCardio = GetCardioPreferenceInput();

        string cardioType = null;
        int cardioDurationMinutes = 0;

        if (wantsCardio)
        {
            cardioType = GetCardioTypeInput();
            cardioDurationMinutes = GetCardioDurationInput();
        }

        UserPreference userPreference = new UserPreference(HasBarbell, HasDumbbells, numberOfExercises, repPreference, wantsCardio, cardioType, cardioDurationMinutes);

        List<Exercise> allAvailableExercises = new List<Exercise>();

        allAvailableExercises.AddRange(PushExercisesBodyweight);
        allAvailableExercises.AddRange(PushExercisesDumbbell);
        allAvailableExercises.AddRange(PushExercisesBarbell);
        allAvailableExercises.AddRange(PullExercisesBodyweight);
        allAvailableExercises.AddRange(PullExercisesDumbbell);
        allAvailableExercises.AddRange(PullExercisesBarbell);
        allAvailableExercises.AddRange(LegExercisesBodyweight);
        allAvailableExercises.AddRange(LegExercisesDumbbell);
        allAvailableExercises.AddRange(LegExercisesBarbell);
        allAvailableExercises.AddRange(RunningCardio);
        allAvailableExercises.AddRange(CyclingCardio);


        WorkoutGenerator generator = new WorkoutGenerator(userPreference, allAvailableExercises);
        generator.GenerateWorkoutPlan();

        Console.WriteLine("\nPress any key to quit.");
        Console.ReadKey();
    }

    private static bool GetYesNoInput(string question)
    {
        while (true)
        {
            Console.WriteLine(question);
            string response = Console.ReadLine().ToLower();
            if (response == "yes")
            {
                return true;
            }
            else if (response == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }
        }
    }

    private static string GetRepPreferenceInput(string question)
    {
        while (true)
        {
            Console.WriteLine(question);
            Console.WriteLine("Options: Low, Medium, High");
            string response = Console.ReadLine().ToLower();
            if (response == "low")
            {
                return "Low";
            }
            else if (response == "medium")
            {
                return "Medium";
            }
            else if (response == "high")
            {
                return "High";
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'Low', 'Medium', or 'High'.");
            }
        }
    }

    private static int GetNumberOfExercisesInput()
    {
        while (true)
        {
            Console.WriteLine("How many exercises do you want to do in your workout?");
            Console.WriteLine("4: Thirty minutes");
            Console.WriteLine("6: Forty-five minutes");
            Console.WriteLine("8: One hour");
            Console.WriteLine("(Please enter the number correlating with your answer.)");
            string input = Console.ReadLine();
            
            int numExercises;
            if (int.TryParse(input, out numExercises))
            {
                if (numExercises == 4)
                {
                    return 4;
                }
                else if (numExercises == 6)
                {
                    return 6;
                }
                else if (numExercises == 8)
                {
                    return 8;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 4, 6, or 8.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    private static bool GetCardioPreferenceInput()
    {
        return GetYesNoInput("Do you want to include a cardio day? (yes/no)");
    }

    private static string GetCardioTypeInput()
    {
        while (true)
        {
            Console.WriteLine("What general type of cardio are you interested in? Remeber it was an option to not do this.");
            Console.WriteLine("Options: Running, Biking, Sprints");
            string response = Console.ReadLine().ToLower();
            if (response == "running")
            {
                return "Running";
            }
            else if (response == "biking")
            {
                return "Biking"; 
            }
            else if (response == "sprints")
            {
                return "Sprints"; 
            }
            else
            {
                Console.WriteLine("Choose: Running, Biking, or Sprints.");
            }
        }
    }

    private static int GetCardioDurationInput()
    {
        while (true)
        {
            Console.WriteLine("How long for your cardio session? (Please choose 30, 45, or 60 minutes)");
            string input = Console.ReadLine();
            int duration;
            if (int.TryParse(input, out duration))
            {

                if (duration == 30)
                {
                    return 30;
                }
                else if (duration == 45)
                {
                    return 45;
                }
                else if (duration == 60)
                {
                    return 60;
                }

                else
                {
                    Console.WriteLine("Choose again. Duration must be 30, 45, or 60. All other answers will be reject (insert rejection pun here)");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
