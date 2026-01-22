using System;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    // Constructors
    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int top)
    {
        _topNumber = top;
        _bottomNumber = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    // Getters and Setters
    public int Numerator
    {
        get { return _topNumber; }
        set { _topNumber = value; }
    }

    public int Denominator
    {
        get { return _bottomNumber; }
        set { _bottomNumber = value; }
    }

    // Methods
    public string GetFractionString()
    {
        return $"{_topNumber}/{_bottomNumber}";
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / _bottomNumber;
    }
}
