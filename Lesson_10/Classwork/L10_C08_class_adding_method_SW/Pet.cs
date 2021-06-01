using System;

namespace L10_C08_class_adding_method_SW
{

	public class Pet
	{
		private string _birthPlace;
		private char _sex;

		public PetKind Kind;
		public string Name;

		public char Sex
		{
			get
			{
				return _sex;
			}
			set
			{
				if (value == 'f' || value == 'F' || value == 'm' || value == 'M')
				{
					_sex = char.ToUpper(value);
				}
				else
				{
					throw new Exception("Invalid value");
				}
			}
		}
		public byte Age { get; set; }

		public string Description
		{
			get
			{
				return $"{Name} is a {Kind} ({Sex}) of {Age} years old" +
					$" (birth place: {_birthPlace}).";
			}
		}

		public void SetBirthPlace(string birthPlace)
		{
			_birthPlace = birthPlace;
		}
	}
}
