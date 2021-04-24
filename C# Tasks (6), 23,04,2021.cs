#pragma warning disable CS0660 // Tür operator == or operator != öðesini tanýmlar, ancak Object.Equals(object o) öðesini geçersiz kýlmaz
#pragma warning disable CS0661 // Type operator == or operator != öðesini tanýmlar, ancak Object.GetHashCode() öðesini geçersiz kýlmaz
class Fraction
#pragma warning restore CS0661 // Type operator == or operator != öðesini tanýmlar, ancak Object.GetHashCode() öðesini geçersiz kýlmaz
#pragma warning restore CS0660 // Tür operator == or operator != öðesini tanýmlar, ancak Object.Equals(object o) öðesini geçersiz kýlmaz
{
    private double _deficitSpeed;
    private double _deficitDenominator;


    public Fraction(double deficitDenominator, double deficitSpeed)
    {
        _deficitDenominator = deficitDenominator;
        _deficitSpeed = deficitSpeed;
    }


    public static Fraction operator +(Fraction f, int i)
    {
        return new Fraction(f._deficitDenominator + i, f._deficitSpeed + i);
    }

    public static Fraction operator +(Fraction f, double i)
    {
        return new Fraction(f._deficitDenominator + i, f._deficitSpeed + i);
    }

    public static Fraction operator -(Fraction f, int i)
    {
        return new Fraction(f._deficitDenominator - i, f._deficitSpeed - i);
    }

    public static Fraction operator -(Fraction f, double i)
    {
        return new Fraction(f._deficitDenominator - i, f._deficitSpeed - i);
    }

    public static Fraction operator *(Fraction f, int i)
    {
        return new Fraction(f._deficitDenominator * i, f._deficitSpeed * i);
    }

    public static Fraction operator *(Fraction f, double i)
    {
        return new Fraction(f._deficitDenominator * i, f._deficitSpeed * i);
    }

    public static Fraction operator *(int i, Fraction f)
    {
        return new Fraction(f._deficitDenominator * i, f._deficitSpeed * i);
    }

    public static Fraction operator /(Fraction f, int i)
    {
        return new Fraction(f._deficitDenominator / i, f._deficitSpeed / i);
    }

    public static Fraction operator /(Fraction f, double i)
    {
        return new Fraction(f._deficitDenominator / i, f._deficitSpeed / i);
    }

    public static bool operator ==(Fraction f, bool i)
    {
        if (i == true)
        {
            if (f._deficitDenominator != 0 && f._deficitSpeed != 0) return true;
        }
        return false;
    }

    public static bool operator !=(Fraction f, bool i)
    {
        if (f._deficitDenominator != 0 && f._deficitSpeed != 0) return true;
        return false;
    }

    public static bool operator true(Fraction f)
    {
        if (f._deficitDenominator != 0 && f._deficitSpeed != 0) return true;
        return false;
    }

    public static bool operator false(Fraction f)
    {
        if (f._deficitDenominator != 0 && f._deficitSpeed != 0) return true;
        return false;
    }
}