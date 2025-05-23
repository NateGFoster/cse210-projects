public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
         _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public Fraction()
    {

    }
    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public void SetBottom(int Bottom)
    {
        _top = Bottom;
    }
    public string GetFractrionString()
    {
        return $"{_top}/{_bottom}";
    }
      public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
 