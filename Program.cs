
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
        //!Exercise III.1
  
        double minPayRate = 5.65;
        double maxPayRate = 49.99;
        double hourlyPayRate;
        double Y = 0;
        bool Z;

        Console.WriteLine("Write value between {0} and {1}", minPayRate, maxPayRate);
        double X = double.Parse(Console.ReadLine());      
     
        while (Z = (X < minPayRate || X > maxPayRate))
        {
            Console.WriteLine("This is wrong value, try one more time");
            X = double.Parse(Console.ReadLine());
        }
        Y += X;
        while (X < maxPayRate)
            {

                Console.WriteLine("Write next value");
                hourlyPayRate = double.Parse(Console.ReadLine());

                while (Z = (hourlyPayRate < minPayRate || hourlyPayRate > maxPayRate))
                {
                Console.WriteLine("This is wrong value, try one more time");
                hourlyPayRate = double.Parse(Console.ReadLine());
                }

                X += hourlyPayRate;

                if (X < maxPayRate)
                {
                    Y += hourlyPayRate;
                    Console.WriteLine("Sum is {0}", Y);
                }
            }
            Console.WriteLine("It is to much, your last value under 49,99 was {0}", Y);


        //!Exercise III.2
        //Write a console - basedd application that prompts a user for
        //an hourly pay rate.While the user enters value less then $5.65
        //or greater than $49, 99, continue to prompt the user. Before the
        // program ends, display the valid pay rate.




    }
}

