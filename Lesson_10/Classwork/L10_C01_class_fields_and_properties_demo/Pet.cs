using System;

partial class Program
{
	class Pet
	{
		private string _birthPlace;
		private char _sex;
		private byte _age;

		public string Name;
		public PetKind Kind;
		public byte Age;

		public char Sex
		{
			get
			{
				return _sex;
			}
			set
			{
				if (value == 'm' || value == 'M' || value == 'f' || value == 'F')
				{
					_sex = value;
				}
				else
				{
					throw new InvalidOperationException("Sex should be M or F");
				}
			}
		}
	}
}
