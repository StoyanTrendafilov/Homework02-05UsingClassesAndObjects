//You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum. Example:
		//string = "43 68 9 23 318"  result = 461


using System;

class Task06SumNumbersInStringArray
{
    static void Main(string[] args)
    {
        string numbers = "23 888 199 100 1 3 6";
        string[] number = numbers.Split(' ');
        int sum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            sum += int.Parse(number[i]);
        }
        Console.WriteLine(sum);
    }
}

