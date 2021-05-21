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
            const double pi = 3.14;

            double rectangleLength = 0;
            double rectangleHeight = 0;
            double circleDiameter = 0;
            double triangleSide = 0;
            double area = 0;
            double perimetr = 0;



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
                        area = Math.Pow(circleDiameter, 2) / 4 * pi;
                        perimetr = circleDiameter * pi;
                        break;
                    case Shapes.Triangle:
                        Console.WriteLine("Выбран треугольник");
                        Console.WriteLine("Введите длину стороны");

                        triangleSide = Convert.ToDouble(Console.ReadLine());
                        area = Math.Pow(triangleSide, 2) * Math.Sqrt(3) / 4;
                        perimetr = 3 * triangleSide;
                        break;

                    case Shapes.Rectangle:
                        Console.WriteLine("Выбран прямоугольник");
                        Console.WriteLine("Введите длину прямоугольника:");
                        rectangleLength = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите высоту прямоугольника");
                        rectangleHeight = Convert.ToDouble(Console.ReadLine());
                        area = rectangleLength * rectangleHeight;
                        perimetr = 2 * (rectangleLength + rectangleHeight);
                        break;
                    default:
                        Console.WriteLine("Такой фигуры нету, программа завершает свою работу");
                        break;
                }
                Console.WriteLine($"Площадь выбранной фигуры = {area}");
                Console.WriteLine($"Периметр выбранной фигуры = {perimetr}");
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
    }
}
