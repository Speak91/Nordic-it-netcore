using System;
using System.Collections.Generic;
using System.Text;

namespace L15_C01_generic_methods
{
	public class Account<T>
	{
		public T Id { get; private set; }

		public string Name { get; set; }

		public Account()
		{
		}

		public Account(T id, string name)
		{
			Id = id;
			Name = name;
		}

		public void WriteProperties()
		{
			Console.WriteLine(ToString());
		}

		public override string ToString()
		{
			return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
		}
	}
}
