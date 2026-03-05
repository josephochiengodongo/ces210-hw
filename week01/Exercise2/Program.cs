using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your grade percentage? ");
        string answer =Console.ReadLine();
        int grade = int.Parse(answer);
        string sign = "";
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter="B";
        }
        else if (grade >=70)
        {
            letter="C";
        }
        else if (grade >=60)
        {
            letter="D";
        }
        else
        {
            letter="F";
        }

        //strech challege: determine + 

        int lastDigit =grade % 10; 

        if (lastDigit >= 7)
        {
            sign ="+";
        }
        else if (lastDigit <3)
        {
            sign ="-";
        }
        else
        {
            sign ="";
        }
        //strech challange:exception F+,F- and A+
        if (letter == "A" && sign == "+")
        {
            sign = "";//no A+
        }
        else if (letter == "F")
        {
            sign = "F"; //no F+ and F-
        }

        Console.WriteLine($"Your grade is:{letter}{sign}");
        if (grade >= 70)
        {
            Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("Better luck next time");
        }
    
        
    }
}
    
