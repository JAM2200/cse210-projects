using System.Diagnostics.Contracts;

class Fraction
{
    private int _bottomNumber;
    private int _topNumber;

    // Create a public constructor that takes no arguments.
    public Fraction()
    {
        // Set the top and bottom numbers equal to one to prevent unexpected behaviour.
        _topNumber = _bottomNumber = 1;
    }

    // Create a public constructor that takes one argument.
    public Fraction(int wholeNumber)
    {
        // Set the top number equal to the wholeNumber.
        _topNumber = wholeNumber;
        // Set the bottom number equal to on so that it doesn't produce unexpected behaviour.
        _bottomNumber = 1;
    }

    // Creat a third constructor that takes two arguments.
    public Fraction(int topNumber,int bottomNumber)
    {
        // Set the top number equal to topNumber and the bottom number equal to bottomNumber.
        _topNumber = topNumber;
        _bottomNumber = bottomNumber;
    }

    // A getter function to access the top number variable. 
    public int GetTop()
    {
        return _topNumber;
    }

    // A getter function to access the bottom number variable. 

    public int GetBottom()
    {
        return _bottomNumber;
    }

    // A setter function to change the top number variable.
    public void SetTop(int newTop)
    {
        _topNumber = newTop;
    }

    // A setter function to change the bottom number variable.
    public void SetBottom(int newBottom)
    {
        _bottomNumber = newBottom;
    }

    // A function to return the fraction in the form of "x/x."
    public string GetFractionString()
    {
        return _topNumber.ToString() + "/" + _bottomNumber.ToString(); 
    }

    // A function to return the fraction as a decimal number.
    public double GetFractionDecimal()
    {
            return (double) _topNumber / (double)_bottomNumber;
    }
}