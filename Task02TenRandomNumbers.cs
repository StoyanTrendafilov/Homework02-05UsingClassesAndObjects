//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;
using System.Threading;

class Task02TenRandomNumbers
{
    static int GenerateRandomNumber()
    {
        Random randGen = new Random();
        int rand = randGen.Next(100, 201); // we put 201, because if we put 200, the greatest generated number could be 199
        return rand;

    }

    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Random number № {0} = {1}.", i + 1, GenerateRandomNumber());
            Thread.Sleep(100); // we use this to delay the clock, because othwerwise we get same numbers.
        }
    }
}
