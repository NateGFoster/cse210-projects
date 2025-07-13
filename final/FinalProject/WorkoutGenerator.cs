class WorkoutGenerator
{
    private string _GenerateStrengthWorkout;
    private string _cardioType;
    private int _durationMinutes;
    private static Random random;

    //private BaseRepStrategy _repStrategy;
    private UserPreference _userPreference;
    //public List<Exercise> GenerateStrengthWorkout();
    // {
    //     //this will be logic for sterength exercises
    //     //return new List<Exercise>(); //also a placeholder

    // }

    //public GenerateCardioWorkout();
    // {
    // // Logic to generate cardio exercise
    //  Console.WriteLine("");
    //     return null; // Placeholder
    // }                    

    public WorkoutGenerator(UserPreference userPreference)
    {
        _userPreference = userPreference;

    //     if (userPreference.PushRepPreference == "Low") // This is where polymorphism kicks in
    //     {
    //         _repStrategy = new LowRepStrategy();
    //     }
    //     else if (userPreference.PushRepPreference == "Medium")
    //     {
    //         _repStrategy = new MediumRepStrategy();
    //     }
    //     else if (userPreference.PushRepPreference == "High")
    //     {
    //         _repStrategy = new HighRepStrategy();
    //     }
    //     else
    //         return;

     }

    // public void GenerateStrengthWorkout()
    // {
    //     int reps = _repStrategy.GetReps();
    //     int sets = _repStrategy.GetSets();
    //     int restTime = _repStrategy.GetRestTimeSeconds();

    // }
}
                                              