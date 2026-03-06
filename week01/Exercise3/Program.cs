using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.Write("What is the margic number?  ");
        int magicNumber = int.Parse(Console.ReadLine());

        Console.Write("What is your guess?    ");
        int guess = int.Parse(Console.ReadLine());
    

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
    }

    
}
