using lab1_ttriangle;
using System;

class lab1_ttriangl
{
    static void Main(string[] args)
    { 
        NonSet();
        // WithGetSet();
    }

    static void NonSet()
    {
        Console.WriteLine("Введіть сторони трикутника: ");
        double[] sides = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        var triangle = new Triangle(sides[0], sides[1], sides[2]);
        Console.WriteLine("Периметр трикутника: " + triangle.PerimeterOfTriangle(triangle.A, triangle.B, triangle.C));
        Console.WriteLine("Площа трикутника: " + triangle.Area(triangle.A, triangle.B, triangle.C));
        
    }

    static void WithGetSet()
    {
        var triangle1 = new Triangle(2,3,4);
        Console.WriteLine("Введіть сторони ще одного трикутника: ");
        double[] sides = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        triangle1.A = sides[0];
        triangle1.B = sides[1];
        triangle1.C = sides[2];
        Console.WriteLine("Периметр трикутника: " + triangle1.PerimeterOfTriangle(triangle1.A, triangle1.B, triangle1.C));
        Console.WriteLine("Площа трикутника: " + triangle1.Area(triangle1.A, triangle1.B, triangle1.C));
    }
}