class LowRepStrategy : RepStrategy
{
    private Animation _animation = new Animation();
    protected override string FormatExercise(Exercise exercise)
    {
        return $"{exercise.Name}: 4 sets of 5 reps with heavy weight.";
    }
    protected override string AdditionalNotes()
    {
        return "Rest 2 minutes between sets. Don't have crap form.";
    }
    public override void GenerateWorkoutOutput(List<Exercise> exercises)
    {
        {
            Console.WriteLine("\n=== PREPARING FOR LOW REP STRENGTH WORKOUT (Primary Focus: Glory) ===");
            _animation.showSpinner(3); 

            Console.WriteLine("\n--- Your Low Rep Strength Session ---");
            Console.WriteLine("---------------------------------------------------------------");
            foreach (var exercise in exercises)
            {
                Console.WriteLine(FormatExercise(exercise));
            }
            Console.WriteLine(AdditionalNotes());
        }
    }
}