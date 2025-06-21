public class Rectangle : Shape
{
    public int length;
    public int width;
    
    public Rectangle(string color, int rectLength, int rectWidth) : base(color)
    {
        length = rectLength;
        width = rectWidth;
    }
    
    public override int CalculateArea()
    {
        return length * width;
    }
}