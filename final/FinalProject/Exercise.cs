public class Exercise
{
    public string Name { get; } // if you haven't noticed yet there are a lot of getters and setters in my program also useless comments.
    public string Type { get; }    public string MuscleGroup { get; } 
    public string EquipmentRequired { get; } 
    public Exercise(string name, string type, string muscleGroup, string equipmentRequired)
    {
        Name = name;
        Type = type;
        MuscleGroup = muscleGroup;
        EquipmentRequired = equipmentRequired;
    }
}