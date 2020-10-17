using System;

public class Auto
{
    private int _doors;
    private string _cylinders;
    private int _year;
    private string _model;
    public Auto(string model, int year, int doors,
                      string cylinders)
    {
        _model = model;
        _year = year;
        _doors = doors;
        _cylinders = cylinders;
    }
    public int Doors
    { get { return _doors; } }

    public string Model
    { get { return _model; } }

    public int Year
    { get { return _year; } }

    public string Cylinders
    { get { return _cylinders; } }

    public override string ToString()
    {
        return ToString("G");
    }
    public string ToString(string fmt)
    {
        if (string.IsNullOrEmpty(fmt))
            fmt = "G";

        switch (fmt.ToUpperInvariant())
        {
            case "G":
                return string.Format("{0} {1}", _year, _model);
            case "D":
                return string.Format("{0} {1}, {2} dr.",
                                     _year, _model, _doors);
            case "C":
                return string.Format("{0} {1}, {2}",
                                     _year, _model, _cylinders);
            case "A":
                return string.Format("{0} {1}, {2} dr. {3}",
                                     _year, _model, _doors, _cylinders);
            default:
                string msg = string.Format("'{0}' is an invalid format string",
                                           fmt);
                throw new ArgumentException(msg);
        }
    }
}
public class Example
{
    public static void Main()
    {
        Console.Title = "By Denis Rafi";
        var auto = new Auto("Jeep Gladiator", 2020, 4, "V8");
        Console.WriteLine(auto.ToString());
        Console.WriteLine(auto.ToString("A"));
        Console.ReadKey();

    }
}
