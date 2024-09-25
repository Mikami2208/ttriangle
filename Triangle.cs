namespace lab1_ttriangle;

public class Triangle
{
    private double _a;
    private double _b;
    private double _c;
    public Triangle(double a, double b, double c)
    {
        

        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException("Invalid triangle");
        }

        if (b >= a + c || a >= b + c || c >= a + b)
        {
            throw new ArgumentException("Bad triangle");

        }

        _a = a;
        _b = b;
        _c = c;
        

    }

    public static bool IsExist(double a, double b, double c)
    {
        return (a < b + c && b < a + c && c < b + a);
    }

    public double A
    {
        get { return _a; }
        set
        {
            if (IsExist(value, _b, _c))
                _a = value;
            else
                throw new ArgumentException("bad triangle");
        }
    }
    public double B
    {
        get { return _b; }
        set
        {
            if (IsExist(_a, value, _c))
                _b = value;
            else
                throw new ArgumentException("bad triangle");
        }
    }
    public double C
    {
        get { return _c; }
        set
        {
            if (IsExist(_a, _b, value))
                _c = value;
            else
                throw new ArgumentException("bad triangle");
            
        }
    }
    public double PerimeterOfTriangle(double a, double b, double c)
    {
        return a + b + c;
    }

    public double Area(double a, double b, double c)
    {
        double halfPerimetr = PerimeterOfTriangle(a, b, c) / 2;
        double area = Math.Sqrt(halfPerimetr * (halfPerimetr - a) * (halfPerimetr - a) * (halfPerimetr - a));
        return area;
    }
    
    
}
