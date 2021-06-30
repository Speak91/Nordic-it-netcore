using System;
using System.Collections.Generic;
using System.Text;

namespace L15_C01_generic_methods
{
	class AccountFabrique
	{
		//public Account<T> CreateAccount<T>(T id, string name)
		//{
		//	return new Account<T>(id, name);
		//}

		public T CreateAccount<T>() where T : Account<int>, new()
		{
			return new T();
		}
	}
}
