using System;
using System.Collections.Generic;
using System.Text;

namespace L14_C06_static_members_in_regular_classes_demo
{
	public class Person
	{
		public static int InstancesCount { get; set; }

		public string Name { get; set; }

		static Person()
		{
			InstancesCount = -1;
			throw new Exception();
		}

		public Person()
		{
			InstancesCount++;
		}

		public static void GetParticularName(Person person)
		{
			Console.WriteLine(person.Name);
		}
	}
}
