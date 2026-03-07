using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        //First core (no loop)
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
            //second core (loop)
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
                Console.WriteLine("You guessed it");
            }

        }     
        // Third core, where we use a random number
        Random randomGenerator = new Random();
    
        magicNumber = randomGenerator.Next(1, 101);
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());
        
        // We could also use a do-while loop here...
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

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
}
            
    

            
    
    