// See https://aka.ms/new-console-template for more information
using ShapeDll;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Hello, MindBox");


Console.WriteLine($"Площадь круга с радиусом 4 = {new Circle(4).Area}");
Console.WriteLine($"Площадь треугольника со сторонами 2, 3, 4 = {new Triangle(2,3,4).Area}");
Console.WriteLine($"Площадь прямоугольника со сторонами 8 и 12 = {new Rectangle(8, 12).Area}");




// пользоваткель может создать свою фигуру, реализуя интерфейс Shape.
public class Rectangle : Shape
{
    private double _a;
    private double _b;

    public Rectangle(double a, double b)
    {
        _a = a;
        _b = b;
    }
    public double Area => _a * _b;
}







