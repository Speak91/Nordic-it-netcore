using System;

public class Pet
{
	private string _birthPlace;
	private char _sex;
	private byte _age;

	public PetKind Kind;
	public string Name;
	
	public char Sex
	{
		get { return _sex; }
		set
		{
			if (value == 'm' || value == 'f')
			{
				_sex = char.ToUpper(value);
			}
			else if (value == 'M' || value == 'F')
			{
				_sex = value;
			}
			else
			{
				throw new InvalidOperationException("Sex should be M or F");
			}
		}
	}
	
	public byte Age
	{
		get
		{
			return _age;
		}
		set
		{
			if (value >= 0)
			{
				_age = value;
			}
			else
			{
				throw new InvalidOperationException("Возраст не может быть меньше 0");
			}
		}
	}

	public string Description
	{
		get
		{
			return $"{Name} is a {Kind} /{Sex}/ of {Age} years old.";
		}
	}
}
