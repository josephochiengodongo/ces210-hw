using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        //Using constructor 1
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        //Using constructor 2
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());


        //Using construtor 3
        Fraction f3 = new Fraction(3,4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // Another example
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Testing setters and getters
        //Fraction f5 = new Fraction();
        // f5.SetTop(6);
        //f5.SetBottom(7);

        //Console.WriteLine(f5.GetFractionString());
        //Console.WriteLine($"Top: {f5.GetTop()}");
        //Console.WriteLine($"Bottom: {f5.GetBottom()}");
    }
}

        



    




    
