using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        //part 1 (no loop)
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
            while (guess != magicNumber)
            {
              Console.Write("What is your guess?  ");
              guess = int.Parse(Console.ReadLine()); 

              if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if(guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You nguessed it");
            }

            }        
    }        

}   

        

    



    




