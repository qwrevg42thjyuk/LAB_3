using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class Class1
    {
    }
}
using System; 

// Завдання 1: Клас Rectangle
class Rectangle
{
    private double side1;
    private double side2;

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public double CalculateArea()
    {
        return side1 * side2;
    }

    public double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }

    public double Area
    {
        get { return CalculateArea(); }
    }

    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

// Завдання 2: Клас Point
class Point
{
    public double X { get; }
    public double Y { get; }
    public string Name { get; }

    public Point(double x, double y, string name)
    {
        X = x;
        Y = y;
        Name = name;
    }
}

// Завдання 2: Клас Figure
class Figure
{
    private Point[] points;

    public Figure(Point p1, Point p2, Point p3)
    {
        points = new Point[] { p1, p2, p3 };
    }

    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
        points = new Point[] { p1, p2, p3, p4 };
    }

    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
    {
        points = new Point[] { p1, p2, p3, p4, p5 };
    }

    public double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            Point currentPoint = points[i];
            Point nextPoint = (i == points.Length - 1) ? points[0] : points[i + 1];
            perimeter += GetSideLength(currentPoint, nextPoint);
        }
        Console.WriteLine($"Периметр багатокутника: {perimeter}");
    }
}

class Programm
{
    static void Main()
    {
        // Завдання 1: Введення довжин сторін прямокутника
        Console.Write("Введіть довжину першої сторони прямокутника: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Введіть довжину другої сторони прямокутника: ");
        double side2 = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(side1, side2);

        Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
        Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");

        // Завдання 2: Створення багатокутника і розрахунок периметру
        Point p1 = new Point(0, 0, "A");
        Point p2 = new Point(0, 3, "B");
        Point p3 = new Point(4, 0, "C");

        Figure triangle = new Figure(p1, p2, p3);
        triangle.CalculatePerimeter();
    }
}
