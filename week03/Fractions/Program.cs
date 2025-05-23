using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);
        Fraction f4 = new Fraction(1, 3);

        f2.SetTop(5);
        f3.SetTop(3);
        f3.SetBottom(4);


        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());


    }
}