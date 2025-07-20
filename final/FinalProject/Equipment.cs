class Equipment
{//  this class holds information about what the user has chosen as their avaliable equipment
    public bool HasBarbell { get; set; }
    public bool HasDumbbells { get; set; }
    public string Name { get; }
    public string Type { get; } 
    public string MuscleGroup { get; } 
    public string EquipmentRequired { get; } 

    public Equipment(bool hasBarbell, bool hasDumbbells)
    {
        HasBarbell = hasBarbell;
        HasDumbbells = hasDumbbells;
    }
}