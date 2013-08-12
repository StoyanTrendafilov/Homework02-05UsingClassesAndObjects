//Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays,
//specified preliminary as array.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Task05CountWorkDays
{

    static int ReturnAllDays (DateTime from, DateTime to)
    {
        int returnValue = 0;

        for (DateTime date = from; date < to; date = date.AddDays(1))
        {
            if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
            {
                returnValue++;
            }
        }

        return returnValue;
    }

    static int ReturnWantedCount(DateTime from, DateTime to, int numberOfDays, DateTime[] holidays)
    {
        
        for (DateTime date = from; date < to; date = date.AddDays(1))
        {
            for (int i = 0; i < holidays.Length; i++)
            {
                if (date == holidays[i] && date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                {
                    numberOfDays--;
                    break;
                }
            }
            if (date > holidays[holidays.Length-1])
            {
                for (int i = 0; i < holidays.Length; i++)
                {
                    holidays[i] = holidays[i].AddYears(1);
                }
            }
        }
                
        return numberOfDays;
    }

    static void Main(string[] args)
    {
        DateTime startDate = DateTime.Today.Date;
        Console.Write("Please, enter the last day of your period in this way \"year.month.day\" : ");
        string[] endDate = Console.ReadLine().Split('.'); // creates an array of strings, divided with "/"
        int day = int.Parse(endDate[2]);
        int month = int.Parse(endDate[1]);
        int year = int.Parse(endDate[0]);
        DateTime finalDate = new DateTime(year, month, day);
        Console.WriteLine(finalDate);
        DateTime[] Holidays =   { new DateTime(2013, 1, 1), 
                                  new DateTime(2013, 3, 1), 
                                  new DateTime(2013, 3, 3), 
                                  new DateTime(2013, 4, 1),
                                  new DateTime(2013, 6, 1), // my birthday
                                  new DateTime(2013, 12, 24),
                                  new DateTime(2013, 12, 25),
                                  new DateTime(2013, 12, 31),
                                };

        int allDays = ReturnAllDays(startDate, finalDate);
        Console.WriteLine("Number of all days is " + allDays);

        int finalDays = ReturnWantedCount(startDate, finalDate, allDays, Holidays);
        Console.WriteLine("Number of all working days without the holidays is : " + finalDays);
    }
}
