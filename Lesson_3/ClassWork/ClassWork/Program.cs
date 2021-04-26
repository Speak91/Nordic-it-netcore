using System;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //BooleanLessonPart(); //булева алгебра
            //ConstantLessonPart(); //константы
            //ObjectLessonPart();  //Тип данных Object
            //DynamicLessonPart(); //Тип данных Dynamic
            //VarLessonPart(); //Ключевое слово Var
            //ReferenceAndValueType(); //значимые(Reference) и ссылочные(Value) типы
            //ArraysLessonPart(); //Массивы
            //NullableLessonPart(); //Null
            //NullableSelfWork(); // Задача на понимание nullable и null
        }
        static void ArraysLessonPart()
        {
            const int constanta = 3;
            string[] threes = new string[constanta];
            threes[0] = "Ясень";
            threes[1] = "Клён";
            threes[2] = "Липа";

            int[] ages = new int[constanta];
            ages[0] = 21;
            ages[1] = 6;
            ages[2] = 42;

            for (int i = 0; i < constanta; i++)
            {
                Console.WriteLine($"{threes[i]} возраст в годах равен {ages[i]}");
            }

            string[] cities = new string[3];
            cities[0] = "Moscow";
            cities[1] = "New-York";
            cities[2] = "Dallas";

        }
        static void NullableSelfWork()
        {
            int? a = 5;
            float? b = null;
            Console.WriteLine($"Значение HasValue для a = {a.HasValue}");
            if (a.HasValue == true)
            {
                Console.WriteLine(a.Value);
            }
            Console.WriteLine($"Значение HasValue для b = {b.HasValue}");
            if (b.HasValue == true)
            {
                Console.WriteLine(b.HasValue);
            }
        }
        static void NullableLessonPart()
        {
            int? a = null;
            a = 5;
            float? b = null;
            //a = 12;
            if (a.HasValue && a.Value > 0)
            {
                Console.WriteLine(a * a);
            }



        }
       
        static void ReferenceAndValueType()
        {
            int A;
            A = 0;
            Console.WriteLine(A);

            object O = null;
            Console.WriteLine(O);
            O = new object();
            Console.WriteLine(O);

            string s = null;
            s = new string("SSS");
            s = "";

            s = string.Empty;
            Console.WriteLine(string.Empty == null);

            var sss = default(string);
            Console.WriteLine(sss);

        }
        static void VarLessonPart()
        {
            var name = "Alexander";
            Console.WriteLine(name.GetType().FullName);

            var age = 29;
            Console.WriteLine(age.GetType().FullName);
        }

        static void DynamicLessonPart() //не надо использовать
        {
            dynamic name = "Masha";
            Console.WriteLine(name.Length);

        }
        static void ObjectLessonPart()
        {
            object name = "Masha";
            Console.WriteLine($"{name} букв в имени {((string)name).Length}");
            Console.WriteLine(name);

            string name2 = "Sasha";
            Console.WriteLine(name2);
            Console.WriteLine($"{name2} букв в имени {name2.Length}");

        }
        static void ConstantLessonPart()
        {
            const string name = "Masha";
            const byte age = 20;

            string welcomeText = "Hello " + name;

        }
        static void BooleanLessonPart()
        {
            Boolean b1 = true;
            bool b2 = !b1;

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine();
            Console.WriteLine(3 > 7);
            Console.WriteLine("asdf" == "ASDF");
            Console.WriteLine(3.14F == 3.14);
            Console.WriteLine();
            Console.WriteLine(b1 == false);
            Console.WriteLine(b2 == false);

            //boolean operators
            // && - AND
            // || - OR
            Console.WriteLine("Boolean operators");
            Console.WriteLine(true || false || false || false || true);
            Console.WriteLine(false || false);
            Console.WriteLine();
            // bitwise operators
            // & - AND
            // | - OR
        }
    }
}
