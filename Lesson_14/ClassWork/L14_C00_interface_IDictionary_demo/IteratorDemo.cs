using System;
using System.Collections.Generic;
using System.Text;

namespace L14_C00_interface_IDictionary_demo
{
	class IteratorDemo
	{
		private Dictionary<int, string> _dictionary;

		public IteratorDemo()
		{
			_dictionary = new Dictionary<int, string>();
		}

		public string this[int key]
		{ 
			get { return _dictionary[key]; } 
			set { _dictionary[key] = value; }
		}
	}
}
