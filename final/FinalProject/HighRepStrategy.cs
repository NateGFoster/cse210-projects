class HighRepStrategy : RepStrategy
{
    public override void GenerateWorkoutOutput(List<Exercise> exercises)
    {
        Console.WriteLine("\n High Rep Strength Workout (Focus: Endurance)");
        foreach (var exercise in exercises)
        {
            Console.WriteLine(FormatExercise(exercise));
        }
        Console.WriteLine(AdditionalNotes());
    }

    protected override string FormatExercise(Exercise exercise)
    {
        return $"{exercise.Name}: 3 sets of 15-20 reps with a light weight.";
    }
    protected override string AdditionalNotes()
    {
        return "Rest 2 to 3 minutes between sets. Focus on muscular endurance and high volume.";
    }

    

 
}
