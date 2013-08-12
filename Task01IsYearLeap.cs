//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.


using System;

class Task01IsYearLeap
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter one year here : ");
        int year = int.Parse(Console.ReadLine());
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("The year is leap !");
        }
        else
        {
            Console.WriteLine("The year is not leap !" );
        }
    }
}

