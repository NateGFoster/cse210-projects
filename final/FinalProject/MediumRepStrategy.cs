class MediumRepStrategy : RepStrategy
{
    public override void GenerateWorkoutOutput(List<Exercise> exercises)
    {
        Console.WriteLine("\n Medium Rep Strength Workout (Focus: Hypertrophy, it is recommendable to do this strategy the most.)");
        foreach (var exercise in exercises)
        {
            Console.WriteLine(FormatExercise(exercise));
        }
        Console.WriteLine(AdditionalNotes());
    }

    protected override string FormatExercise(Exercise exercise)
    {
        return $"{exercise.Name}: 3 sets of 8-10 reps with moderate weight.";
    }

    protected override string AdditionalNotes()
    {
        return "Rest 60-90 seconds between sets.";
    }
}