using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        var fraction1 = new Fraction();
        var fraction2 = new Fraction(6);
        var fraction3 = new Fraction(6, 7);
        var fraction4 = new Fraction(7, 6);

        Console.WriteLine(fraction1.GetDecimalFraction());
        Console.WriteLine(fraction1.GetFractionString());

        Console.WriteLine(fraction2.GetDecimalFraction());
        Console.WriteLine(fraction2.GetFractionString());

        Console.WriteLine(fraction3.GetDecimalFraction());
        Console.WriteLine(fraction3.GetFractionString());

        Console.WriteLine(fraction4.GetDecimalFraction());
        Console.WriteLine(fraction4.GetFractionString());


    }
}