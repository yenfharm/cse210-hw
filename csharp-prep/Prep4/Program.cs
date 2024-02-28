using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        int numberEntered = -1;


        while (numberEntered != 0)
        {
            Console.Write("Please, enter a series of numbers (STOP when enter the number 0): ");
            string numberUser = Console.ReadLine();
            numberEntered = int.Parse(numberUser);

            if (numberEntered != 0)
            {
                numbers.Add(numberEntered);
            }

        }
         int sum = 0;

         foreach (int number in numbers)
         {
            sum += number;
         }

         Console.WriteLine($"The total sum is = {sum}");
         
         
         float average = ((float)sum) / numbers.Count;
         Console.WriteLine($"The average is: {average}");

         int max = numbers[0];

         foreach (int number in numbers)
         {
            if (number > max)
            {
                max = number;
            }
         }

         Console.WriteLine($"The max number is: {max}");

    }
}