public class Circle : Shape
{
    public int radius;
    
    public Circle(string color, int circleRadius) : base(color)
    {
        radius = circleRadius;
    }
    
    public override int CalculateArea()
    {
        return 3 * radius * radius; 
    }
}