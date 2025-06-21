public class Square : Shape
{
    public int side;
    
    public Square(string color, int sideLength) : base(color)
    {
        side = sideLength;
    }
    
    public override int CalculateArea()
    {
        return side * side;
    }
}
