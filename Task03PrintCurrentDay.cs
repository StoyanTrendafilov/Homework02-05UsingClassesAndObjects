//Write a program that prints to the console which day of the week is today. Use System.DateTime.


using System;

class Task03PrintCurrentDay
{
    static void Main(string[] args)
    {
        DateTime current = DateTime.Now;
        Console.WriteLine("Today is "+ current.DayOfWeek + ".");
    }
}

