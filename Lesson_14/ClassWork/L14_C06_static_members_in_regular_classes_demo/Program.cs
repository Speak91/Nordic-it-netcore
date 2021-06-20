using System;

namespace L14_C06_static_members_in_regular_classes_demo
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.Write("Enter persons count: ");
			//int count = int.Parse(Console.ReadLine());

			//Person.InstancesCount = 100;

			//Person[] persons = new Person[count];
			//for (int i = 0; i < count; i++)
			//{
			//	persons[i] = new Person();
			//}

			//Console.WriteLine(Person.InstancesCount);

			//Person.GetParticularName(persons[0]);

			string message = "test message";
			string prefixFormat = "yyyy-MM-dd hh:mm:ss";
			string prefix = DateTime.Now.ToString(prefixFormat);
			Console.WriteLine(prefix + " " + message);

		}
	}
}
