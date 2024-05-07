// See https://aka.ms/new-console-template for more information

using SquareLibrary;

try
{
    Figure circle = new Circle(2);
    Triangle triangle = new Triangle(6, 3);
    Console.WriteLine(circle.Area().ToString() + "   " +
    triangle.Area().ToString());
    if (triangle.IsSquare()) Console.WriteLine("Triangle is Square");
    else Console.WriteLine("Triangle is not Square");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}




