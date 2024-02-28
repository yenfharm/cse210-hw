using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number?: ");
        // int magicNumber = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0,100);
        
        int myGuess = 0;

        while (randomNumber != myGuess)
        {

            Console.Write("What is your guess?: ");
            myGuess = int.Parse(Console.ReadLine());
            
            if (randomNumber < myGuess)
            {
                Console.WriteLine("Lower");
            }

            else if (randomNumber > myGuess)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it");
            }
        }  
    }
        
        
}