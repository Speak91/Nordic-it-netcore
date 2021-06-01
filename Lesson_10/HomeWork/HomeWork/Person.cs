using System;

namespace HomeWork
{
    class Person
    {
        public string Name { get; set; }
        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0 && value < 150)
                {
                    _age = value;
                }
                else
                {
                    throw new Exception("Возраст не может быть меньше 0 или больше 200");
                }
            }
        }

        public string AgeАfterFourYears
        {
            get
            {
                return $"{_age + 4}";
            }
        }

        public string Description
        {
            get
            {
                return $"{Name} ваш возраст через 4 года будет = {AgeАfterFourYears}";
            }
        }

        public void Input(int personNumber)
        {
            Console.Write($"Введите имя №{personNumber + 1}: ");
            Name = Console.ReadLine();
            Console.Write($"Введите возраст №{personNumber + 1}: ");
            Age = int.Parse(Console.ReadLine());
        }
    }
}
