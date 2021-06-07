using System;
using System.Collections.Generic;
using System.Text;

namespace L11_C00_HomeWork_Review
{
	class Person
	{
		private int _age;

		public string Name { get; set; }

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

		public int AgeАfterFourYears
		{
			get
			{
				return _age + 4;
			}
		}

		public string Description
		{
			get
			{
				return $"{Name} ваш возраст через 4 года будет = {AgeАfterFourYears}";
			}
		}

		public void UpdateProperties(string name, int age)
		{
			Name = name;
			Age = age;
		}

		//public void UpdateProperties(string name2, int age2)
		//{
		//	Name = name2;
		//	Age = age2;
		//}

		public void UpdateProperties(string name)
		{
			Name = name;
		}

		public void UpdateProperties(int age)
		{
			Age = age;
		}

		//public bool UpdateProperties(string name, int age)
		//{
		//	try
		//	{
		//		Name = name;
		//		Age = age;

		//		return true;
		//	}
		//	catch (Exception)
		//	{
		//		return false;
		//	}
		//}
	}
}
