
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesI;

class Program
{
    static void Main(string[] args)
    {
        ////!Exercise III.1
        ////Write a console - based application that sums the integers from 1 to 40 but no more that 49,99.
        Console.WriteLine("Exercise III.1 \n");
        double min = 1;
        double max = 49.99;
        double number;
        double Y = 0;
        bool Z;

        Console.WriteLine("Write value between {0} and {1}", min, max);
        double X = double.Parse(Console.ReadLine());

        while (Z = (X < min || X > max))
        {
            Console.WriteLine("This is wrong value, try one more time");
            X = double.Parse(Console.ReadLine());
        }
        Y += X;
        while (X < max)
        {

            Console.WriteLine("Write next value");
            number = double.Parse(Console.ReadLine());

            while (Z = (number < min || number > max))
            {
                Console.WriteLine("This is wrong value, try one more time");
                number = double.Parse(Console.ReadLine());
            }

            X += number;

            if (X < max)
            {
                Y += number;
                Console.WriteLine("Sum is {0}", Y);
            }
        }
        Console.WriteLine("It is to much, your last sumed value under 49,99 was {0}", Y);


        // !Exercise III.2
        //Write a console - basedd application that prompts a user for
        //an hourly pay rate.While the user enters value less then $5.65
        //or greater than $49, 99, continue to prompt the user. Before the
        // program ends, display the valid pay rate.
        Console.WriteLine("\nExercise III.2.1 \n");
        double payRate;

        do
        {
            Console.WriteLine("Enter valid pay rate");
            payRate = double.Parse(Console.ReadLine());
        }
        while (payRate < 5.65 || payRate > 49.99);
        Console.WriteLine("The valid pay rate that you entered is {0}", payRate);



        //// !Another way to do this
        Console.WriteLine("\nExercise III.2.2 \n");

        for (double payRate2 = double.Parse(Console.ReadLine()); payRate2 < 5.65 || payRate2 > 49.99; payRate2 = double.Parse(Console.ReadLine()))
        {
            Console.WriteLine("Enter valid pay rate");

        }
        Console.WriteLine("You entered valid pay rate");

        //// !Exercise III.3
        Console.WriteLine("\nExercise III.3 \n");

        int minNumber = 1;
        int maxNumber = 50;
        int sum = 0;
        int numberToSum = minNumber;

        while (numberToSum <= maxNumber)
        {
            sum += numberToSum;
            numberToSum++;
        }
        Console.WriteLine("Result of the sum of numbers {0} to {1} equals {2}", minNumber, maxNumber, sum);


        //// !Exercise III.4
        Console.WriteLine("\nExercise III.4 \n");

        int amountOfGuesses = 1;
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 11);
        Console.WriteLine("Guess the number 1-10");



        for (int guess = int.Parse(Console.ReadLine()); guess != randomNumber; guess = int.Parse(Console.ReadLine()))
        {

            if (guess > randomNumber)
            {
                Console.WriteLine("Yours number was to high, try again!", randomNumber);
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("Yours number was to low, try again!", randomNumber);
            }

            amountOfGuesses++;

            //randomGenerator = new Random();
            //randomNumber = randomGenerator.Next(1, 11);
        }
        Console.WriteLine("Perfect, you are lucky! You needed {0} tryes", amountOfGuesses);


        //// Second way, but a little upgraded


        Random randomGenerator1 = new Random();
        int randomNumber1 = randomGenerator1.Next(1, 11);
        int guess1;
        int amountOfGuesses1 = 0;

        Console.WriteLine("Guess the number 1-10");


        do
        {
            guess1 = int.Parse(Console.ReadLine());

            amountOfGuesses1++;
            if (guess1 > randomNumber1)
            {
                Console.WriteLine("Yours number was to high", randomNumber1);
            }
            else if (guess1 < randomNumber1)
            {
                Console.WriteLine("Yours number was to low", randomNumber1);
            }
            else
            {
                Console.WriteLine("Perfect, guess {0} is your lucky!", amountOfGuesses1);
            }

            if (amountOfGuesses1 == 5)
            { Console.WriteLine("You didn't make it {0} times, sorry, but all the best for you!", amountOfGuesses1); }

        } while (guess1 != randomNumber1 && amountOfGuesses1 < 5);


    }
}

