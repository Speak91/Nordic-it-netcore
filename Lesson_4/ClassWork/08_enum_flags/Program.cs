using System;

namespace _08_enum_flags
{
    //[Flags]
    //enum Days
    //{
    //    None = 0,
    //    Mo = 1,
    //    Tu = 2,
    //    We = 4,
    //    Th = 8,
    //    Fr = 16,
    //    Sa = 32,
    //    Su = 64
    //}
    [Flags]
    enum Days
    {
        None = 0,
        Mo = 0x1,
        Tu = 0x2,
        We = 0x4,
        Th = 0x8,
        Fr = 0x10,
        Sa = 0x20,
        Su = 0x40
    }
    [Flags]
    enum Colors
    {
        Black = 0x1,
        Blue = 0x2,
        Cyan = 0x4,
        Grey = 0x8,
        Green = 0x10,
        Magenta = 0x20, //32
        Red = 0x40, //64
        White = 0x80, //128
        Yellow = 0x160 //
    }
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            var a = 0;
            Console.WriteLine("Выберите любимые цвета");
            foreach (var item in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine($"{count++}.{item}");
            }
            for (int i = 0; i < 3; i++)
            {
                var str1 =(Colors)Enum.Parse(typeof(Colors),Console.ReadLine());
            }


            //Days workingDays = (Days)31; 
            //Console.WriteLine(workingDays);

            ////add separate
            //workingDays = workingDays | Days.Sa;
            //Console.WriteLine(workingDays);

            //workingDays = workingDays ^ Days.Mo;
            //Console.WriteLine(workingDays);

            //bool thursdayIsWorking =
            //    (workingDays & Days.Th) == Days.Th;
            //Console.WriteLine(thursdayIsWorking);
        }
    }
}
