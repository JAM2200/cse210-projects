using System.Diagnostics.Contracts;

class Fraction
{
    private int _bottomNumber;
    private int _topNumber;

    public Fraction()
    {
        _topNumber = _bottomNumber = 1;
    }

    public Fraction(int wholeNumber)
    {
        _topNumber = wholeNumber;
        _bottomNumber = 1;
    }

    public Fraction(int topNumber,int bottomNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = bottomNumber;
    }

    public int GetTop()
    {
        return _topNumber;
    }

    public int GetBottom()
    {
        return _bottomNumber;
    }

    public void SetTop(int newTop)
    {
        _topNumber = newTop;
    }

    public void SetBottom(int newBottom)
    {
        _bottomNumber = newBottom;
    }

    public string GetFractionString()
    {
        return _topNumber.ToString() + "/" + _bottomNumber.ToString(); 
    }

    public double GetFractionDecimal()
    {
            return (double) _topNumber / (double)_bottomNumber;
    }
}