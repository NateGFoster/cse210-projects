public class Shape
{
    public string color;
    
    public Shape(string shapeColor)
    {
        color = shapeColor;
    }
    
    public virtual int CalculateArea()
    {
        return 0;
    }
}