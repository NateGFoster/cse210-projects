class WorkoutGenerator
{
    private static Random random = new Random();
    private UserPreference _userPreference;
    private List<Exercise> _allAvailableExercises;
    private RepStrategy _repStrategy; // I will need this for using polymorphism :)




    public WorkoutGenerator(UserPreference userPreference, List<Exercise> allAvailableExercises)
    {
        _userPreference = userPreference;
        _allAvailableExercises = allAvailableExercises;

        if (userPreference.RepPreference == "Low")
        {
            _repStrategy = new LowRepStrategy();
        }
        else if (userPreference.RepPreference == "Medium")
        {
            _repStrategy = new MediumRepStrategy();
        }
        else if (userPreference.RepPreference == "High")
        {
            _repStrategy = new HighRepStrategy();
        }
        else
        {
            Console.WriteLine("If you can't spell you can't lift heavy today: Defaulting to Medium Rep Strategy.");
            _repStrategy = new MediumRepStrategy();// this is just easier than having them re-enter their answer, well mabye it isn't and im just pissy today
        }
    }

    public void GenerateWorkoutPlan()
    {
        Console.WriteLine("\n--- Your Strength Workout Plan ---");
        GenerateDayWorkout("Push");

        GenerateDayWorkout("Pull");

        GenerateDayWorkout("Leg");

        if (_userPreference.WantsCardio)
        {
            GenerateCardioWorkout();
        }
    }

    private void GenerateDayWorkout(string muscleGroup)
    {
        List<Exercise> selectedExercises = SelectStrengthExercises(muscleGroup, _userPreference.NumberOfExercises);

        Console.WriteLine("\n- " + muscleGroup + " Day-");
        _repStrategy.GenerateWorkoutOutput(selectedExercises); // This calls polymorphism, the computing lab is saving me. 
    }

    private void GenerateCardioWorkout()
    {
        List<Exercise> potentialCardioExercises = new List<Exercise>();
        string userCardioType = _userPreference.CardioType.ToLower();

        foreach (Exercise exercise in _allAvailableExercises)
        {
            if (exercise.Type == "Cardio")
            {
                switch (userCardioType)
                {

                    case "running":
                        if (exercise.MuscleGroup == "Running")
                        {
                            potentialCardioExercises.Add(exercise);
                        }
                        break;
                    case "biking":
                        if (exercise.MuscleGroup == "Biking")
                        {
                            potentialCardioExercises.Add(exercise);
                        }
                        break;
                    case "sprints":
                        if (exercise.MuscleGroup == "Sprints")
                        {
                            potentialCardioExercises.Add(exercise);
                        }
                        break;
                 
        
                }
            }
        }

        Exercise selectedCardioActivity = potentialCardioExercises[random.Next(potentialCardioExercises.Count)];

        string cardioReps;
        string cardioWeightGuidance = " ";

        if (selectedCardioActivity.Name.ToLower().Contains("sprints"))
        {
            cardioReps = $"{_userPreference.CardioDurationMinutes / 3} do 15-20 hill sprints with about a 60-90 second rest in between.";
            cardioWeightGuidance = "Max effort.";
        }
        else if (selectedCardioActivity.Name.ToLower().Contains("treadmill sprints"))
        {
            cardioReps = $"{_userPreference.CardioDurationMinutes / 4} do 45-second treadmill sprints with one minute rest inbetween.";
            cardioWeightGuidance = "Max effort, short rest.";
        }
        
        else
        {
            cardioReps = $"{_userPreference.CardioDurationMinutes} minutes of continuous effort.";
            cardioWeightGuidance = "Keep a steady pace and remeber you're crazy for chosing to run.";
        }

        Console.WriteLine("\n --- Your Cardio Workout ---");

        Console.WriteLine($"{selectedCardioActivity.Name}: {cardioReps} ({cardioWeightGuidance})");
    }

    private List<Exercise> SelectStrengthExercises(string muscleGroup, int numExercises)
    {
        List<Exercise> filteredByMuscleGroup = new List<Exercise>();
        foreach (Exercise exercise in _allAvailableExercises)
        {
            if (exercise.Type == "Strength")
            {
                if (exercise.MuscleGroup == muscleGroup)
                {
                    filteredByMuscleGroup.Add(exercise);
                }
            }
        }

        List<Exercise> filteredByEquipment = new List<Exercise>();
        foreach (Exercise exercise in filteredByMuscleGroup)
        {
            switch (exercise.EquipmentRequired)
            {
                case "Bodyweight":
                    filteredByEquipment.Add(exercise);
                    break;

                case "Dumbbells":
                    if (_userPreference.HasDumbbells)
                    {
                        filteredByEquipment.Add(exercise);
                    }
                    break;
                case "Barbell":
                    if (_userPreference.HasBarbell)
                    {
                        filteredByEquipment.Add(exercise);
                    }
                    break;
            }
        }

        List<Exercise> finalSelectedExercises = new List<Exercise>();
        int exercisesToSelect = Math.Min(numExercises, filteredByEquipment.Count);

        for (int i = 0; i < exercisesToSelect; i++) // this uses my filter of equipment and my preference  of how many exercises I want 
        {
            int randomIndex = random.Next(filteredByEquipment.Count);

            finalSelectedExercises.Add(filteredByEquipment[randomIndex]);

            filteredByEquipment.RemoveAt(randomIndex);  // this stops duplicates or at least that's the plan
        }


        return finalSelectedExercises;

     } 
}