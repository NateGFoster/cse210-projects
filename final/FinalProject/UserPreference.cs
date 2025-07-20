class UserPreference // this class is kinda self explainitory, it stores what the user has set from the questions inside program.
{
    public bool HasBarbell { get; }
    public bool HasDumbbells { get; }
    public int NumberOfExercises { get; }
    public string RepPreference { get; }
    public bool WantsCardio { get; }
    public string CardioType { get; }
    public int CardioDurationMinutes { get; }

    public UserPreference(bool hasBarbell, bool hasDumbbells, int numberOfExercises, string repPreference, bool wantsCardio, string cardioType, int cardioDurationMinutes)
    {
        HasBarbell = hasBarbell;
        HasDumbbells = hasDumbbells;
        NumberOfExercises = numberOfExercises;
        RepPreference = repPreference;
        WantsCardio = wantsCardio;
        CardioType = cardioType;
        CardioDurationMinutes = cardioDurationMinutes;
    }
}