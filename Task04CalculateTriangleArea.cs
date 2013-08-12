//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; 
//Three sides; 
//Two sides and an angle between them. Use System.Math.

using System;

class Task04CalculateTriangleArea
{
    static void CalculateBySideAndAltitude()
    {
        Console.Clear();
        Console.WriteLine("You have chosen 1: \n\"Calculate the area of the triangle by given side and altitude to it.\"");
        Console.WriteLine();
        Console.Write("Please, enter the length of the side : ");
        double side = double.Parse(Console.ReadLine());
        Console.Write("Please, enter the lentgth of the altitude : ");
        double altitude = double.Parse(Console.ReadLine());
        double area = (side * altitude) / 2;
        Console.WriteLine("The area of your triangle is : {0}.", area);
    }

    static void CalclulateTriangleByThreeSides()
    {
        Console.Clear();
        Console.WriteLine("You have chosen 2: \n\"Calculate the area of the triangle by given three sides.\"");
        Console.WriteLine();
        Console.WriteLine("Please, enter the length of side AB : ");
        double sideAB = double.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter the length of side BC : ");
        double sideBC = double.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter the length of side CA : ");
        double sideCA = double.Parse(Console.ReadLine());
        double halfPerimeter = (sideAB + sideBC + sideCA) / 2;
        double area = Math.Sqrt((halfPerimeter*(halfPerimeter - sideAB) * (halfPerimeter - sideBC) * (halfPerimeter - sideCA)));
        Console.WriteLine("The area of your triangle is : {0}.", area);
    }

    static void CalculateTriangleByTwoSidesAndAngleBetweenThem()
    {
        Console.Clear();
        Console.WriteLine("You have chosen 3: \n\"Calculate the area of the triangle by given two sides and the angle between \nthem.\"");
        Console.WriteLine();
        Console.WriteLine("Please, enter the length of your first side : ");
        double sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("Please, etner the length of your second side : ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Please, enter the angle between your sides : ");
        double angle = double.Parse(Console.ReadLine());
        double area = (Math.Sin(angle) * sideA * sideB) / 2;
        Console.WriteLine("The area of your triangle is : {0}.", area);
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Please, choose one of the variants to calculate the triangle's area : ");
        Console.WriteLine("=========================================================================");
        Console.WriteLine("1. Calculate the area of the triangle by given side and altitude to it." );
        Console.WriteLine("2. Calculate the area of the triangle by given three sides." );
        Console.WriteLine("3. Calculate the area of the triangle by given two sides and the angle between \nthem.");
        Console.WriteLine("==========================");
        Console.Write("Enter your choice here : ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1 : CalculateBySideAndAltitude(); break;
            case 2: CalclulateTriangleByThreeSides(); break;
            case 3: CalculateTriangleByTwoSidesAndAngleBetweenThem(); break;

            default: Console.WriteLine("Wrong input, restart the program");
                break;
        }
    }
}

