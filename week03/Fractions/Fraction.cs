using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //Getter and Setter for top
    public int GetTop(int top)
    {
        return _top;
    }

    //Getter and Setter for bottom
    public int GetBottom(int bottom)
    {
        return _bottom;
    }

    //Return fraction as a string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    //Return decimal value
    public double GetDecimalValue()
    {
        return (double) _top/_bottom;
    }

}