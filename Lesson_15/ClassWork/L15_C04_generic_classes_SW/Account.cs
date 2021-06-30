using System;
using System.Collections.Generic;
using System.Text;

namespace L15_C04_generic_classes_SW
{
	public class Account<T>: BaseAccount
	{
		public T Id { get; private set; }

		public string Name { get; private set; }

		public Account(T id, string name)
		{
			Id = id;
			Name = name;
		}

		public override void WriteProperties()
		{
			Console.WriteLine($"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}");
		}
	}

	public class BaseAccount
	{
		public virtual void WriteProperties()
		{
		}
	}
}
