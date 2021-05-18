using System;

namespace HomeWork
{
    class Program
    {
        enum Shapes
        {
            Сircle = 1,
            Triangle = 2,
            Rectangle = 3
        }
        static void Main(string[] args)
        {
            double rectangleLength = 0;
            double rectangleHeight = 0;
            double rectangleArea = 0;
            double rectanglePerimeter = 0;
            
            double circleDiameter = 0;
            double circleArea = 0;
            double circlePerimeter = 0;

            double triangleSide = 0;
            double triangleArea = 0;
            double trianglePerimeter = 0;

            string triangle = "Треугольника";
            string circle = "Круга";
            string rectangle = "Прямоугольника";
            string square = "Площадь";
            const double pi = 3.14; 
            
            Console.WriteLine("Выберите тип фигуры: 1 - круг, 2 - равносторонний треугольник, 3 - прямоугольник");
            
            try
            {
                int shapesNumber = Convert.ToInt32(Console.ReadLine());
                Shapes shapes = (Shapes)shapesNumber;
                
                switch (shapes)
                {
                    case Shapes.Сircle:
                        Console.WriteLine("Выбран круг");
                        Console.WriteLine("Введите диаметр");
                        
                        circleDiameter = Convert.ToDouble(Console.ReadLine());
                        circleArea = Math.Pow(circleDiameter, 2) / 4 * pi;
                        circlePerimeter = circleDiameter * pi;

                        Print(square, circle, circleArea);
                        Print("Периметр", circle, circlePerimeter);
                        Console.WriteLine($"Периметр круга: {circlePerimeter}");
                        break;
                    
                    case Shapes.Triangle:
                        Console.WriteLine("Выбран треугольник");
                        Console.WriteLine("Введите длину стороны");
                        
                        triangleSide = Convert.ToDouble(Console.ReadLine());
                        triangleArea = Math.Pow(triangleSide, 2) * Math.Sqrt(3) / 4;
                        trianglePerimeter = 3 * triangleSide;
                        
                        Console.WriteLine($"Площадь треугольника: {triangleArea}");
                        Console.WriteLine($"Периметр треугольника: {trianglePerimeter}");
                        break;
                    
                    case Shapes.Rectangle:
                        Console.WriteLine("Выбран прямоугольник");
                        Console.WriteLine("Введите длину прямоугольника:");
                       
                        rectangleLength = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите высоту прямоугольника");
                        rectangleHeight = Convert.ToDouble(Console.ReadLine());
                        
                        rectangleArea = rectangleLength * rectangleHeight;
                        rectanglePerimeter = 2 * (rectangleLength + rectangleHeight);
                        Console.WriteLine($"Площадь поверхности: {rectangleArea}");
                        Console.WriteLine($"Длина периметра: { rectanglePerimeter}");
                        
                        break;
                    default:
                        Console.WriteLine("Такой фигуры нету, программа завершает свою работу");
                        break;
                }
            }
            
            catch (FormatException)
            {
                Console.WriteLine("Введено некорректное значение, программа завершает свою работу");
            }
            
            catch (Exception e)
            {
                Console.WriteLine("Что то пошло не так, покажите разработчику строчку ниже");
                Console.WriteLine(e);
            }

        }
        static void Print(string a, string b, double c)
        {
            Console.WriteLine($"{a} {b} = {c}" );
        }
    }
}
