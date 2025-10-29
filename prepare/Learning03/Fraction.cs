using System;
using System.Runtime.Versioning;

//.........................................................................//
class Fraction
{   //variables
    private int _top;
    private int _bottom;


    //.......................................................................//

    //Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    //............................................................................//
    //Get/Set methods
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

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    //......................................................................//

    //Real Methods

    public string GetFractionString()
    {
        string fraction = $"{GetTop()}/{GetBottom()}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}