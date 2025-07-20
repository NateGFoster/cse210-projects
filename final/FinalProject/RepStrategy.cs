
using System.Collections.Generic; // Added for List<Exercise>
// this class is abstract meaning it deals with polymorphism formating exercise and dealing with additional notes. this project i discovered was not great to be built using OOP, but i put together what i could after making about 5 other planes to get this code to run before even starting to code.
public abstract class RepStrategy
{
    public abstract void GenerateWorkoutOutput(List<Exercise> exercises); // I am going to format the excerises differently depending on the rep strategy chosen as an example of polymorphism

    protected abstract string FormatExercise(Exercise exercise);
    protected abstract string AdditionalNotes();
}