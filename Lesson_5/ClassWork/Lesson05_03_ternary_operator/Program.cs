using System;

namespace Lesson05_03_ternary_operator
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 0;

			if (DateTime.Now.Minute > 10)
			{
				a = 3;
			}
			else
			{
				a = 15;
			}

			a = (DateTime.Now.Minute > 10) 
				? 3 
				: 15;



		}
	}
}
